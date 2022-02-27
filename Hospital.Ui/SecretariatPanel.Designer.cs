namespace Hospital.Ui
{
    partial class SecretariatPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reasonOfComingSaveButton = new System.Windows.Forms.Button();
            this.reasonOfComingEditButton = new System.Windows.Forms.Button();
            this.severityOfDiseaseLabel = new System.Windows.Forms.Label();
            this.reasonOfComingLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reasonOfComingSaveButton
            // 
            this.reasonOfComingSaveButton.Location = new System.Drawing.Point(257, 51);
            this.reasonOfComingSaveButton.Name = "reasonOfComingSaveButton";
            this.reasonOfComingSaveButton.Size = new System.Drawing.Size(0, 0);
            this.reasonOfComingSaveButton.TabIndex = 23;
            this.reasonOfComingSaveButton.Text = "Save";
            this.reasonOfComingSaveButton.UseVisualStyleBackColor = true;
            // 
            // reasonOfComingEditButton
            // 
            this.reasonOfComingEditButton.Location = new System.Drawing.Point(210, 51);
            this.reasonOfComingEditButton.Name = "reasonOfComingEditButton";
            this.reasonOfComingEditButton.Size = new System.Drawing.Size(0, 0);
            this.reasonOfComingEditButton.TabIndex = 22;
            this.reasonOfComingEditButton.Text = "Edit";
            this.reasonOfComingEditButton.UseVisualStyleBackColor = true;
            // 
            // severityOfDiseaseLabel
            // 
            this.severityOfDiseaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.severityOfDiseaseLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.severityOfDiseaseLabel.Location = new System.Drawing.Point(55, 368);
            this.severityOfDiseaseLabel.Name = "severityOfDiseaseLabel";
            this.severityOfDiseaseLabel.Size = new System.Drawing.Size(208, 24);
            this.severityOfDiseaseLabel.TabIndex = 21;
            // 
            // reasonOfComingLabel
            // 
            this.reasonOfComingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reasonOfComingLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reasonOfComingLabel.Location = new System.Drawing.Point(47, 74);
            this.reasonOfComingLabel.Name = "reasonOfComingLabel";
            this.reasonOfComingLabel.Size = new System.Drawing.Size(681, 243);
            this.reasonOfComingLabel.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Severity of disease:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Reason of coming:";
            // 
            // SecretariatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reasonOfComingSaveButton);
            this.Controls.Add(this.reasonOfComingEditButton);
            this.Controls.Add(this.severityOfDiseaseLabel);
            this.Controls.Add(this.reasonOfComingLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SecretariatPanel";
            this.Size = new System.Drawing.Size(774, 437);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reasonOfComingSaveButton;
        private System.Windows.Forms.Button reasonOfComingEditButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label severityOfDiseaseLabel;
        public System.Windows.Forms.Label reasonOfComingLabel;
    }
}
