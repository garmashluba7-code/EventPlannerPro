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
    public partial class AddConferenceForm : Form
    {
        public AddConferenceForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConferenceName.Text))
            {
                MessageBox.Show("Введіть назву конференції!");
                return;
            }

            if (cmbConferenceLocation.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть місто проведення!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public string ConferenceName
        {
            get { return txtConferenceName.Text; }
        }

        public DateTime ConferenceDate
        {
            get { return dtpConferenceDate.Value; }
        }

        public string ConferenceLocation
        {
            get { return cmbConferenceLocation.Text; }
        }

        public int ParticipantsCount
        {
            get { return (int)numParticipantsCount.Value; }
        }
    }
}  