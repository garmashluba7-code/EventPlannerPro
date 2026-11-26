namespace EventPlannerPro
{
    partial class AddRegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParticipantName = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSaveRegistratration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПІБ учасника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва заходу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата реєстрації";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Статус";
            // 
            // txtParticipantName
            // 
            this.txtParticipantName.Location = new System.Drawing.Point(27, 38);
            this.txtParticipantName.Name = "txtParticipantName";
            this.txtParticipantName.Size = new System.Drawing.Size(100, 22);
            this.txtParticipantName.TabIndex = 4;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(27, 96);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(100, 22);
            this.txtEventName.TabIndex = 5;
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.Location = new System.Drawing.Point(27, 156);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(200, 22);
            this.dtpRegistrationDate.TabIndex = 6;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(27, 217);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbStatus.TabIndex = 7;
            // 
            // btnSaveRegistratration
            // 
            this.btnSaveRegistratration.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveRegistratration.ForeColor = System.Drawing.Color.White;
            this.btnSaveRegistratration.Location = new System.Drawing.Point(142, 268);
            this.btnSaveRegistratration.Name = "btnSaveRegistratration";
            this.btnSaveRegistratration.Size = new System.Drawing.Size(135, 40);
            this.btnSaveRegistratration.TabIndex = 8;
            this.btnSaveRegistratration.Text = "Зберегти";
            this.btnSaveRegistratration.UseVisualStyleBackColor = false;
            this.btnSaveRegistratration.Click += new System.EventHandler(this.btnSaveRegistration_Click);
            // 
            // AddRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btnSaveRegistratration);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpRegistrationDate);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.txtParticipantName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання реєстрації";
            this.Load += new System.EventHandler(this.AddRegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParticipantName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSaveRegistratration;
    }
}