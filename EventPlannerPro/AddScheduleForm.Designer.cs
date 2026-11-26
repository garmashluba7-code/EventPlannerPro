namespace EventPlannerPro
{
    partial class AddScheduleForm
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
            this.txtSpeakerName = new System.Windows.Forms.TextBox();
            this.txtEventTime = new System.Windows.Forms.TextBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.btnSaveSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва заходу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Спікер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Час";
            // 
            // txtSpeakerName
            // 
            this.txtSpeakerName.Location = new System.Drawing.Point(15, 107);
            this.txtSpeakerName.Name = "txtSpeakerName";
            this.txtSpeakerName.Size = new System.Drawing.Size(100, 22);
            this.txtSpeakerName.TabIndex = 4;
            // 
            // txtEventTime
            // 
            this.txtEventTime.Location = new System.Drawing.Point(15, 236);
            this.txtEventTime.Name = "txtEventTime";
            this.txtEventTime.Size = new System.Drawing.Size(100, 22);
            this.txtEventTime.TabIndex = 5;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(15, 169);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEventDate.TabIndex = 6;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(12, 49);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(100, 22);
            this.txtEventName.TabIndex = 7;
            // 
            // btnSaveSchedule
            // 
            this.btnSaveSchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSaveSchedule.Location = new System.Drawing.Point(158, 275);
            this.btnSaveSchedule.Name = "btnSaveSchedule";
            this.btnSaveSchedule.Size = new System.Drawing.Size(135, 40);
            this.btnSaveSchedule.TabIndex = 8;
            this.btnSaveSchedule.Text = "Зберегти";
            this.btnSaveSchedule.UseVisualStyleBackColor = false;
            this.btnSaveSchedule.Click += new System.EventHandler(this.btnSaveSchedule_Click);
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btnSaveSchedule);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.txtEventTime);
            this.Controls.Add(this.txtSpeakerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання події";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpeakerName;
        private System.Windows.Forms.TextBox txtEventTime;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Button btnSaveSchedule;
    }
}