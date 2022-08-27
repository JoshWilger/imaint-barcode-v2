
namespace imaint_barcode_v2
{
    partial class BarcodePrinting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodePrinting));
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tssMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSiteName = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.Quantity = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Printer = new System.Windows.Forms.ComboBox();
            this.DisplayBarcode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PartNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpLabelTypes = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelThreeLineFour = new System.Windows.Forms.Label();
            this.LabelThreeAdditionalInfo = new System.Windows.Forms.Label();
            this.LabelThreeLineThree = new System.Windows.Forms.Label();
            this.LabelThreeLineTwo = new System.Windows.Forms.Label();
            this.LabelThreeLineOne = new System.Windows.Forms.Label();
            this.LabelThreeBarcode = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelTwoLineOne = new System.Windows.Forms.Label();
            this.LabelTwoLineThree = new System.Windows.Forms.Label();
            this.LabelTwoAdditionalInfo = new System.Windows.Forms.Label();
            this.LabelTwoLineTwo = new System.Windows.Forms.Label();
            this.LabelTwoBarcode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelOneLineTwo = new System.Windows.Forms.Label();
            this.LabelOneLineOne = new System.Windows.Forms.Label();
            this.LabelOneBarcode = new System.Windows.Forms.Label();
            this.LabelOneAdditionalInfo = new System.Windows.Forms.Label();
            this.LabelThreeSelection = new System.Windows.Forms.RadioButton();
            this.LabelTwoSelection = new System.Windows.Forms.RadioButton();
            this.LabelOneSelection = new System.Windows.Forms.RadioButton();
            this.PrintBarcode = new System.Windows.Forms.Button();
            this.statusMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.grpLabelTypes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMessage});
            this.statusMain.Location = new System.Drawing.Point(0, 1264);
            this.statusMain.Name = "statusMain";
            this.statusMain.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusMain.Size = new System.Drawing.Size(1156, 22);
            this.statusMain.TabIndex = 85;
            // 
            // tssMessage
            // 
            this.tssMessage.Name = "tssMessage";
            this.tssMessage.Size = new System.Drawing.Size(0, 15);
            // 
            // mnuMain
            // 
            this.mnuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1156, 46);
            this.mnuMain.TabIndex = 84;
            this.mnuMain.Text = "Main Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetSiteName,
            this.ExitApplication});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(76, 42);
            this.mnuFile.Text = "File";
            // 
            // SetSiteName
            // 
            this.SetSiteName.Name = "SetSiteName";
            this.SetSiteName.Size = new System.Drawing.Size(314, 46);
            this.SetSiteName.Text = "Set Site Name";
            this.SetSiteName.Click += new System.EventHandler(this.SetSiteName_Click);
            // 
            // ExitApplication
            // 
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(314, 46);
            this.ExitApplication.Text = "Exit Application";
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Quantity.Location = new System.Drawing.Point(429, 1163);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Quantity.Mask = "0000";
            this.Quantity.Name = "Quantity";
            this.Quantity.PromptChar = ' ';
            this.Quantity.Size = new System.Drawing.Size(120, 48);
            this.Quantity.TabIndex = 83;
            this.Quantity.Text = "1";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(86, 1100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 82;
            this.label3.Text = "Select Printer";
            // 
            // Printer
            // 
            this.Printer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Printer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Printer.FormattingEnabled = true;
            this.Printer.Location = new System.Drawing.Point(429, 1100);
            this.Printer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(693, 37);
            this.Printer.TabIndex = 81;
            // 
            // DisplayBarcode
            // 
            this.DisplayBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DisplayBarcode.Location = new System.Drawing.Point(895, 57);
            this.DisplayBarcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DisplayBarcode.Name = "DisplayBarcode";
            this.DisplayBarcode.Size = new System.Drawing.Size(227, 63);
            this.DisplayBarcode.TabIndex = 80;
            this.DisplayBarcode.Text = "Get Part Data";
            this.DisplayBarcode.UseVisualStyleBackColor = true;
            this.DisplayBarcode.Click += new System.EventHandler(this.DisplayBarcode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(86, 1160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 29);
            this.label2.TabIndex = 79;
            this.label2.Text = "Number of Barcodes to Print";
            // 
            // PartNumber
            // 
            this.PartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PartNumber.Location = new System.Drawing.Point(387, 71);
            this.PartNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Size = new System.Drawing.Size(425, 35);
            this.PartNumber.TabIndex = 78;
            this.PartNumber.Text = "brng-001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "Enter Part Number to find";
            // 
            // grpLabelTypes
            // 
            this.grpLabelTypes.Controls.Add(this.label4);
            this.grpLabelTypes.Controls.Add(this.panel3);
            this.grpLabelTypes.Controls.Add(this.panel2);
            this.grpLabelTypes.Controls.Add(this.panel1);
            this.grpLabelTypes.Controls.Add(this.LabelThreeSelection);
            this.grpLabelTypes.Controls.Add(this.LabelTwoSelection);
            this.grpLabelTypes.Controls.Add(this.LabelOneSelection);
            this.grpLabelTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpLabelTypes.Location = new System.Drawing.Point(27, 125);
            this.grpLabelTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLabelTypes.Name = "grpLabelTypes";
            this.grpLabelTypes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpLabelTypes.Size = new System.Drawing.Size(1161, 912);
            this.grpLabelTypes.TabIndex = 76;
            this.grpLabelTypes.TabStop = false;
            this.grpLabelTypes.Text = "Display on Barcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Select Label Size";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LabelThreeLineFour);
            this.panel3.Controls.Add(this.LabelThreeAdditionalInfo);
            this.panel3.Controls.Add(this.LabelThreeLineThree);
            this.panel3.Controls.Add(this.LabelThreeLineTwo);
            this.panel3.Controls.Add(this.LabelThreeLineOne);
            this.panel3.Controls.Add(this.LabelThreeBarcode);
            this.panel3.Location = new System.Drawing.Point(309, 619);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 221);
            this.panel3.TabIndex = 22;
            // 
            // LabelThreeLineFour
            // 
            this.LabelThreeLineFour.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Bold);
            this.LabelThreeLineFour.Location = new System.Drawing.Point(25, 88);
            this.LabelThreeLineFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThreeLineFour.Name = "LabelThreeLineFour";
            this.LabelThreeLineFour.Size = new System.Drawing.Size(468, 31);
            this.LabelThreeLineFour.TabIndex = 24;
            this.LabelThreeLineFour.Text = "Part Description Line Four";
            // 
            // LabelThreeAdditionalInfo
            // 
            this.LabelThreeAdditionalInfo.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.LabelThreeAdditionalInfo.Location = new System.Drawing.Point(4, 170);
            this.LabelThreeAdditionalInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThreeAdditionalInfo.Name = "LabelThreeAdditionalInfo";
            this.LabelThreeAdditionalInfo.Size = new System.Drawing.Size(489, 35);
            this.LabelThreeAdditionalInfo.TabIndex = 25;
            this.LabelThreeAdditionalInfo.Text = "Part Number / Location";
            this.LabelThreeAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelThreeLineThree
            // 
            this.LabelThreeLineThree.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Bold);
            this.LabelThreeLineThree.Location = new System.Drawing.Point(25, 62);
            this.LabelThreeLineThree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThreeLineThree.Name = "LabelThreeLineThree";
            this.LabelThreeLineThree.Size = new System.Drawing.Size(468, 26);
            this.LabelThreeLineThree.TabIndex = 22;
            this.LabelThreeLineThree.Text = "Part Description Line Three";
            // 
            // LabelThreeLineTwo
            // 
            this.LabelThreeLineTwo.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Bold);
            this.LabelThreeLineTwo.Location = new System.Drawing.Point(25, 37);
            this.LabelThreeLineTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThreeLineTwo.Name = "LabelThreeLineTwo";
            this.LabelThreeLineTwo.Size = new System.Drawing.Size(468, 25);
            this.LabelThreeLineTwo.TabIndex = 21;
            this.LabelThreeLineTwo.Text = "Part Description Line Two";
            // 
            // LabelThreeLineOne
            // 
            this.LabelThreeLineOne.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Bold);
            this.LabelThreeLineOne.Location = new System.Drawing.Point(25, 11);
            this.LabelThreeLineOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThreeLineOne.Name = "LabelThreeLineOne";
            this.LabelThreeLineOne.Size = new System.Drawing.Size(468, 26);
            this.LabelThreeLineOne.TabIndex = 20;
            this.LabelThreeLineOne.Text = "Part Description Line One";
            // 
            // LabelThreeBarcode
            // 
            this.LabelThreeBarcode.Font = new System.Drawing.Font("3 of 9 Barcode", 25F);
            this.LabelThreeBarcode.Location = new System.Drawing.Point(68, 119);
            this.LabelThreeBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelThreeBarcode.Name = "LabelThreeBarcode";
            this.LabelThreeBarcode.Size = new System.Drawing.Size(394, 51);
            this.LabelThreeBarcode.TabIndex = 19;
            this.LabelThreeBarcode.Text = "Barcode";
            this.LabelThreeBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LabelTwoLineOne);
            this.panel2.Controls.Add(this.LabelTwoLineThree);
            this.panel2.Controls.Add(this.LabelTwoAdditionalInfo);
            this.panel2.Controls.Add(this.LabelTwoLineTwo);
            this.panel2.Controls.Add(this.LabelTwoBarcode);
            this.panel2.Location = new System.Drawing.Point(309, 314);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 233);
            this.panel2.TabIndex = 21;
            // 
            // LabelTwoLineOne
            // 
            this.LabelTwoLineOne.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.LabelTwoLineOne.Location = new System.Drawing.Point(24, 11);
            this.LabelTwoLineOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTwoLineOne.Name = "LabelTwoLineOne";
            this.LabelTwoLineOne.Size = new System.Drawing.Size(630, 37);
            this.LabelTwoLineOne.TabIndex = 26;
            this.LabelTwoLineOne.Text = "Part Description Line One";
            // 
            // LabelTwoLineThree
            // 
            this.LabelTwoLineThree.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.LabelTwoLineThree.Location = new System.Drawing.Point(24, 86);
            this.LabelTwoLineThree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTwoLineThree.Name = "LabelTwoLineThree";
            this.LabelTwoLineThree.Size = new System.Drawing.Size(630, 40);
            this.LabelTwoLineThree.TabIndex = 25;
            this.LabelTwoLineThree.Text = "Part Description Line Three";
            // 
            // LabelTwoAdditionalInfo
            // 
            this.LabelTwoAdditionalInfo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.LabelTwoAdditionalInfo.Location = new System.Drawing.Point(-6, 177);
            this.LabelTwoAdditionalInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTwoAdditionalInfo.Name = "LabelTwoAdditionalInfo";
            this.LabelTwoAdditionalInfo.Size = new System.Drawing.Size(602, 36);
            this.LabelTwoAdditionalInfo.TabIndex = 24;
            this.LabelTwoAdditionalInfo.Text = "Part Number / Location";
            this.LabelTwoAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTwoLineTwo
            // 
            this.LabelTwoLineTwo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.LabelTwoLineTwo.Location = new System.Drawing.Point(24, 48);
            this.LabelTwoLineTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTwoLineTwo.Name = "LabelTwoLineTwo";
            this.LabelTwoLineTwo.Size = new System.Drawing.Size(630, 38);
            this.LabelTwoLineTwo.TabIndex = 22;
            this.LabelTwoLineTwo.Text = "Part Description Line Two";
            // 
            // LabelTwoBarcode
            // 
            this.LabelTwoBarcode.Font = new System.Drawing.Font("3 of 9 Barcode", 25F);
            this.LabelTwoBarcode.Location = new System.Drawing.Point(85, 126);
            this.LabelTwoBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTwoBarcode.Name = "LabelTwoBarcode";
            this.LabelTwoBarcode.Size = new System.Drawing.Size(448, 51);
            this.LabelTwoBarcode.TabIndex = 19;
            this.LabelTwoBarcode.Text = "Barcode";
            this.LabelTwoBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LabelOneLineTwo);
            this.panel1.Controls.Add(this.LabelOneLineOne);
            this.panel1.Controls.Add(this.LabelOneBarcode);
            this.panel1.Controls.Add(this.LabelOneAdditionalInfo);
            this.panel1.Location = new System.Drawing.Point(309, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 187);
            this.panel1.TabIndex = 20;
            // 
            // LabelOneLineTwo
            // 
            this.LabelOneLineTwo.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Bold);
            this.LabelOneLineTwo.Location = new System.Drawing.Point(25, 35);
            this.LabelOneLineTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOneLineTwo.Name = "LabelOneLineTwo";
            this.LabelOneLineTwo.Size = new System.Drawing.Size(429, 32);
            this.LabelOneLineTwo.TabIndex = 23;
            this.LabelOneLineTwo.Text = "Part Description Line Two";
            // 
            // LabelOneLineOne
            // 
            this.LabelOneLineOne.Font = new System.Drawing.Font("Courier New", 7F, System.Drawing.FontStyle.Bold);
            this.LabelOneLineOne.Location = new System.Drawing.Point(25, 7);
            this.LabelOneLineOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOneLineOne.Name = "LabelOneLineOne";
            this.LabelOneLineOne.Size = new System.Drawing.Size(429, 29);
            this.LabelOneLineOne.TabIndex = 17;
            this.LabelOneLineOne.Text = "Part Description Line One";
            // 
            // LabelOneBarcode
            // 
            this.LabelOneBarcode.Font = new System.Drawing.Font("3 of 9 Barcode", 25F);
            this.LabelOneBarcode.Location = new System.Drawing.Point(43, 80);
            this.LabelOneBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOneBarcode.Name = "LabelOneBarcode";
            this.LabelOneBarcode.Size = new System.Drawing.Size(386, 54);
            this.LabelOneBarcode.TabIndex = 19;
            this.LabelOneBarcode.Text = "Barcode";
            this.LabelOneBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelOneAdditionalInfo
            // 
            this.LabelOneAdditionalInfo.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.LabelOneAdditionalInfo.Location = new System.Drawing.Point(4, 134);
            this.LabelOneAdditionalInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOneAdditionalInfo.Name = "LabelOneAdditionalInfo";
            this.LabelOneAdditionalInfo.Size = new System.Drawing.Size(450, 37);
            this.LabelOneAdditionalInfo.TabIndex = 18;
            this.LabelOneAdditionalInfo.Text = "Part Number / Location";
            this.LabelOneAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelThreeSelection
            // 
            this.LabelThreeSelection.Location = new System.Drawing.Point(36, 666);
            this.LabelThreeSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LabelThreeSelection.Name = "LabelThreeSelection";
            this.LabelThreeSelection.Size = new System.Drawing.Size(162, 62);
            this.LabelThreeSelection.TabIndex = 2;
            this.LabelThreeSelection.Text = "2-1/8\" x 1\"";
            this.LabelThreeSelection.UseVisualStyleBackColor = true;
            this.LabelThreeSelection.CheckedChanged += new System.EventHandler(this.LabelThreeSelection_CheckedChanged);
            // 
            // LabelTwoSelection
            // 
            this.LabelTwoSelection.Location = new System.Drawing.Point(36, 374);
            this.LabelTwoSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LabelTwoSelection.Name = "LabelTwoSelection";
            this.LabelTwoSelection.Size = new System.Drawing.Size(221, 62);
            this.LabelTwoSelection.TabIndex = 1;
            this.LabelTwoSelection.Text = "3-1/2\" x 1-1/8\"";
            this.LabelTwoSelection.UseVisualStyleBackColor = true;
            this.LabelTwoSelection.CheckedChanged += new System.EventHandler(this.LabelTwoSelection_CheckedChanged);
            // 
            // LabelOneSelection
            // 
            this.LabelOneSelection.Checked = true;
            this.LabelOneSelection.Location = new System.Drawing.Point(36, 85);
            this.LabelOneSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LabelOneSelection.Name = "LabelOneSelection";
            this.LabelOneSelection.Size = new System.Drawing.Size(162, 62);
            this.LabelOneSelection.TabIndex = 0;
            this.LabelOneSelection.TabStop = true;
            this.LabelOneSelection.Text = "2\" x 3/4\"";
            this.LabelOneSelection.UseVisualStyleBackColor = true;
            this.LabelOneSelection.CheckedChanged += new System.EventHandler(this.LabelOneSelection_CheckedChanged);
            // 
            // PrintBarcode
            // 
            this.PrintBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrintBarcode.Location = new System.Drawing.Point(916, 1160);
            this.PrintBarcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintBarcode.Name = "PrintBarcode";
            this.PrintBarcode.Size = new System.Drawing.Size(206, 60);
            this.PrintBarcode.TabIndex = 75;
            this.PrintBarcode.Text = "Print Barcode";
            this.PrintBarcode.UseVisualStyleBackColor = true;
            this.PrintBarcode.Click += new System.EventHandler(this.PrintBarcode_Click);
            // 
            // BarcodePrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 1286);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Printer);
            this.Controls.Add(this.DisplayBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PartNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpLabelTypes);
            this.Controls.Add(this.PrintBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(788, 897);
            this.Name = "BarcodePrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BarcodePrinting_Load);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grpLabelTypes.ResumeLayout(false);
            this.grpLabelTypes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel tssMessage;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem SetSiteName;
        private System.Windows.Forms.ToolStripMenuItem ExitApplication;
        private System.Windows.Forms.MaskedTextBox Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Printer;
        private System.Windows.Forms.Button DisplayBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PartNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpLabelTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelThreeLineFour;
        private System.Windows.Forms.Label LabelThreeAdditionalInfo;
        private System.Windows.Forms.Label LabelThreeLineThree;
        private System.Windows.Forms.Label LabelThreeLineTwo;
        private System.Windows.Forms.Label LabelThreeLineOne;
        private System.Windows.Forms.Label LabelThreeBarcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelTwoLineOne;
        private System.Windows.Forms.Label LabelTwoLineThree;
        private System.Windows.Forms.Label LabelTwoAdditionalInfo;
        private System.Windows.Forms.Label LabelTwoLineTwo;
        private System.Windows.Forms.Label LabelTwoBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelOneLineTwo;
        private System.Windows.Forms.Label LabelOneLineOne;
        private System.Windows.Forms.Label LabelOneBarcode;
        private System.Windows.Forms.Label LabelOneAdditionalInfo;
        private System.Windows.Forms.RadioButton LabelThreeSelection;
        private System.Windows.Forms.RadioButton LabelTwoSelection;
        private System.Windows.Forms.RadioButton LabelOneSelection;
        private System.Windows.Forms.Button PrintBarcode;
    }
}
