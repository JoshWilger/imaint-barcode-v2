
namespace imaint_barcode_v2
{
    partial class SetSite
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
            this.SiteName = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SiteName
            // 
            this.SiteName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SiteName.FormattingEnabled = true;
            this.SiteName.Location = new System.Drawing.Point(25, 83);
            this.SiteName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SiteName.Name = "SiteName";
            this.SiteName.Size = new System.Drawing.Size(437, 37);
            this.SiteName.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Save.Location = new System.Drawing.Point(515, 71);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(198, 59);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save && Close";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SetSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 199);
            this.ControlBox = false;
            this.Controls.Add(this.SiteName);
            this.Controls.Add(this.Save);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Your Site Name";
            this.Load += new System.EventHandler(this.SetSite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SiteName;
        private System.Windows.Forms.Button Save;
    }
}
