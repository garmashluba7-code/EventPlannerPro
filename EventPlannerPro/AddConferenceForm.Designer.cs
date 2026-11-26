namespace EventPlannerPro
{
    partial class AddConferenceForm
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
            this.lblConferenceName = new System.Windows.Forms.Label();
            this.txtConferenceName = new System.Windows.Forms.TextBox();
            this.lblConferenceDate = new System.Windows.Forms.Label();
            this.dtpConferenceDate = new System.Windows.Forms.DateTimePicker();
            this.lblConferenceLocation = new System.Windows.Forms.Label();
            this.cmbConferenceLocation = new System.Windows.Forms.ComboBox();
            this.lblParticipantsCount = new System.Windows.Forms.Label();
            this.numParticipantsCount = new System.Windows.Forms.NumericUpDown();
            this.btnSaveConference = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConferenceName
            // 
            this.lblConferenceName.AutoSize = true;
            this.lblConferenceName.Location = new System.Drawing.Point(12, 43);
            this.lblConferenceName.Name = "lblConferenceName";
            this.lblConferenceName.Size = new System.Drawing.Size(138, 16);
            this.lblConferenceName.TabIndex = 0;
            this.lblConferenceName.Text = "Назва конференції :";
            this.lblConferenceName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtConferenceName
            // 
            this.txtConferenceName.Location = new System.Drawing.Point(299, 37);
            this.txtConferenceName.Name = "txtConferenceName";
            this.txtConferenceName.Size = new System.Drawing.Size(100, 22);
            this.txtConferenceName.TabIndex = 1;
            // 
            // lblConferenceDate
            // 
            this.lblConferenceDate.AutoSize = true;
            this.lblConferenceDate.Location = new System.Drawing.Point(12, 92);
            this.lblConferenceDate.Name = "lblConferenceDate";
            this.lblConferenceDate.Size = new System.Drawing.Size(127, 16);
            this.lblConferenceDate.TabIndex = 2;
            this.lblConferenceDate.Text = "Дата проведення :";
            // 
            // dtpConferenceDate
            // 
            this.dtpConferenceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpConferenceDate.Location = new System.Drawing.Point(199, 87);
            this.dtpConferenceDate.Name = "dtpConferenceDate";
            this.dtpConferenceDate.Size = new System.Drawing.Size(200, 22);
            this.dtpConferenceDate.TabIndex = 3;
            // 
            // lblConferenceLocation
            // 
            this.lblConferenceLocation.AutoSize = true;
            this.lblConferenceLocation.Location = new System.Drawing.Point(12, 142);
            this.lblConferenceLocation.Name = "lblConferenceLocation";
            this.lblConferenceLocation.Size = new System.Drawing.Size(132, 16);
            this.lblConferenceLocation.TabIndex = 4;
            this.lblConferenceLocation.Text = "Місце проведення :";
            // 
            // cmbConferenceLocation
            // 
            this.cmbConferenceLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConferenceLocation.FormattingEnabled = true;
            this.cmbConferenceLocation.Items.AddRange(new object[] {
            "Київ",
            "Львів",
            "Дніпро"});
            this.cmbConferenceLocation.Location = new System.Drawing.Point(278, 134);
            this.cmbConferenceLocation.Name = "cmbConferenceLocation";
            this.cmbConferenceLocation.Size = new System.Drawing.Size(121, 24);
            this.cmbConferenceLocation.TabIndex = 5;
            // 
            // lblParticipantsCount
            // 
            this.lblParticipantsCount.AutoSize = true;
            this.lblParticipantsCount.Location = new System.Drawing.Point(12, 189);
            this.lblParticipantsCount.Name = "lblParticipantsCount";
            this.lblParticipantsCount.Size = new System.Drawing.Size(138, 16);
            this.lblParticipantsCount.TabIndex = 6;
            this.lblParticipantsCount.Text = "Кількість учасників :";
            // 
            // numParticipantsCount
            // 
            this.numParticipantsCount.Location = new System.Drawing.Point(279, 183);
            this.numParticipantsCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numParticipantsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numParticipantsCount.Name = "numParticipantsCount";
            this.numParticipantsCount.Size = new System.Drawing.Size(120, 22);
            this.numParticipantsCount.TabIndex = 7;
            this.numParticipantsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSaveConference
            // 
            this.btnSaveConference.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveConference.ForeColor = System.Drawing.Color.White;
            this.btnSaveConference.Location = new System.Drawing.Point(146, 250);
            this.btnSaveConference.Name = "btnSaveConference";
            this.btnSaveConference.Size = new System.Drawing.Size(135, 40);
            this.btnSaveConference.TabIndex = 8;
            this.btnSaveConference.Text = "Зберегти";
            this.btnSaveConference.UseVisualStyleBackColor = false;
            this.btnSaveConference.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddConferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btnSaveConference);
            this.Controls.Add(this.numParticipantsCount);
            this.Controls.Add(this.lblParticipantsCount);
            this.Controls.Add(this.cmbConferenceLocation);
            this.Controls.Add(this.lblConferenceLocation);
            this.Controls.Add(this.dtpConferenceDate);
            this.Controls.Add(this.lblConferenceDate);
            this.Controls.Add(this.txtConferenceName);
            this.Controls.Add(this.lblConferenceName);
            this.Name = "AddConferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати конференцію";
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConferenceName;
        private System.Windows.Forms.TextBox txtConferenceName;
        private System.Windows.Forms.Label lblConferenceDate;
        private System.Windows.Forms.DateTimePicker dtpConferenceDate;
        private System.Windows.Forms.Label lblConferenceLocation;
        private System.Windows.Forms.ComboBox cmbConferenceLocation;
        private System.Windows.Forms.Label lblParticipantsCount;
        private System.Windows.Forms.NumericUpDown numParticipantsCount;
        private System.Windows.Forms.Button btnSaveConference;
    }
}