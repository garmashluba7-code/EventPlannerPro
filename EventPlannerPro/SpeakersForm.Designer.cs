namespace EventPlannerPro
{
    partial class SpeakersForm
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
            this.dgvSpeakers = new System.Windows.Forms.DataGridView();
            this.ld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeakerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSpeaker = new System.Windows.Forms.Button();
            this.btnDeleteSpeaker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeakers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpeakers
            // 
            this.dgvSpeakers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSpeakers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeakers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ld,
            this.SpeakerName,
            this.Specialization,
            this.Company,
            this.Email});
            this.dgvSpeakers.Location = new System.Drawing.Point(12, 25);
            this.dgvSpeakers.Name = "dgvSpeakers";
            this.dgvSpeakers.RowHeadersWidth = 51;
            this.dgvSpeakers.RowTemplate.Height = 24;
            this.dgvSpeakers.Size = new System.Drawing.Size(240, 139);
            this.dgvSpeakers.TabIndex = 0;
            // 
            // ld
            // 
            this.ld.HeaderText = "ID";
            this.ld.MinimumWidth = 6;
            this.ld.Name = "ld";
            this.ld.Visible = false;
            this.ld.Width = 125;
            // 
            // SpeakerName
            // 
            this.SpeakerName.HeaderText = "ПІБ спікери";
            this.SpeakerName.MinimumWidth = 6;
            this.SpeakerName.Name = "SpeakerName";
            this.SpeakerName.Visible = false;
            this.SpeakerName.Width = 125;
            // 
            // Specialization
            // 
            this.Specialization.HeaderText = "Спеціалізація";
            this.Specialization.MinimumWidth = 6;
            this.Specialization.Name = "Specialization";
            this.Specialization.Visible = false;
            this.Specialization.Width = 125;
            // 
            // Company
            // 
            this.Company.HeaderText = "Компанія";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            this.Company.Visible = false;
            this.Company.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Електронна пошта";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Visible = false;
            this.Email.Width = 125;
            // 
            // btnAddSpeaker
            // 
            this.btnAddSpeaker.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddSpeaker.ForeColor = System.Drawing.Color.White;
            this.btnAddSpeaker.Location = new System.Drawing.Point(265, 242);
            this.btnAddSpeaker.Name = "btnAddSpeaker";
            this.btnAddSpeaker.Size = new System.Drawing.Size(156, 28);
            this.btnAddSpeaker.TabIndex = 1;
            this.btnAddSpeaker.Text = "Додати спікера";
            this.btnAddSpeaker.UseVisualStyleBackColor = false;
            this.btnAddSpeaker.Click += new System.EventHandler(this.btnAddSpeaker_Click);
            // 
            // btnDeleteSpeaker
            // 
            this.btnDeleteSpeaker.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSpeaker.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSpeaker.Location = new System.Drawing.Point(12, 242);
            this.btnDeleteSpeaker.Name = "btnDeleteSpeaker";
            this.btnDeleteSpeaker.Size = new System.Drawing.Size(156, 28);
            this.btnDeleteSpeaker.TabIndex = 2;
            this.btnDeleteSpeaker.Text = "Видалити спікера";
            this.btnDeleteSpeaker.UseVisualStyleBackColor = false;
            this.btnDeleteSpeaker.Click += new System.EventHandler(this.btnDeleteSpeaker_Click);
            // 
            // SpeakersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnDeleteSpeaker);
            this.Controls.Add(this.btnAddSpeaker);
            this.Controls.Add(this.dgvSpeakers);
            this.Name = "SpeakersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спікери";
            this.Load += new System.EventHandler(this.SpeakersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeakers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpeakers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ld;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpeakerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btnAddSpeaker;
        private System.Windows.Forms.Button btnDeleteSpeaker;
    }
}