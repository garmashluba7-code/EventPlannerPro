using System;
using System.Windows.Forms;

namespace EventPlannerPro
{
    public partial class AddTicketForm : Form
    {
        public AddTicketForm()
        {
            InitializeComponent();

            cmbTicketType.Items.Clear();
            cmbTicketType.Items.Add("Стандарт");
            cmbTicketType.Items.Add("VIP");
            cmbTicketType.Items.Add("Студентський");

            cmbTicketType.SelectedIndex = 0;
        }

        public string ParticipantName
        {
            get { return txtParticipantName.Text; }
        }

        public string EventName
        {
            get { return txtEventNameTicket.Text; }
        }

        public string TicketType
        {
            get { return cmbTicketType.Text; }
        }

        public decimal Price
        {
            get
            {
                decimal price;
                decimal.TryParse(txtPrice.Text, out price);
                return price;
            }
        }

        private void btnSaveTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParticipantName.Text))
            {
                MessageBox.Show("Введіть ПІБ учасника!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEventNameTicket.Text))
            {
                MessageBox.Show("Введіть назву заходу!");
                return;
            }

            decimal price;

            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Введіть правильну ціну квитка!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    private void AddTicketForm_Load(object sender, EventArgs e)
        {
        }
    }
    }
