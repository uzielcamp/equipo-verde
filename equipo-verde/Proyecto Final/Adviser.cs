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
    public partial class frmAdviser : MetroFramework.Forms.MetroForm
    {
        public frmAdviser()
        {
            InitializeComponent();
        }

        private void frmAdviser_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                adviserBindingSource.DataSource = dataContext.Advisers.ToList();
            }
            pnlDatos.Enabled = false;
            Adviser adviser  = adviserBindingSource.Current as Adviser;
            if (adviser != null && adviser.Photo != null)
                pctPhoto.Image = Image.FromFile(adviser.Photo);
            else
                pctPhoto.Image = null;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctPhoto.Image = null;
            adviserBindingSource.Add(new Adviser());
            adviserBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtFirstName.Focus();
            Adviser adviser = adviserBindingSource.Current as Adviser;
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            adviserBindingSource.ResetBindings(false);
            frmAdviser_Load(sender, e);
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Adviser adviser = adviserBindingSource.Current as Adviser;
                if (adviser != null)
                {
                    if (dataContext.Entry<Adviser>(adviser).State == EntityState.Detached)
                        dataContext.Set<Adviser>().Attach(adviser);
                    if (adviser.Id == 0)
                        dataContext.Entry<Adviser>(adviser).State = EntityState.Added;
                    else
                        dataContext.Entry<Adviser>(adviser).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Los datos del asesor estan guardados");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eleiminar al asesor?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Adviser adviser = adviserBindingSource.Current as Adviser;
                    if (adviser != null)
                    {
                        if (dataContext.Entry<Adviser>(adviser).State == EntityState.Detached)
                            dataContext.Set<Adviser>().Attach(adviser);
                        dataContext.Entry<Adviser>(adviser).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Asesor eliminado");
                        adviserBindingSource.RemoveCurrent();
                        pctPhoto.Image = null;
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
                    pctPhoto.Image = Image.FromFile(ofd.FileName);
                    Adviser adviser = adviserBindingSource.Current as Adviser;
                    if (adviser != null)
                        adviser.Photo = ofd.FileName;
                }
            }
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Adviser adviser = adviserBindingSource.Current as Adviser;
            if (adviser != null && adviser.Photo != null)
                pctPhoto.Image = Image.FromFile(adviser.Photo);
            else
                pctPhoto.Image = null;
        }
    }
}
