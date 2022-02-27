namespace Hospital.Ui
{
    partial class MainMenuUserControl
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
            this.buttonEmployeeLogin = new System.Windows.Forms.Button();
            this.buttonQueueManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEmployeeLogin
            // 
            this.buttonEmployeeLogin.Location = new System.Drawing.Point(43, 41);
            this.buttonEmployeeLogin.Name = "buttonEmployeeLogin";
            this.buttonEmployeeLogin.Size = new System.Drawing.Size(124, 29);
            this.buttonEmployeeLogin.TabIndex = 0;
            this.buttonEmployeeLogin.Tag = "Button Employee Login";
            this.buttonEmployeeLogin.Text = "Employee Login";
            this.buttonEmployeeLogin.UseVisualStyleBackColor = true;
            this.buttonEmployeeLogin.Click += new System.EventHandler(this.CommonClick);
            // 
            // buttonQueueManagement
            // 
            this.buttonQueueManagement.Location = new System.Drawing.Point(43, 105);
            this.buttonQueueManagement.Name = "buttonQueueManagement";
            this.buttonQueueManagement.Size = new System.Drawing.Size(124, 29);
            this.buttonQueueManagement.TabIndex = 2;
            this.buttonQueueManagement.Tag = "Button Queue Management";
            this.buttonQueueManagement.Text = "Queue Management";
            this.buttonQueueManagement.UseVisualStyleBackColor = true;
            this.buttonQueueManagement.Click += new System.EventHandler(this.CommonClick);
            // 
            // MainMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonQueueManagement);
            this.Controls.Add(this.buttonEmployeeLogin);
            this.Name = "MainMenuUserControl";
            this.Size = new System.Drawing.Size(204, 202);
            this.Load += new System.EventHandler(this.MainMenuUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmployeeLogin;
        private System.Windows.Forms.Button buttonQueueManagement;
    }
}
