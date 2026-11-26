using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPlannerPro
{
    public partial class AddRegistrationForm : Form
    {
        public AddRegistrationForm()
        {
            InitializeComponent();

            cmbStatus.Items.Add("Підтверджено");
            cmbStatus.Items.Add("Очікує підтвердження");
            cmbStatus.Items.Add("Скасовано");

            cmbStatus.SelectedIndex = 0;
        }

        public string ParticipantName { get { return txtParticipantName.Text; } }
        public string EventName { get { return txtEventName.Text; } }
        public DateTime RegistrationDate { get { return dtpRegistrationDate.Value; } }
        public string Status { get { return cmbStatus.Text; } }

        private void AddRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParticipantName.Text))
            {
                MessageBox.Show("Введіть ПІБ учасника!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEventName.Text))
            {
                MessageBox.Show("Введіть назву заходу!");
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть статус реєстрації!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        

        }
    }
