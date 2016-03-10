namespace StatEv
{
    partial class About
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
            this.version = new System.Windows.Forms.Panel();
            this.versionLb = new System.Windows.Forms.Label();
            this.authorLb = new System.Windows.Forms.Label();
            this.version.SuspendLayout();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.Controls.Add(this.authorLb);
            this.version.Controls.Add(this.versionLb);
            this.version.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.version.Location = new System.Drawing.Point(0, 209);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(284, 52);
            this.version.TabIndex = 0;
            // 
            // versionLb
            // 
            this.versionLb.AutoSize = true;
            this.versionLb.ForeColor = System.Drawing.Color.DimGray;
            this.versionLb.Location = new System.Drawing.Point(12, 9);
            this.versionLb.Name = "versionLb";
            this.versionLb.Size = new System.Drawing.Size(48, 13);
            this.versionLb.TabIndex = 1;
            this.versionLb.Text = "Version: ";
            // 
            // authorLb
            // 
            this.authorLb.AutoSize = true;
            this.authorLb.ForeColor = System.Drawing.Color.DimGray;
            this.authorLb.Location = new System.Drawing.Point(12, 30);
            this.authorLb.Name = "authorLb";
            this.authorLb.Size = new System.Drawing.Size(31, 13);
            this.authorLb.TabIndex = 2;
            this.authorLb.Text = "2016";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.version.ResumeLayout(false);
            this.version.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel version;
        private System.Windows.Forms.Label authorLb;
        private System.Windows.Forms.Label versionLb;
    }
}