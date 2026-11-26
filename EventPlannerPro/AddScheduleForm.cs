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
    public partial class AddScheduleForm : Form
    {
        public AddScheduleForm()
        {
            InitializeComponent();
        }
        public string EventName { get { return txtEventName.Text; } }
        public string SpeakerName { get { return txtSpeakerName.Text; } }
        public DateTime EventDate { get { return dtpEventDate.Value; } }
        public string EventTime { get { return txtEventTime.Text; } }
        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventName.Text))
            {
                MessageBox.Show("Введіть назву заходу!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpeakerName.Text))
            {
                MessageBox.Show("Введіть ім'я спікера!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEventTime.Text))
            {
                MessageBox.Show("Введіть час проведення!");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        

        }
    }

