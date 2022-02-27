namespace Hospital.Ui
{
    partial class MedicationPanel
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
            this.medicationDataGridView = new System.Windows.Forms.DataGridView();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.berBiteTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.removeMedicationButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.addMedicationButton = new System.Windows.Forms.Button();
            this.berDayTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.medicationTitleLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.backMedicationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicationDataGridView
            // 
            this.medicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicationDataGridView.Location = new System.Drawing.Point(10, 83);
            this.medicationDataGridView.Name = "medicationDataGridView";
            this.medicationDataGridView.RowTemplate.Height = 25;
            this.medicationDataGridView.Size = new System.Drawing.Size(747, 288);
            this.medicationDataGridView.TabIndex = 46;
            // 
            // daysTextBox
            // 
            this.daysTextBox.Enabled = false;
            this.daysTextBox.Location = new System.Drawing.Point(482, 40);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(50, 23);
            this.daysTextBox.TabIndex = 45;
            this.daysTextBox.Tag = "daysTextBox";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(482, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 15);
            this.label18.TabIndex = 44;
            this.label18.Text = "Days:";
            // 
            // berBiteTextBox
            // 
            this.berBiteTextBox.Enabled = false;
            this.berBiteTextBox.Location = new System.Drawing.Point(403, 40);
            this.berBiteTextBox.Name = "berBiteTextBox";
            this.berBiteTextBox.Size = new System.Drawing.Size(50, 23);
            this.berBiteTextBox.TabIndex = 43;
            this.berBiteTextBox.Tag = "berBiteTextBox";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(403, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 15);
            this.label17.TabIndex = 42;
            this.label17.Text = "Ber bite:";
            // 
            // removeMedicationButton
            // 
            this.removeMedicationButton.Enabled = false;
            this.removeMedicationButton.Location = new System.Drawing.Point(689, 39);
            this.removeMedicationButton.Name = "removeMedicationButton";
            this.removeMedicationButton.Size = new System.Drawing.Size(75, 23);
            this.removeMedicationButton.TabIndex = 41;
            this.removeMedicationButton.Tag = "removeMedicationButton";
            this.removeMedicationButton.Text = "Remove";
            this.removeMedicationButton.UseVisualStyleBackColor = true;
            this.removeMedicationButton.Click += new System.EventHandler(this.OnClicked);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(608, 377);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 43);
            this.saveButton.TabIndex = 40;
            this.saveButton.Tag = "saveButton";
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.OnClicked);
            // 
            // addMedicationButton
            // 
            this.addMedicationButton.Enabled = false;
            this.addMedicationButton.Location = new System.Drawing.Point(608, 39);
            this.addMedicationButton.Name = "addMedicationButton";
            this.addMedicationButton.Size = new System.Drawing.Size(75, 23);
            this.addMedicationButton.TabIndex = 39;
            this.addMedicationButton.Tag = "addMedicationButton";
            this.addMedicationButton.Text = "Add";
            this.addMedicationButton.UseVisualStyleBackColor = true;
            this.addMedicationButton.Click += new System.EventHandler(this.OnClicked);
            // 
            // berDayTextBox
            // 
            this.berDayTextBox.Enabled = false;
            this.berDayTextBox.Location = new System.Drawing.Point(320, 39);
            this.berDayTextBox.Name = "berDayTextBox";
            this.berDayTextBox.Size = new System.Drawing.Size(49, 23);
            this.berDayTextBox.TabIndex = 38;
            this.berDayTextBox.Tag = "berDayTextBox";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(320, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 15);
            this.label16.TabIndex = 37;
            this.label16.Text = "Ber day:";
            // 
            // medicationTitleLabel
            // 
            this.medicationTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medicationTitleLabel.Location = new System.Drawing.Point(10, 42);
            this.medicationTitleLabel.Name = "medicationTitleLabel";
            this.medicationTitleLabel.Size = new System.Drawing.Size(294, 23);
            this.medicationTitleLabel.TabIndex = 36;
            this.medicationTitleLabel.Tag = "clearable";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "Medication:";
            // 
            // backMedicationButton
            // 
            this.backMedicationButton.Enabled = false;
            this.backMedicationButton.Location = new System.Drawing.Point(556, 38);
            this.backMedicationButton.Name = "backMedicationButton";
            this.backMedicationButton.Size = new System.Drawing.Size(46, 23);
            this.backMedicationButton.TabIndex = 47;
            this.backMedicationButton.Tag = "backMedicationButton";
            this.backMedicationButton.Text = "Back";
            this.backMedicationButton.UseVisualStyleBackColor = true;
            this.backMedicationButton.Click += new System.EventHandler(this.OnClicked);
            // 
            // MedicationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backMedicationButton);
            this.Controls.Add(this.medicationDataGridView);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.berBiteTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.removeMedicationButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addMedicationButton);
            this.Controls.Add(this.berDayTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.medicationTitleLabel);
            this.Controls.Add(this.label14);
            this.Name = "MedicationPanel";
            this.Size = new System.Drawing.Size(774, 437);
            ((System.ComponentModel.ISupportInitialize)(this.medicationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DataGridView medicationDataGridView;
        public System.Windows.Forms.TextBox daysTextBox;
        public System.Windows.Forms.TextBox berBiteTextBox;
        public System.Windows.Forms.Button removeMedicationButton;
        public System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.Button addMedicationButton;
        public System.Windows.Forms.TextBox berDayTextBox;
        public System.Windows.Forms.Label medicationTitleLabel;
        public System.Windows.Forms.Button backMedicationButton;
    }
}
