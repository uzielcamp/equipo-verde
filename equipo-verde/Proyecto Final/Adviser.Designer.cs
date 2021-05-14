
namespace Proyecto_Final
{
    partial class frmAdviser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.bttSearch = new MetroFramework.Controls.MetroButton();
            this.lblDepartment = new MetroFramework.Controls.MetroLabel();
            this.lblemail = new MetroFramework.Controls.MetroLabel();
            this.lblCellphone = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNumber = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtDeparment = new MetroFramework.Controls.MetroTextBox();
            this.txtemail = new MetroFramework.Controls.MetroTextBox();
            this.txtCellphone = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.bttSave = new MetroFramework.Controls.MetroButton();
            this.bttCancel = new MetroFramework.Controls.MetroButton();
            this.bttDelete = new MetroFramework.Controls.MetroButton();
            this.bttEdit = new MetroFramework.Controls.MetroButton();
            this.bttAdd = new MetroFramework.Controls.MetroButton();
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.adviserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adviserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoGenerateColumns = false;
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.cellphoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.adviserBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDatos.EnableHeadersVisualStyles = false;
            this.grdDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.Location = new System.Drawing.Point(6, 55);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(463, 234);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellClick);
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(3, 3);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(97, 118);
            this.pctPhoto.TabIndex = 4;
            this.pctPhoto.TabStop = false;
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(12, 127);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(75, 23);
            this.bttSearch.TabIndex = 18;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseSelectable = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(118, 183);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(80, 19);
            this.lblDepartment.TabIndex = 25;
            this.lblDepartment.Text = "Department";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(118, 154);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 19);
            this.lblemail.TabIndex = 24;
            this.lblemail.Text = "e-mail";
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(123, 125);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(68, 19);
            this.lblCellphone.TabIndex = 23;
            this.lblCellphone.Text = "Cellphone";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(118, 93);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(99, 19);
            this.lblPhoneNumber.TabIndex = 22;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(118, 64);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 19);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(118, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 19);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "First Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(118, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Id";
            // 
            // txtDeparment
            // 
            // 
            // 
            // 
            this.txtDeparment.CustomButton.Image = null;
            this.txtDeparment.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtDeparment.CustomButton.Name = "";
            this.txtDeparment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeparment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeparment.CustomButton.TabIndex = 1;
            this.txtDeparment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeparment.CustomButton.UseSelectable = true;
            this.txtDeparment.CustomButton.Visible = false;
            this.txtDeparment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adviserBindingSource, "Department", true));
            this.txtDeparment.Lines = new string[0];
            this.txtDeparment.Location = new System.Drawing.Point(223, 183);
            this.txtDeparment.MaxLength = 32767;
            this.txtDeparment.Name = "txtDeparment";
            this.txtDeparment.PasswordChar = '\0';
            this.txtDeparment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeparment.SelectedText = "";
            this.txtDeparment.SelectionLength = 0;
            this.txtDeparment.SelectionStart = 0;
            this.txtDeparment.ShortcutsEnabled = true;
            this.txtDeparment.Size = new System.Drawing.Size(222, 23);
            this.txtDeparment.TabIndex = 32;
            this.txtDeparment.UseSelectable = true;
            this.txtDeparment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeparment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtemail
            // 
            // 
            // 
            // 
            this.txtemail.CustomButton.Image = null;
            this.txtemail.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtemail.CustomButton.Name = "";
            this.txtemail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtemail.CustomButton.TabIndex = 1;
            this.txtemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtemail.CustomButton.UseSelectable = true;
            this.txtemail.CustomButton.Visible = false;
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adviserBindingSource, "Email", true));
            this.txtemail.Lines = new string[0];
            this.txtemail.Location = new System.Drawing.Point(223, 154);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(222, 23);
            this.txtemail.TabIndex = 31;
            this.txtemail.UseSelectable = true;
            this.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCellphone
            // 
            // 
            // 
            // 
            this.txtCellphone.CustomButton.Image = null;
            this.txtCellphone.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtCellphone.CustomButton.Name = "";
            this.txtCellphone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCellphone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCellphone.CustomButton.TabIndex = 1;
            this.txtCellphone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCellphone.CustomButton.UseSelectable = true;
            this.txtCellphone.CustomButton.Visible = false;
            this.txtCellphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adviserBindingSource, "Cellphone", true));
            this.txtCellphone.Lines = new string[0];
            this.txtCellphone.Location = new System.Drawing.Point(223, 122);
            this.txtCellphone.MaxLength = 32767;
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.PasswordChar = '\0';
            this.txtCellphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCellphone.SelectedText = "";
            this.txtCellphone.SelectionLength = 0;
            this.txtCellphone.SelectionStart = 0;
            this.txtCellphone.ShortcutsEnabled = true;
            this.txtCellphone.Size = new System.Drawing.Size(222, 23);
            this.txtCellphone.TabIndex = 30;
            this.txtCellphone.UseSelectable = true;
            this.txtCellphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCellphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhoneNumber
            // 
            // 
            // 
            // 
            this.txtPhoneNumber.CustomButton.Image = null;
            this.txtPhoneNumber.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtPhoneNumber.CustomButton.Name = "";
            this.txtPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumber.CustomButton.TabIndex = 1;
            this.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber.CustomButton.UseSelectable = true;
            this.txtPhoneNumber.CustomButton.Visible = false;
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adviserBindingSource, "PhoneNumber", true));
            this.txtPhoneNumber.Lines = new string[0];
            this.txtPhoneNumber.Location = new System.Drawing.Point(223, 93);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(222, 23);
            this.txtPhoneNumber.TabIndex = 29;
            this.txtPhoneNumber.UseSelectable = true;
            this.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adviserBindingSource, "LastName", true));
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(223, 64);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(222, 23);
            this.txtLastName.TabIndex = 28;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adviserBindingSource, "FirstName", true));
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(223, 35);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(222, 23);
            this.txtFirstName.TabIndex = 27;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adviserBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(223, 6);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(222, 23);
            this.txtId.TabIndex = 26;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(818, 300);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 37;
            this.bttSave.Text = "Save";
            this.bttSave.UseSelectable = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(737, 300);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 36;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseSelectable = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(656, 300);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 35;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseSelectable = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(575, 300);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 34;
            this.bttEdit.Text = "Edit";
            this.bttEdit.UseSelectable = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(494, 300);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 33;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseSelectable = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.pctPhoto);
            this.pnlDatos.Controls.Add(this.bttSearch);
            this.pnlDatos.Controls.Add(this.lblLastName);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.Controls.Add(this.txtDeparment);
            this.pnlDatos.Controls.Add(this.lblFirstName);
            this.pnlDatos.Controls.Add(this.txtemail);
            this.pnlDatos.Controls.Add(this.lblPhoneNumber);
            this.pnlDatos.Controls.Add(this.txtCellphone);
            this.pnlDatos.Controls.Add(this.lblCellphone);
            this.pnlDatos.Controls.Add(this.txtPhoneNumber);
            this.pnlDatos.Controls.Add(this.lblemail);
            this.pnlDatos.Controls.Add(this.txtLastName);
            this.pnlDatos.Controls.Add(this.lblDepartment);
            this.pnlDatos.Controls.Add(this.txtFirstName);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(475, 50);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(465, 244);
            this.pnlDatos.TabIndex = 38;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // adviserBindingSource
            // 
            this.adviserBindingSource.DataSource = typeof(Proyecto_Final.Entidades.Adviser);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // cellphoneDataGridViewTextBoxColumn
            // 
            this.cellphoneDataGridViewTextBoxColumn.DataPropertyName = "Cellphone";
            this.cellphoneDataGridViewTextBoxColumn.HeaderText = "Cellphone";
            this.cellphoneDataGridViewTextBoxColumn.Name = "cellphoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmAdviser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 396);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttEdit);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmAdviser";
            this.Text = "Adviser";
            this.Load += new System.EventHandler(this.frmAdviser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adviserBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grdDatos;
        private System.Windows.Forms.PictureBox pctPhoto;
        private MetroFramework.Controls.MetroButton bttSearch;
        private MetroFramework.Controls.MetroLabel lblDepartment;
        private MetroFramework.Controls.MetroLabel lblemail;
        private MetroFramework.Controls.MetroLabel lblCellphone;
        private MetroFramework.Controls.MetroLabel lblPhoneNumber;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroTextBox txtDeparment;
        private MetroFramework.Controls.MetroTextBox txtemail;
        private MetroFramework.Controls.MetroTextBox txtCellphone;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumber;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroButton bttSave;
        private MetroFramework.Controls.MetroButton bttCancel;
        private MetroFramework.Controls.MetroButton bttDelete;
        private MetroFramework.Controls.MetroButton bttEdit;
        private MetroFramework.Controls.MetroButton bttAdd;
        private System.Windows.Forms.BindingSource adviserBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel pnlDatos;
    }
}