namespace EventPlannerPro
{
    partial class AddTicketForm
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
            this.txtEventName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParticipantName = new System.Windows.Forms.TextBox();
            this.txtEventNameTicket = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbTicketType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПІБ учасника";
            // 
            // txtEventName
            // 
            this.txtEventName.AutoSize = true;
            this.txtEventName.Location = new System.Drawing.Point(12, 68);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(98, 16);
            this.txtEventName.TabIndex = 1;
            this.txtEventName.Text = "Назва заходу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип квитка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ціна";
            // 
            // txtParticipantName
            // 
            this.txtParticipantName.Location = new System.Drawing.Point(12, 28);
            this.txtParticipantName.Name = "txtParticipantName";
            this.txtParticipantName.Size = new System.Drawing.Size(100, 22);
            this.txtParticipantName.TabIndex = 4;
            // 
            // txtEventNameTicket
            // 
            this.txtEventNameTicket.Location = new System.Drawing.Point(12, 87);
            this.txtEventNameTicket.Name = "txtEventNameTicket";
            this.txtEventNameTicket.Size = new System.Drawing.Size(100, 22);
            this.txtEventNameTicket.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(10, 205);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // cmbTicketType
            // 
            this.cmbTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketType.FormattingEnabled = true;
            this.cmbTicketType.Location = new System.Drawing.Point(12, 144);
            this.cmbTicketType.Name = "cmbTicketType";
            this.cmbTicketType.Size = new System.Drawing.Size(121, 24);
            this.cmbTicketType.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(126, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зберегти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSaveTicket_Click);
            // 
            // btnSaveTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTicketType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtEventNameTicket);
            this.Controls.Add(this.txtParticipantName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.label1);
            this.Name = "AddSaveTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання квитка";
            this.Load += new System.EventHandler(this.AddTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParticipantName;
        private System.Windows.Forms.TextBox txtEventNameTicket;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbTicketType;
        private System.Windows.Forms.Button button1;
    }
}

