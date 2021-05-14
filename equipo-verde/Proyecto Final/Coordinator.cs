using Proyecto_Final.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmCoordinator : MetroFramework.Forms.MetroForm
    {
        public frmCoordinator()
        {
            InitializeComponent();
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCoordinator_Load(object sender, EventArgs e)
        {
            {
                using (DataContext dataContext = new DataContext())
                {
                    coordinatorBindingSource.DataSource = dataContext.Coordinators.ToList();
                }
                pnlDatos.Enabled = false;
                Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                if (coordinator != null && coordinator.Photo != null)
                    pctPhoto.Image = Image.FromFile(coordinator.Photo);
                else
                    pctPhoto.Image = null;
            }
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblCellphone_Click(object sender, EventArgs e)
        {

        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "archivos JPG|*.jpg|todos los archivos|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctPhoto.Image = Image.FromFile(ofd.FileName);
                    Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                    if (coordinator != null)
                        coordinator.Photo = ofd.FileName;
                }
            }
        }

        private void pctPhoto_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_Click(object sender, EventArgs e)
        {

        }

        private void txtCellphone_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctPhoto.Image = null;
            coordinatorBindingSource.Add(new Coordinator());
            coordinatorBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtFirstName.Focus();
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eleiminar al coordinador?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                    if (coordinator != null)
                    {
                        if (dataContext.Entry<Coordinator>(coordinator).State == EntityState.Detached)
                            dataContext.Set<Coordinator>().Attach(coordinator);
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Coordinador eliminado");
                        coordinatorBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            coordinatorBindingSource.ResetBindings(false);
            frmCoordinator_Load(sender, e);
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
                if (coordinator != null)
                {
                    if (dataContext.Entry<Coordinator>(coordinator).State == EntityState.Detached)
                        dataContext.Set<Coordinator>().Attach(coordinator);
                    if (coordinator.Id == 0)
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Added;
                    else
                        dataContext.Entry<Coordinator>(coordinator).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Los datos del coordinador estan guardados");
                    grddatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void grddatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && coordinator.Photo != null)
                pctPhoto.Image = Image.FromFile(coordinator.Photo);
            else
                pctPhoto.Image = null;
        }
    }
}
