namespace Hospital.Ui
{
    partial class HospitalForm
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
            this.statusStripHospitalForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelHospitalForm = new System.Windows.Forms.Panel();
            this.statusStripHospitalForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripHospitalForm
            // 
            this.statusStripHospitalForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessage});
            this.statusStripHospitalForm.Location = new System.Drawing.Point(0, 608);
            this.statusStripHospitalForm.Name = "statusStripHospitalForm";
            this.statusStripHospitalForm.Size = new System.Drawing.Size(970, 22);
            this.statusStripHospitalForm.TabIndex = 0;
            this.statusStripHospitalForm.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelMessage.Text = "toolStripStatusLabel1";
            // 
            // panelHospitalForm
            // 
            this.panelHospitalForm.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelHospitalForm.Location = new System.Drawing.Point(0, 0);
            this.panelHospitalForm.Name = "panelHospitalForm";
            this.panelHospitalForm.Size = new System.Drawing.Size(970, 608);
            this.panelHospitalForm.TabIndex = 1;
            // 
            // HospitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 630);
            this.Controls.Add(this.panelHospitalForm);
            this.Controls.Add(this.statusStripHospitalForm);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(986, 669);
            this.MinimumSize = new System.Drawing.Size(986, 669);
            this.Name = "HospitalForm";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.HospitalForm_Load);
            this.statusStripHospitalForm.ResumeLayout(false);
            this.statusStripHospitalForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHospitalForm;
        public System.Windows.Forms.StatusStrip statusStripHospitalForm;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
    }
}