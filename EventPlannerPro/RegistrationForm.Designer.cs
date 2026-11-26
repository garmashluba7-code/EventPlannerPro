namespace EventPlannerPro
{
    partial class RegistrationForm
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
            this.dgvRegistrations = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRegistration = new System.Windows.Forms.Button();
            this.btnDeleteRegistration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistrations
            // 
            this.dgvRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ParticipantName,
            this.EventName,
            this.RegistrationDate,
            this.Status});
            this.dgvRegistrations.Location = new System.Drawing.Point(1, -1);
            this.dgvRegistrations.Name = "dgvRegistrations";
            this.dgvRegistrations.RowHeadersWidth = 51;
            this.dgvRegistrations.RowTemplate.Height = 24;
            this.dgvRegistrations.Size = new System.Drawing.Size(679, 150);
            this.dgvRegistrations.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // ParticipantName
            // 
            this.ParticipantName.HeaderText = "ПІБ учасника";
            this.ParticipantName.MinimumWidth = 6;
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.Width = 125;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Назва заходу";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.Width = 125;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.HeaderText = "Дата реєстрації";
            this.RegistrationDate.MinimumWidth = 6;
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // btnAddRegistration
            // 
            this.btnAddRegistration.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddRegistration.ForeColor = System.Drawing.Color.White;
            this.btnAddRegistration.Location = new System.Drawing.Point(53, 189);
            this.btnAddRegistration.Name = "btnAddRegistration";
            this.btnAddRegistration.Size = new System.Drawing.Size(175, 40);
            this.btnAddRegistration.TabIndex = 1;
            this.btnAddRegistration.Text = "Додати реєстрацію";
            this.btnAddRegistration.UseVisualStyleBackColor = false;
            this.btnAddRegistration.Click += new System.EventHandler(this.btnAddRegistration_Click);
            // 
            // btnDeleteRegistration
            // 
            this.btnDeleteRegistration.BackColor = System.Drawing.Color.Red;
            this.btnDeleteRegistration.Location = new System.Drawing.Point(292, 189);
            this.btnDeleteRegistration.Name = "btnDeleteRegistration";
            this.btnDeleteRegistration.Size = new System.Drawing.Size(175, 40);
            this.btnDeleteRegistration.TabIndex = 2;
            this.btnDeleteRegistration.Text = "Видалити реєстрацію";
            this.btnDeleteRegistration.UseVisualStyleBackColor = false;
            this.btnDeleteRegistration.Click += new System.EventHandler(this.btnDeleteRegistration_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnDeleteRegistration);
            this.Controls.Add(this.btnAddRegistration);
            this.Controls.Add(this.dgvRegistrations);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistrations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnAddRegistration;
        private System.Windows.Forms.Button btnDeleteRegistration;
    }
}