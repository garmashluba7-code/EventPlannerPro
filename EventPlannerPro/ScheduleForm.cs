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
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            using (AddScheduleForm form = new AddScheduleForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int newId = dgvSchedule.Rows.Count + 1;

                    dgvSchedule.Rows.Add(
                        newId,
                        form.EventName,
                        form.SpeakerName,
                        form.EventDate.ToShortDateString(),
                        form.EventTime
                    );
                }
            }
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Ви дійсно хочете видалити цю подію?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvSchedule.Rows.RemoveAt(dgvSchedule.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Спочатку виберіть подію!");
            }
        }

    }
    }
    

