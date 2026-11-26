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
    public partial class AddParticipantForm : Form
    {
        public AddParticipantForm()
        {
            InitializeComponent();
        }
        public string ParticipantName { get { return txtParticipantName.Text; } }
        public string Email { get { return txtEmail.Text; } }
        public string Phone { get { return txtPhone.Text; } }
        public string Company { get { return txtCompany.Text; } }
        private void btnSaveParticipant_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParticipantName.Text))
            {
                MessageBox.Show("Введіть ПІБ учасника!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Введіть електронну пошту!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Введіть номер телефону!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCompany.Text))
            {
                MessageBox.Show("Введіть назву компанії!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        }
    }

