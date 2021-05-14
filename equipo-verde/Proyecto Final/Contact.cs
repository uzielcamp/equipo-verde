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
    public partial class frmContact : MetroFramework.Forms.MetroForm
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pctphoto_Click(object sender, EventArgs e)
        {

        }

        private void frmContact_Load(object sender, EventArgs e)
        {
            using(DataContext dataContext = new DataContext())
            {
                contactBindingSource.DataSource = dataContext.Contacts.ToList();
            }
            pnlDatos.Enabled = false;
            Contact contact = contactBindingSource.Current as Contact;
            if (contact != null && contact.Photo != null)
                pctPhoto.Image = Image.FromFile(contact.Photo);
            else
                pctPhoto.Image = null;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctPhoto.Image = null;
            contactBindingSource.Add(new Contact());
            contactBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtFirstName.Focus();
            Contact contact = contactBindingSource.Current as Contact;
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            contactBindingSource.ResetBindings(false);
            frmContact_Load(sender, e);
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                Contact contact = contactBindingSource.Current as Contact;
                if (contact != null)
                {
                    if (dataContext.Entry<Contact>(contact).State == EntityState.Detached)
                        dataContext.Set<Contact>().Attach(contact);
                    if (contact.Id == 0)
                        dataContext.Entry<Contact>(contact).State = EntityState.Added;
                    else
                        dataContext.Entry<Contact>(contact).State = EntityState.Modified;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Los datos del contacto estan guardados");
                    grdDatos.Refresh();
                    pnlDatos.Enabled = false;
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eleiminar al contacto?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Contact contact = contactBindingSource.Current as Contact;
                    if (contact != null)
                    {
                        if (dataContext.Entry<Contact>(contact).State == EntityState.Detached)
                            dataContext.Set<Contact>().Attach(contact);
                        dataContext.Entry<Contact>(contact).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Contacto fue eliminado");
                        contactBindingSource.RemoveCurrent();
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
                    Contact contact = contactBindingSource.Current as Contact;
                    if (contact != null)
                        contact.Photo = ofd.FileName;
                }
            }
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Contact contact = contactBindingSource.Current as Contact;
            if (contact != null && contact.Photo != null)
                pctPhoto.Image = Image.FromFile(contact.Photo);
            else
                pctPhoto.Image = null;
        }
    }
}
