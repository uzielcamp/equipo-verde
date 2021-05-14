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
    public partial class frmCompany : MetroFramework.Forms.MetroForm
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                companyBindingSource.DataSource = dataContext.Comapanies.ToList();
            }
            pnlDatos.Enabled = false;
             Company company= companyBindingSource.Current as Company;
            if (company != null && company.Photo != null)
                pctphoto.Image = Image.FromFile(company.Photo);
            else
                pctphoto.Image = null;
        }

        private void pctphoto_Click(object sender, EventArgs e)
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
                    pctphoto.Image = Image.FromFile(ofd.FileName);
                    Company company = companyBindingSource.Current as Company;
                    if (company != null)
                        company.Photo = ofd.FileName;
                }
            }
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_Click(object sender, EventArgs e)
        {

        }

        private void lblpostalCode_Click(object sender, EventArgs e)
        {

        }

        private void txtpostalCode_Click(object sender, EventArgs e)
        {

        }

        private void lblphoneNumberc_Click(object sender, EventArgs e)
        {

        }

        private void txtphoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblwebsite_Click(object sender, EventArgs e)
        {

        }

        private void txtwebsite_Click(object sender, EventArgs e)
        {

        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctphoto.Image = null;
            companyBindingSource.Add(new Adviser());
            companyBindingSource.MoveLast();
            txtName.Focus();
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtName.Focus();
            Company company = companyBindingSource.Current as Company;
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            companyBindingSource.ResetBindings(false);
            frmCompany_Load(sender, e);
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Company company = companyBindingSource.Current as Company;
                if (company != null)
                {
                    if (dataContext.Entry<Company>(company).State == EntityState.Detached)
                        dataContext.Set<Company>().Attach(company);
                    if (company.Id == 0)
                        dataContext.Entry<Company>(company).State = EntityState.Added;
                    else
                        dataContext.Entry<Company>(company).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Los datos de la compañia estan guardados");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eleiminar a la compañia?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Company company = companyBindingSource.Current as Company;
                    if (company != null)
                    {
                        if (dataContext.Entry<Company>(company).State == EntityState.Detached)
                            dataContext.Set<Company>().Attach(company);
                        dataContext.Entry<Company>(company).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Compañia eliminada");
                        companyBindingSource.RemoveCurrent();
                        pctphoto.Image = null;
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                Company company = companyBindingSource.Current as Company;
                if (company != null && company.Photo != null)
                    pctphoto.Image = Image.FromFile(company.Photo);
                else
                    pctphoto.Image = null;
            
        }
    }
}
