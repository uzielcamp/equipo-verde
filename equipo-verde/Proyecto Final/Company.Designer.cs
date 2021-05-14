
namespace Proyecto_Final
{
    partial class frmCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttSave = new MetroFramework.Controls.MetroButton();
            this.bttCancel = new MetroFramework.Controls.MetroButton();
            this.bttDelete = new MetroFramework.Controls.MetroButton();
            this.bttEdit = new MetroFramework.Controls.MetroButton();
            this.bttAdd = new MetroFramework.Controls.MetroButton();
            this.txtemail = new MetroFramework.Controls.MetroTextBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtpostalCode = new MetroFramework.Controls.MetroTextBox();
            this.txtaddress = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblemail = new MetroFramework.Controls.MetroLabel();
            this.lblpostalCode = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNumber = new MetroFramework.Controls.MetroLabel();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.bttSearch = new MetroFramework.Controls.MetroButton();
            this.pctphoto = new System.Windows.Forms.PictureBox();
            this.grdDatos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtphoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtwebsite = new MetroFramework.Controls.MetroTextBox();
            this.lblwebsite = new MetroFramework.Controls.MetroLabel();
            this.lblphoneNumberc = new MetroFramework.Controls.MetroLabel();
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            this.grdadviser = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctphoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdadviser)).BeginInit();
            this.SuspendLayout();
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(845, 266);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 80;
            this.bttSave.Text = "Save";
            this.bttSave.UseSelectable = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(756, 266);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 79;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseSelectable = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(671, 266);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 78;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseSelectable = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(583, 266);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 77;
            this.bttEdit.Text = "Edit";
            this.bttEdit.UseSelectable = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(494, 266);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 76;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseSelectable = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
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
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Email", true));
            this.txtemail.Lines = new string[0];
            this.txtemail.Location = new System.Drawing.Point(246, 193);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(222, 23);
            this.txtemail.TabIndex = 75;
            this.txtemail.UseSelectable = true;
            this.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Proyecto_Final.Entidades.Company);
            // 
            // txtpostalCode
            // 
            // 
            // 
            // 
            this.txtpostalCode.CustomButton.Image = null;
            this.txtpostalCode.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtpostalCode.CustomButton.Name = "";
            this.txtpostalCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpostalCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpostalCode.CustomButton.TabIndex = 1;
            this.txtpostalCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpostalCode.CustomButton.UseSelectable = true;
            this.txtpostalCode.CustomButton.Visible = false;
            this.txtpostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Postalcode", true));
            this.txtpostalCode.Lines = new string[0];
            this.txtpostalCode.Location = new System.Drawing.Point(246, 104);
            this.txtpostalCode.MaxLength = 32767;
            this.txtpostalCode.Name = "txtpostalCode";
            this.txtpostalCode.PasswordChar = '\0';
            this.txtpostalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpostalCode.SelectedText = "";
            this.txtpostalCode.SelectionLength = 0;
            this.txtpostalCode.SelectionStart = 0;
            this.txtpostalCode.ShortcutsEnabled = true;
            this.txtpostalCode.Size = new System.Drawing.Size(222, 23);
            this.txtpostalCode.TabIndex = 74;
            this.txtpostalCode.UseSelectable = true;
            this.txtpostalCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpostalCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtpostalCode.Click += new System.EventHandler(this.txtpostalCode_Click);
            // 
            // txtaddress
            // 
            // 
            // 
            // 
            this.txtaddress.CustomButton.Image = null;
            this.txtaddress.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtaddress.CustomButton.Name = "";
            this.txtaddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtaddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtaddress.CustomButton.TabIndex = 1;
            this.txtaddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtaddress.CustomButton.UseSelectable = true;
            this.txtaddress.CustomButton.Visible = false;
            this.txtaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Address", true));
            this.txtaddress.Lines = new string[0];
            this.txtaddress.Location = new System.Drawing.Point(246, 74);
            this.txtaddress.MaxLength = 32767;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtaddress.SelectedText = "";
            this.txtaddress.SelectionLength = 0;
            this.txtaddress.SelectionStart = 0;
            this.txtaddress.ShortcutsEnabled = true;
            this.txtaddress.Size = new System.Drawing.Size(222, 23);
            this.txtaddress.TabIndex = 73;
            this.txtaddress.UseSelectable = true;
            this.txtaddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtaddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtaddress.Click += new System.EventHandler(this.txtaddress_Click);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Name", true));
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(246, 45);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(222, 23);
            this.txtName.TabIndex = 72;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
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
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(246, 16);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(222, 23);
            this.txtId.TabIndex = 71;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(141, 193);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 19);
            this.lblemail.TabIndex = 70;
            this.lblemail.Text = "e-mail";
            // 
            // lblpostalCode
            // 
            this.lblpostalCode.AutoSize = true;
            this.lblpostalCode.Location = new System.Drawing.Point(141, 107);
            this.lblpostalCode.Name = "lblpostalCode";
            this.lblpostalCode.Size = new System.Drawing.Size(79, 19);
            this.lblpostalCode.TabIndex = 69;
            this.lblpostalCode.Text = "Postal Code";
            this.lblpostalCode.Click += new System.EventHandler(this.lblpostalCode_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(481, 180);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(0, 0);
            this.lblPhoneNumber.TabIndex = 68;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(141, 74);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 19);
            this.lblAddress.TabIndex = 67;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(141, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 66;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(141, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 65;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(32, 132);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(75, 23);
            this.bttSearch.TabIndex = 64;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseSelectable = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // pctphoto
            // 
            this.pctphoto.Location = new System.Drawing.Point(23, 26);
            this.pctphoto.Name = "pctphoto";
            this.pctphoto.Size = new System.Drawing.Size(97, 100);
            this.pctphoto.TabIndex = 63;
            this.pctphoto.TabStop = false;
            this.pctphoto.Click += new System.EventHandler(this.pctphoto_Click);
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
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.postalcodeDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.grdDatos.DataSource = this.companyBindingSource;
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
            this.grdDatos.Location = new System.Drawing.Point(4, 55);
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
            this.grdDatos.TabIndex = 61;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "Website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // postalcodeDataGridViewTextBoxColumn
            // 
            this.postalcodeDataGridViewTextBoxColumn.DataPropertyName = "Postalcode";
            this.postalcodeDataGridViewTextBoxColumn.HeaderText = "Postalcode";
            this.postalcodeDataGridViewTextBoxColumn.Name = "postalcodeDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // txtphoneNumber
            // 
            // 
            // 
            // 
            this.txtphoneNumber.CustomButton.Image = null;
            this.txtphoneNumber.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtphoneNumber.CustomButton.Name = "";
            this.txtphoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtphoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtphoneNumber.CustomButton.TabIndex = 1;
            this.txtphoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtphoneNumber.CustomButton.UseSelectable = true;
            this.txtphoneNumber.CustomButton.Visible = false;
            this.txtphoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Phonenumber", true));
            this.txtphoneNumber.Lines = new string[0];
            this.txtphoneNumber.Location = new System.Drawing.Point(246, 132);
            this.txtphoneNumber.MaxLength = 32767;
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.PasswordChar = '\0';
            this.txtphoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtphoneNumber.SelectedText = "";
            this.txtphoneNumber.SelectionLength = 0;
            this.txtphoneNumber.SelectionStart = 0;
            this.txtphoneNumber.ShortcutsEnabled = true;
            this.txtphoneNumber.Size = new System.Drawing.Size(222, 23);
            this.txtphoneNumber.TabIndex = 82;
            this.txtphoneNumber.UseSelectable = true;
            this.txtphoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtphoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtphoneNumber.Click += new System.EventHandler(this.txtphoneNumber_Click);
            // 
            // txtwebsite
            // 
            // 
            // 
            // 
            this.txtwebsite.CustomButton.Image = null;
            this.txtwebsite.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtwebsite.CustomButton.Name = "";
            this.txtwebsite.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtwebsite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtwebsite.CustomButton.TabIndex = 1;
            this.txtwebsite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtwebsite.CustomButton.UseSelectable = true;
            this.txtwebsite.CustomButton.Visible = false;
            this.txtwebsite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Website", true));
            this.txtwebsite.Lines = new string[0];
            this.txtwebsite.Location = new System.Drawing.Point(246, 164);
            this.txtwebsite.MaxLength = 32767;
            this.txtwebsite.Name = "txtwebsite";
            this.txtwebsite.PasswordChar = '\0';
            this.txtwebsite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtwebsite.SelectedText = "";
            this.txtwebsite.SelectionLength = 0;
            this.txtwebsite.SelectionStart = 0;
            this.txtwebsite.ShortcutsEnabled = true;
            this.txtwebsite.Size = new System.Drawing.Size(222, 23);
            this.txtwebsite.TabIndex = 83;
            this.txtwebsite.UseSelectable = true;
            this.txtwebsite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtwebsite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtwebsite.Click += new System.EventHandler(this.txtwebsite_Click);
            // 
            // lblwebsite
            // 
            this.lblwebsite.AutoSize = true;
            this.lblwebsite.Location = new System.Drawing.Point(141, 164);
            this.lblwebsite.Name = "lblwebsite";
            this.lblwebsite.Size = new System.Drawing.Size(55, 19);
            this.lblwebsite.TabIndex = 84;
            this.lblwebsite.Text = "Website";
            this.lblwebsite.Click += new System.EventHandler(this.lblwebsite_Click);
            // 
            // lblphoneNumberc
            // 
            this.lblphoneNumberc.AutoSize = true;
            this.lblphoneNumberc.Location = new System.Drawing.Point(138, 132);
            this.lblphoneNumberc.Name = "lblphoneNumberc";
            this.lblphoneNumberc.Size = new System.Drawing.Size(99, 19);
            this.lblphoneNumberc.TabIndex = 85;
            this.lblphoneNumberc.Text = "Phone Number";
            this.lblphoneNumberc.Click += new System.EventHandler(this.lblphoneNumberc_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblwebsite);
            this.pnlDatos.Controls.Add(this.lblphoneNumberc);
            this.pnlDatos.Controls.Add(this.lblAddress);
            this.pnlDatos.Controls.Add(this.txtwebsite);
            this.pnlDatos.Controls.Add(this.pctphoto);
            this.pnlDatos.Controls.Add(this.txtphoneNumber);
            this.pnlDatos.Controls.Add(this.bttSearch);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.Controls.Add(this.lblName);
            this.pnlDatos.Controls.Add(this.lblpostalCode);
            this.pnlDatos.Controls.Add(this.lblemail);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.txtemail);
            this.pnlDatos.Controls.Add(this.txtName);
            this.pnlDatos.Controls.Add(this.txtpostalCode);
            this.pnlDatos.Controls.Add(this.txtaddress);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(506, 28);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(484, 232);
            this.pnlDatos.TabIndex = 86;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // grdadviser
            // 
            this.grdadviser.AllowUserToResizeRows = false;
            this.grdadviser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdadviser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdadviser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdadviser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdadviser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdadviser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdadviser.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdadviser.EnableHeadersVisualStyles = false;
            this.grdadviser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdadviser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdadviser.Location = new System.Drawing.Point(459, 34);
            this.grdadviser.Name = "grdadviser";
            this.grdadviser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdadviser.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdadviser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdadviser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdadviser.Size = new System.Drawing.Size(519, 226);
            this.grdadviser.TabIndex = 62;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 396);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttEdit);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.grdadviser);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmCompany";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctphoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdadviser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton bttSave;
        private MetroFramework.Controls.MetroButton bttCancel;
        private MetroFramework.Controls.MetroButton bttDelete;
        private MetroFramework.Controls.MetroButton bttEdit;
        private MetroFramework.Controls.MetroButton bttAdd;
        private MetroFramework.Controls.MetroTextBox txtemail;
        private MetroFramework.Controls.MetroTextBox txtpostalCode;
        private MetroFramework.Controls.MetroTextBox txtaddress;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblemail;
        private MetroFramework.Controls.MetroLabel lblpostalCode;
        private MetroFramework.Controls.MetroLabel lblPhoneNumber;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton bttSearch;
        private System.Windows.Forms.PictureBox pctphoto;
        private MetroFramework.Controls.MetroGrid grdDatos;
        private MetroFramework.Controls.MetroTextBox txtphoneNumber;
        private MetroFramework.Controls.MetroTextBox txtwebsite;
        private MetroFramework.Controls.MetroLabel lblwebsite;
        private MetroFramework.Controls.MetroLabel lblphoneNumberc;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel pnlDatos;
        private MetroFramework.Controls.MetroGrid grdadviser;
    }
}