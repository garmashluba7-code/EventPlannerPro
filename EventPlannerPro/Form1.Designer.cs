namespace EventPlannerPro
{
    partial class Form1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnConferences = new System.Windows.Forms.Button();
            this.btnSpeakers = new System.Windows.Forms.Button();
            this.btnParticipants = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.Location = new System.Drawing.Point(151, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(825, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Ласкаво просимо до Event Planner Pro!";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(175, 101);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(629, 95);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Платформа для організації конференцій та заходів. Керуйте конференціями, спікерам" +
    "и, учасниками, розкладом і квитками в одному місці.";
            // 
            // btnConferences
            // 
            this.btnConferences.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConferences.ForeColor = System.Drawing.Color.White;
            this.btnConferences.Location = new System.Drawing.Point(158, 233);
            this.btnConferences.Name = "btnConferences";
            this.btnConferences.Size = new System.Drawing.Size(200, 50);
            this.btnConferences.TabIndex = 2;
            this.btnConferences.Text = "Конференції";
            this.btnConferences.UseVisualStyleBackColor = false;
            this.btnConferences.Click += new System.EventHandler(this.btnConferences_Click);
            // 
            // btnSpeakers
            // 
            this.btnSpeakers.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSpeakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpeakers.ForeColor = System.Drawing.Color.White;
            this.btnSpeakers.Location = new System.Drawing.Point(638, 233);
            this.btnSpeakers.Name = "btnSpeakers";
            this.btnSpeakers.Size = new System.Drawing.Size(200, 50);
            this.btnSpeakers.TabIndex = 3;
            this.btnSpeakers.Text = "Спікери";
            this.btnSpeakers.UseVisualStyleBackColor = false;
            this.btnSpeakers.Click += new System.EventHandler(this.btnSpeakers_Click);
            // 
            // btnParticipants
            // 
            this.btnParticipants.BackColor = System.Drawing.Color.SteelBlue;
            this.btnParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnParticipants.ForeColor = System.Drawing.Color.White;
            this.btnParticipants.Location = new System.Drawing.Point(158, 289);
            this.btnParticipants.Name = "btnParticipants";
            this.btnParticipants.Size = new System.Drawing.Size(200, 50);
            this.btnParticipants.TabIndex = 4;
            this.btnParticipants.Text = "Учасники";
            this.btnParticipants.UseVisualStyleBackColor = false;
            this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(638, 289);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(200, 50);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Розклад";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.Location = new System.Drawing.Point(158, 345);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(200, 50);
            this.btnRegistration.TabIndex = 6;
            this.btnRegistration.Text = "Реєстрація";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTickets.ForeColor = System.Drawing.Color.White;
            this.btnTickets.Location = new System.Drawing.Point(638, 345);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(200, 50);
            this.btnTickets.TabIndex = 7;
            this.btnTickets.Text = "Квитки";
            this.btnTickets.UseVisualStyleBackColor = false;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnTickets);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnParticipants);
            this.Controls.Add(this.btnSpeakers);
            this.Controls.Add(this.btnConferences);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Planner Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnConferences;
        private System.Windows.Forms.Button btnSpeakers;
        private System.Windows.Forms.Button btnParticipants;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnTickets;
    }
}

