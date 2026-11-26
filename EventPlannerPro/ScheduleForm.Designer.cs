namespace EventPlannerPro
{
    partial class ScheduleForm
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
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.ld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeakerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ld,
            this.EventName,
            this.SpeakerName,
            this.EventDate,
            this.EventTime});
            this.dgvSchedule.Location = new System.Drawing.Point(0, 0);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 24;
            this.dgvSchedule.Size = new System.Drawing.Size(678, 115);
            this.dgvSchedule.TabIndex = 0;
            // 
            // ld
            // 
            this.ld.HeaderText = "ID";
            this.ld.MinimumWidth = 6;
            this.ld.Name = "ld";
            this.ld.Width = 125;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Назва заходу";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.Width = 125;
            // 
            // SpeakerName
            // 
            this.SpeakerName.HeaderText = "Спікер";
            this.SpeakerName.MinimumWidth = 6;
            this.SpeakerName.Name = "SpeakerName";
            this.SpeakerName.Width = 125;
            // 
            // EventDate
            // 
            this.EventDate.HeaderText = "Дата";
            this.EventDate.MinimumWidth = 6;
            this.EventDate.Name = "EventDate";
            this.EventDate.Width = 125;
            // 
            // EventTime
            // 
            this.EventTime.HeaderText = "Час";
            this.EventTime.MinimumWidth = 6;
            this.EventTime.Name = "EventTime";
            this.EventTime.Width = 125;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
            this.btnAddSchedule.Location = new System.Drawing.Point(27, 194);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(175, 40);
            this.btnAddSchedule.TabIndex = 1;
            this.btnAddSchedule.Text = "Додати подію";
            this.btnAddSchedule.UseVisualStyleBackColor = false;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSchedule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSchedule.Location = new System.Drawing.Point(475, 194);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(175, 40);
            this.btnDeleteSchedule.TabIndex = 2;
            this.btnDeleteSchedule.Text = "Видалити подію";
            this.btnDeleteSchedule.UseVisualStyleBackColor = false;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnDeleteSchedule);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.dgvSchedule);
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Розклад";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn ld;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpeakerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnDeleteSchedule;
    }
}