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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnAddRegistration_Click(object sender, EventArgs e)
        {
            using (AddRegistrationForm form = new AddRegistrationForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int newId = dgvRegistrations.Rows.Count + 1;

                    dgvRegistrations.Rows.Add(
                        newId,
                        form.ParticipantName,
                        form.EventName,
                        form.RegistrationDate.ToShortDateString(),
                        form.Status
                    );
                }
            }
        }

        private void btnDeleteRegistration_Click(object sender, EventArgs e)
        {
            if (dgvRegistrations.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Ви дійсно хочете видалити цю реєстрацію?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvRegistrations.Rows.RemoveAt(
                        dgvRegistrations.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Спочатку виберіть реєстрацію!");
            }
        }

    }
    }
    

