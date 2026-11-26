namespace EventPlannerPro
{
    partial class AddSpeakerForm
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
            this.lblSpeakerName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSpeakerName = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSaveSpeaker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpeakerName
            // 
            this.lblSpeakerName.AutoSize = true;
            this.lblSpeakerName.Location = new System.Drawing.Point(26, 33);
            this.lblSpeakerName.Name = "lblSpeakerName";
            this.lblSpeakerName.Size = new System.Drawing.Size(81, 16);
            this.lblSpeakerName.TabIndex = 0;
            this.lblSpeakerName.Text = "ПІБ спікера";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(26, 96);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(96, 16);
            this.lblSpecialization.TabIndex = 1;
            this.lblSpecialization.Text = "Спеціалізація";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(26, 161);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(66, 16);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Компанія";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Електронна пошта";
            // 
            // txtSpeakerName
            // 
            this.txtSpeakerName.Location = new System.Drawing.Point(29, 61);
            this.txtSpeakerName.Name = "txtSpeakerName";
            this.txtSpeakerName.Size = new System.Drawing.Size(100, 22);
            this.txtSpeakerName.TabIndex = 4;
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(29, 125);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(100, 22);
            this.txtSpecialization.TabIndex = 5;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(29, 194);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(100, 22);
            this.txtCompany.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(29, 264);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // btnSaveSpeaker
            // 
            this.btnSaveSpeaker.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveSpeaker.ForeColor = System.Drawing.Color.White;
            this.btnSaveSpeaker.Location = new System.Drawing.Point(327, 376);
            this.btnSaveSpeaker.Name = "btnSaveSpeaker";
            this.btnSaveSpeaker.Size = new System.Drawing.Size(120, 30);
            this.btnSaveSpeaker.TabIndex = 8;
            this.btnSaveSpeaker.Text = "Зберегти";
            this.btnSaveSpeaker.UseVisualStyleBackColor = false;
            this.btnSaveSpeaker.Click += new System.EventHandler(this.btnSaveSpeaker_Click);
            // 
            // AddSpeakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveSpeaker);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.txtSpeakerName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblSpeakerName);
            this.Name = "AddSpeakerForm";
            this.Text = "AddSpeakerForm";
            this.Load += new System.EventHandler(this.AddSpeakerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeakerName;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSpeakerName;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSaveSpeaker;
    }
}