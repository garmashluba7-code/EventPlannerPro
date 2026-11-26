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
    public partial class ParticipantsForm : Form
    {
        public ParticipantsForm()
        {
            InitializeComponent();
        }

        private void ParticipantsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            using (AddParticipantForm form = new AddParticipantForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int newId = dgvParticipants.Rows.Count + 1;

                    dgvParticipants.Rows.Add(
                        newId,
                        form.ParticipantName,
                        form.Email,
                        form.Phone,
                        form.Company
                    );
                }
            }
        }

        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {
            if (dgvParticipants.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Ви дійсно хочете видалити цього учасника?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvParticipants.Rows.RemoveAt(dgvParticipants.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Спочатку виберіть учасника!");
            }
        }
        

        }
    }

    
        