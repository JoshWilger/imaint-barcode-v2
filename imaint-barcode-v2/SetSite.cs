using imaint_barcode_v2.DataContracts;
//using Logging;
using System;
using System.Windows.Forms;

namespace imaint_barcode_v2
{
    public partial class SetSite : Form
    {
        //private readonly ILogWrapper _logger = new LogWrapper();

        public SetSite()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SiteName.Text))
            {
                Properties.Settings.Default.SiteName = SiteName.Text;
                Properties.Settings.Default.Save();
                DialogResult = DialogResult.OK;
                Close();
            }
            Close();
        }

        private void SetSite_Load(object sender, EventArgs e)
        {
            try
            {
                var sites = new DatabaseService().GetSiteNames();

                SiteName.Items.Clear();

                foreach (DataContracts.Site site in sites)
                {
                    SiteName.Items.Add(site.Name);
                }

                SiteName.SelectedIndex = string.IsNullOrWhiteSpace(Properties.Settings.Default.SiteName) ? 0 : SiteName.FindStringExact(Properties.Settings.Default.SiteName);
                Properties.Settings.Default.SiteName = SiteName.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
