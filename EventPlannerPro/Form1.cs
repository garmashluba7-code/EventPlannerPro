using System;
using System.Windows.Forms;

namespace EventPlannerPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConferences_Click(object sender, EventArgs e)
        {
            ConferencesForm form = new ConferencesForm();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSpeakers_Click(object sender, EventArgs e)
        {
            SpeakersForm form = new SpeakersForm();
            form.ShowDialog();
        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsForm form = new ParticipantsForm();
            form.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm form = new ScheduleForm();
            form.ShowDialog();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }

        private void btnTickets_Click_1(object sender, EventArgs e)
        {
            TicketsForm form = new TicketsForm();
            form.ShowDialog();
        }
    }
}
