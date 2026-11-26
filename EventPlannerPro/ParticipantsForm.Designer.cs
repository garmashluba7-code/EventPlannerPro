namespace EventPlannerPro
{
    partial class ParticipantsForm
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
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.ld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.btnDeleteParticipant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ld,
            this.ParticipantName,
            this.Email,
            this.Phone,
            this.Company});
            this.dgvParticipants.Location = new System.Drawing.Point(0, 0);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.RowHeadersWidth = 51;
            this.dgvParticipants.RowTemplate.Height = 24;
            this.dgvParticipants.Size = new System.Drawing.Size(676, 150);
            this.dgvParticipants.TabIndex = 0;
            // 
            // ld
            // 
            this.ld.HeaderText = "ID";
            this.ld.MinimumWidth = 6;
            this.ld.Name = "ld";
            this.ld.Width = 125;
            // 
            // ParticipantName
            // 
            this.ParticipantName.HeaderText = "ПІБ учасника";
            this.ParticipantName.MinimumWidth = 6;
            this.ParticipantName.Name = "ParticipantName";
            this.ParticipantName.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Електронна пошта";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Company
            // 
            this.Company.HeaderText = "Компанія";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            this.Company.Width = 125;
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddParticipant.ForeColor = System.Drawing.Color.White;
            this.btnAddParticipant.Location = new System.Drawing.Point(59, 227);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(155, 40);
            this.btnAddParticipant.TabIndex = 1;
            this.btnAddParticipant.Text = "Додати учасника";
            this.btnAddParticipant.UseVisualStyleBackColor = false;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // btnDeleteParticipant
            // 
            this.btnDeleteParticipant.BackColor = System.Drawing.Color.Red;
            this.btnDeleteParticipant.ForeColor = System.Drawing.Color.White;
            this.btnDeleteParticipant.Location = new System.Drawing.Point(292, 227);
            this.btnDeleteParticipant.Name = "btnDeleteParticipant";
            this.btnDeleteParticipant.Size = new System.Drawing.Size(155, 40);
            this.btnDeleteParticipant.TabIndex = 2;
            this.btnDeleteParticipant.Text = "Видалити учасника";
            this.btnDeleteParticipant.UseVisualStyleBackColor = false;
            this.btnDeleteParticipant.Click += new System.EventHandler(this.btnDeleteParticipant_Click);
            // 
            // ParticipantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnDeleteParticipant);
            this.Controls.Add(this.btnAddParticipant);
            this.Controls.Add(this.dgvParticipants);
            this.Name = "ParticipantsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учасники";
            this.Load += new System.EventHandler(this.ParticipantsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn ld;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.Button btnDeleteParticipant;
    }
}