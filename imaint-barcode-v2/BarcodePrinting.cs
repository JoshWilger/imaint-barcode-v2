using DymoSDK;
using DymoSDK.Implementations;
using DymoSDK.Interfaces;
using imaint_barcode_v2.DataContracts;
using Logging;
using System;
using System.IO;
using System.Windows.Forms;

namespace imaint_barcode_v2
{
    public partial class BarcodePrinting : Form
    {
        private readonly IDymoLabel dymoSDKLabel;

        private readonly ILogWrapper _logger = new LogWrapper();

        public BarcodePrinting()
        {
            InitializeComponent();

            try
            {
                App.Init();
                dymoSDKLabel = DymoLabel.Instance;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void SetSiteName_Click(object sender, EventArgs e)
        {
            new SetSite().ShowDialog();
            Text = string.Format("{0} ({1}) - {2}", Application.ProductName, Properties.Settings.Default.Version, Properties.Settings.Default.SiteName);
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BarcodePrinting_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.SizeSelection)
            {
                case 0:
                    LabelOneSelection.Checked = true;
                    break;

                case 1:
                    LabelTwoSelection.Checked = true;
                    break;

                case 2:
                    LabelThreeSelection.Checked = true;
                    break;
            }

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.SiteName))
            {
                var response = new SetSite();
                response.ShowDialog();
            }
            Text = string.Format("{0} ({1}) - {2}", Application.ProductName, Properties.Settings.Default.Version, Properties.Settings.Default.SiteName);

            PartNumber.Text = Properties.Settings.Default.LastPart;

            SetupLabelWriterSelection();
        }

        private void SetupLabelWriterSelection()
        {
            Printer.Items.Clear();

            foreach (IPrinter printer in DymoPrinter.Instance.GetPrinters())
            {
                var item = new Classes.Printer()
                {
                    Name = printer.Name
                };
                Printer.Items.Add(item.Name);
            }

            if (Printer.Items.Count > 0)
                Printer.SelectedIndex = 0;

            Printer.Enabled = Printer.Items.Count > 0;
        }

        private void DisplayBarcode_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastPart = PartNumber.Text;
            Properties.Settings.Default.Save();

            try
            {
                var partItem = new DatabaseService().GetPartData(PartNumber.Text.Trim());

                if (partItem.ID == null)
                {
                    MessageBox.Show("Part could not be found");
                    return;
                }

                SetAndLimitLabelText(partItem);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void SetAndLimitLabelText(Part partItem)
        {
            var labelOneText = Helper.SubdivideString(partItem.Description, Properties.Settings.Default.LabelOneAndTwoMaxLineLength, 2);
            var labelTwoText = Helper.SubdivideString(partItem.Description, Properties.Settings.Default.LabelOneAndTwoMaxLineLength, 3);
            var labelThreeText = Helper.SubdivideString(partItem.Description, Properties.Settings.Default.LabelThreeMaxLineLength, 4);

            // Label One
            LabelOneLineOne.Text = labelOneText[0];
            LabelOneLineTwo.Text = labelOneText[1];

            // Label Two
            LabelTwoLineOne.Text = labelTwoText[0];
            LabelTwoLineTwo.Text = labelTwoText[1];
            LabelTwoLineThree.Text = labelTwoText[2];

            // Label Three
            LabelThreeLineOne.Text = labelThreeText[0];
            LabelThreeLineTwo.Text = labelThreeText[1];
            LabelThreeLineThree.Text = labelThreeText[2];
            LabelThreeLineFour.Text = labelThreeText[3];

            // All Three Labels
            LabelOneBarcode.Text = LabelTwoBarcode.Text = LabelThreeBarcode.Text = partItem.ID;
            LabelOneAdditionalInfo.Text = LabelTwoAdditionalInfo.Text = LabelThreeAdditionalInfo.Text = string.Format("{0} / {1}", partItem.ID, partItem.WhsLocation);
        }

        private void LabelOneSelection_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Checked)
            {
                Properties.Settings.Default.SizeSelection = 0;
                Properties.Settings.Default.Save();
            }
        }

        private void LabelTwoSelection_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Checked)
            {
                Properties.Settings.Default.SizeSelection = 1;
                Properties.Settings.Default.Save();
            }
        }

        private void LabelThreeSelection_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Checked)
            {
                Properties.Settings.Default.SizeSelection = 2;
                Properties.Settings.Default.Save();
            }
        }

        private void PrintBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                var quantity = string.IsNullOrWhiteSpace(Quantity.Text.Trim()) ? 0 : Convert.ToInt32(Quantity.Text.Trim());

                if (quantity > 0)
                {
                    var printer = (string)Printer.SelectedItem;

                    PrepareConnectLabel(Directory.GetCurrentDirectory());
                    DymoPrinter.Instance.PrintLabel(dymoSDKLabel, printer, quantity);
                }
                else
                {
                    MessageBox.Show("Enter a valid quantity.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void PrepareConnectLabel(string workingDirectory)
        {
            if (LabelOneSelection.Checked)
            {
                dymoSDKLabel.LoadLabelFromFilePath(workingDirectory + "\\labelOne.label");
                dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblTop"), LabelOneLineOne.Text.Trim());
                dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblTop2"), LabelOneLineTwo.Text.Trim());
            }
            else if (LabelTwoSelection.Checked)
            {
                dymoSDKLabel.LoadLabelFromFilePath(workingDirectory + "\\labelTwo.label");
                dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblTop"), LabelTwoLineOne.Text.Trim());
                dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblTop2"), LabelTwoLineTwo.Text.Trim());
                dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblTop3"), LabelTwoLineThree.Text.Trim());
            }
            else if (LabelThreeSelection.Checked)
            {
                dymoSDKLabel.LoadLabelFromFilePath(workingDirectory + "\\labelThree.label");
                dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblTop"), LabelThreeLineOne.Text.Trim());
                dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblTop2"), LabelThreeLineTwo.Text.Trim());
                dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblTop3"), LabelThreeLineThree.Text.Trim());
                dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblTop4"), LabelThreeLineFour.Text.Trim());
            }
            else
            {
                MessageBox.Show("Please choose a label size.");
                return;
            }

            // These should be the same for every label
            dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblBarcode"), LabelOneBarcode.Text.Trim());
            dymoSDKLabel.UpdateLabelObject(dymoSDKLabel.GetLabelObject("lblBottom"), LabelOneAdditionalInfo.Text.Trim());
        }
    }
}
