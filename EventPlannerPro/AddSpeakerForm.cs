using System;
using System.Windows.Forms;

namespace EventPlannerPro
{
    public partial class AddSpeakerForm : Form
    {
        public AddSpeakerForm()
        {
            InitializeComponent();
        }

        public string SpeakerName { get { return txtSpeakerName.Text; } }
        public string Specialization { get { return txtSpecialization.Text; } }
        public string Company { get { return txtCompany.Text; } }
        public string Email { get { return txtEmail.Text; } }

        private void AddSpeakerForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSaveSpeaker_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpeakerName.Text))
            {
                MessageBox.Show("Введіть ПІБ спікера!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialization.Text))
            {
                MessageBox.Show("Введіть спеціалізацію!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCompany.Text))
            {
                MessageBox.Show("Введіть компанію!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Введіть електронну пошту!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}