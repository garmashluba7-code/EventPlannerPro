namespace EventPlannerPro
{
    partial class ConferencesForm
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
            this.dgvConferences = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConferenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConferenceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConferenceLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddConference = new System.Windows.Forms.Button();
            this.btnDeleteConference = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConferences
            // 
            this.dgvConferences.AllowUserToAddRows = false;
            this.dgvConferences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConferences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConferences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ConferenceName,
            this.ConferenceDate,
            this.ConferenceLocation,
            this.ParticipantsCount});
            this.dgvConferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConferences.Location = new System.Drawing.Point(0, 0);
            this.dgvConferences.Name = "dgvConferences";
            this.dgvConferences.ReadOnly = true;
            this.dgvConferences.RowHeadersWidth = 51;
            this.dgvConferences.RowTemplate.Height = 24;
            this.dgvConferences.Size = new System.Drawing.Size(882, 553);
            this.dgvConferences.TabIndex = 0;
            this.dgvConferences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConferences_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ConferenceName
            // 
            this.ConferenceName.HeaderText = "Назва конференції";
            this.ConferenceName.MinimumWidth = 6;
            this.ConferenceName.Name = "ConferenceName";
            this.ConferenceName.ReadOnly = true;
            // 
            // ConferenceDate
            // 
            this.ConferenceDate.HeaderText = "Дата проведення";
            this.ConferenceDate.MinimumWidth = 6;
            this.ConferenceDate.Name = "ConferenceDate";
            this.ConferenceDate.ReadOnly = true;
            // 
            // ConferenceLocation
            // 
            this.ConferenceLocation.HeaderText = "Місце проведення";
            this.ConferenceLocation.MinimumWidth = 6;
            this.ConferenceLocation.Name = "ConferenceLocation";
            this.ConferenceLocation.ReadOnly = true;
            // 
            // ParticipantsCount
            // 
            this.ParticipantsCount.HeaderText = "Кількість учасників";
            this.ParticipantsCount.MinimumWidth = 6;
            this.ParticipantsCount.Name = "ParticipantsCount";
            this.ParticipantsCount.ReadOnly = true;
            // 
            // btnAddConference
            // 
            this.btnAddConference.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddConference.ForeColor = System.Drawing.Color.White;
            this.btnAddConference.Location = new System.Drawing.Point(0, 206);
            this.btnAddConference.Name = "btnAddConference";
            this.btnAddConference.Size = new System.Drawing.Size(175, 40);
            this.btnAddConference.TabIndex = 1;
            this.btnAddConference.Text = "Додати конференції";
            this.btnAddConference.UseVisualStyleBackColor = false;
            this.btnAddConference.Click += new System.EventHandler(this.btnAddConference_Click);
            // 
            // btnDeleteConference
            // 
            this.btnDeleteConference.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteConference.ForeColor = System.Drawing.Color.White;
            this.btnDeleteConference.Location = new System.Drawing.Point(217, 206);
            this.btnDeleteConference.Name = "btnDeleteConference";
            this.btnDeleteConference.Size = new System.Drawing.Size(175, 40);
            this.btnDeleteConference.TabIndex = 2;
            this.btnDeleteConference.Text = "Видалити конференцію";
            this.btnDeleteConference.UseVisualStyleBackColor = false;
            this.btnDeleteConference.Click += new System.EventHandler(this.btnDeleteConference_Click);
            // 
            // ConferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btnDeleteConference);
            this.Controls.Add(this.btnAddConference);
            this.Controls.Add(this.dgvConferences);
            this.Name = "ConferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конференції";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConferences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConferences;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConferenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConferenceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConferenceLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantsCount;
        private System.Windows.Forms.Button btnAddConference;
        private System.Windows.Forms.Button btnDeleteConference;
    }
}