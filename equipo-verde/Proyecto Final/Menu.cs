using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void bttAbirAdviser_Click(object sender, EventArgs e)
        {
            frmAdviser frmAdviser = new frmAdviser();
            frmAdviser.Show();
        }

        private void bttAbirCoach_Click(object sender, EventArgs e)
        {
            frmCoach frmCoach = new frmCoach();
            frmCoach.Show();
        }

        private void bttAbirCompany_Click(object sender, EventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
            frmCompany.Show();
        }

        private void bttAbrirContact_Click(object sender, EventArgs e)
        {
            frmContact frmContact = new frmContact();
            frmContact.Show();
        }

        private void bttAbrirCoordinator_Click(object sender, EventArgs e)
        {
            frmCoordinator frmCoordinator = new frmCoordinator();
            frmCoordinator.Show();
        }

        private void bttAbirMajor_Click(object sender, EventArgs e)
        {
            frmMajor frmMajor = new frmMajor();
            frmMajor.Show();
        }

        private void bttAbirStudent_Click(object sender, EventArgs e)
        {
            frmStudent frmStudent = new frmStudent();
            frmStudent.Show();
        }
    }
}
