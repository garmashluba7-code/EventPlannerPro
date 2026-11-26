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
    public partial class SpeakersForm : Form
    {
        public SpeakersForm()
        {
            InitializeComponent();

            dgvSpeakers.Rows.Add(1, "Іван Петренко", "Розробка ПЗ", "Microsoft", "ivan@gmail.com");
            dgvSpeakers.Rows.Add(2, "Олена Коваль", "Дизайн", "Google", "olena@gmail.com");
            dgvSpeakers.Rows.Add(3, "Андрій Мельник", "Кібербезпека", "SoftServe", "andrii@gmail.com");
        }

        private void SpeakersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSpeaker_Click(object sender, EventArgs e)
        {
            using (AddSpeakerForm form = new AddSpeakerForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int newId = dgvSpeakers.Rows.Count + 1;

                    dgvSpeakers.Rows.Add(
                        newId,
                        form.SpeakerName,
                        form.Specialization,
                        form.Company,
                        form.Email
                    );
                }
            }

        }

        private void btnDeleteSpeaker_Click(object sender, EventArgs e)
        {
            if (dgvSpeakers.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Ви дійсно хочете видалити цього спікера?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dgvSpeakers.Rows.RemoveAt(dgvSpeakers.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Спочатку виберіть спікера!");
            }
        }
    }
}

   

    

