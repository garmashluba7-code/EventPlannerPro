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
    public partial class ConferencesForm : Form
    {
        public ConferencesForm()
        {
            InitializeComponent();

            dgvConferences.Rows.Add(
                1, "IT Conference 2026", "20.11.2026", "Київ", 150);

            dgvConferences.Rows.Add(
                2, "Digital Future", "25.11.2026", "Львів", 100);

            dgvConferences.Rows.Add(
                3, "Web Development", "05.12.2026", "Дніпро", 80);
        }

        private void dgvConferences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddConference_Click(object sender, EventArgs e)
        {
            using (AddConferenceForm form = new AddConferenceForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int newId = dgvConferences.Rows.Count + 1;

                    dgvConferences.Rows.Add(
                        newId,
                        form.ConferenceName,
                        form.ConferenceDate.ToString("dd.MM.yyyy"),
                        form.ConferenceLocation,
                        form.ParticipantsCount
                    );
                }
            }
        }

        private void btnDeleteConference_Click(object sender, EventArgs e)
        {
            if (dgvConferences.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Ви дійсно хочете видалити цю конференцію?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvConferences.Rows.RemoveAt(
                        dgvConferences.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Спочатку виберіть конференцію!");
            }
        }
    }
}
