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
    public partial class frmCoach : MetroFramework.Forms.MetroForm
    {
        public frmCoach()
        {
            InitializeComponent();
        }

        private void frmCoach_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                coachBindingSource.DataSource = dataContext.Coaches.ToList();
            }
            pnlDatos.Enabled = false;
            Coach coach = coachBindingSource.Current as Coach;
            if (coach != null && coach.Photo != null)
                pctphoto.Image = Image.FromFile(coach.Photo);
            else
                pctphoto.Image = null;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctphoto.Image = null;
            coachBindingSource.Add(new Adviser());
            coachBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtFirstName.Focus();
            Coach coach = coachBindingSource.Current as Coach;
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            coachBindingSource.ResetBindings(false);
            frmCoach_Load(sender, e);
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Coach coach = coachBindingSource.Current as Coach;
                if (coach != null)
                {
                    if (dataContext.Entry<Coach>(coach).State == EntityState.Detached)
                        dataContext.Set<Coach>().Attach(coach);
                    if (coach.Id == 0)
                        dataContext.Entry<Coach>(coach).State = EntityState.Added;
                    else
                        dataContext.Entry<Coach>(coach).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Los datos del coach estan guardados");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eleiminar al coach?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Coach coach = coachBindingSource.Current as Coach;
                    if (coach != null)
                    {
                        if (dataContext.Entry<Coach>(coach).State == EntityState.Detached)
                            dataContext.Set<Coach>().Attach(coach);
                        dataContext.Entry<Coach>(coach).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Coach eliminado");
                        coachBindingSource.RemoveCurrent();
                        pctphoto.Image = null;
                        pnlDatos.Enabled = false;
                    }
                }
            }
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
                    pctphoto.Image = Image.FromFile(ofd.FileName);
                    Coach coach = coachBindingSource.Current as Coach;
                    if (coach != null)
                        coach.Photo = ofd.FileName;
                }
            }
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Coach coach = coachBindingSource.Current as Coach;
            if (coach != null && coach.Photo != null)
                pctphoto.Image = Image.FromFile(coach.Photo);
            else
                pctphoto.Image = null;
        }
    }
    
}
