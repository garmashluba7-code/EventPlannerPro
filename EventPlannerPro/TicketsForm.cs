using System;
using System.Windows.Forms;

namespace EventPlannerPro
{
    public partial class TicketsForm : Form
    {
        private int nextId = 1;

        public TicketsForm()
        {
            InitializeComponent();

            btnAddTicket.Click += btnAddTicket_Click;
            btnDeleteTicket.Click += btnDeleteTicket_Click;

            dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTickets.MultiSelect = false;
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.ReadOnly = true;
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            AddTicketForm form = new AddTicketForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvTickets.Rows.Add(
                    nextId,
                    form.ParticipantName,
                    form.EventName,
                    form.TicketType,
                    form.Price
                );

                nextId++;
            }
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (dgvTickets.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть квиток для видалення!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Ви дійсно хочете видалити цей квиток?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                dgvTickets.Rows.Remove(
                    dgvTickets.SelectedRows[0]
                );
            }
        }

        private void dgvTickets_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}