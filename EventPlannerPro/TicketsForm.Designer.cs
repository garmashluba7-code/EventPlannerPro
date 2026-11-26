namespace EventPlannerPro
{
    partial class TicketsForm
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
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.ld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticipantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ld,
            this.ParticipantName,
            this.EventName,
            this.TicketType,
            this.Price});
            this.dgvTickets.Location = new System.Drawing.Point(1, 0);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 24;
            this.dgvTickets.Size = new System.Drawing.Size(700, 300);
            this.dgvTickets.TabIndex = 0;
            this.dgvTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTickets_CellContentClick);
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
            // EventName
            // 
            this.EventName.HeaderText = "Назва заходу";
            this.EventName.MinimumWidth = 6;
            this.EventName.Name = "EventName";
            this.EventName.Width = 125;
            // 
            // TicketType
            // 
            this.TicketType.HeaderText = "Тип квитка";
            this.TicketType.MinimumWidth = 6;
            this.TicketType.Name = "TicketType";
            this.TicketType.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Ціна";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddTicket.ForeColor = System.Drawing.Color.White;
            this.btnAddTicket.Location = new System.Drawing.Point(48, 326);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(175, 40);
            this.btnAddTicket.TabIndex = 1;
            this.btnAddTicket.Text = "Додати квиток";
            this.btnAddTicket.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTicket.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTicket.Location = new System.Drawing.Point(497, 326);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(175, 40);
            this.btnDeleteTicket.TabIndex = 2;
            this.btnDeleteTicket.Text = "Видалити квиток";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnDeleteTicket);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.dgvTickets);
            this.Name = "TicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квитки";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ld;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticipantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
    }
}