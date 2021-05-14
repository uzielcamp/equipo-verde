
namespace Proyecto_Final
{
    partial class frmCoach
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
            this.bttSave = new MetroFramework.Controls.MetroButton();
            this.bttCancel = new MetroFramework.Controls.MetroButton();
            this.bttDelete = new MetroFramework.Controls.MetroButton();
            this.bttEdit = new MetroFramework.Controls.MetroButton();
            this.bttAdd = new MetroFramework.Controls.MetroButton();
            this.txtemail = new MetroFramework.Controls.MetroTextBox();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCellphone = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblemail = new MetroFramework.Controls.MetroLabel();
            this.lblCellphone = new MetroFramework.Controls.MetroLabel();
            this.lblPhoneNumber = new MetroFramework.Controls.MetroLabel();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.bttSearch = new MetroFramework.Controls.MetroButton();
            this.pctphoto = new System.Windows.Forms.PictureBox();
            this.grdConcentradodeDatos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctphoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConcentradodeDatos)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(805, 246);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 60;
            this.bttSave.Text = "Save";
            this.bttSave.UseSelectable = true;
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(724, 246);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 59;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseSelectable = true;
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(643, 246);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 58;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseSelectable = true;
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(562, 246);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 57;
            this.bttEdit.Text = "Edit";
            this.bttEdit.UseSelectable = true;
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(481, 246);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 56;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseSelectable = true;
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
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachBindingSource, "Cellphone", true));
            this.txtemail.Lines = new string[0];
            this.txtemail.Location = new System.Drawing.Point(222, 131);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(222, 23);
            this.txtemail.TabIndex = 54;
            this.txtemail.UseSelectable = true;
            this.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataSource = typeof(Proyecto_Final.Entidades.Coach);
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
            this.txtCellphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachBindingSource, "LastName", true));
            this.txtCellphone.Lines = new string[0];
            this.txtCellphone.Location = new System.Drawing.Point(222, 99);
            this.txtCellphone.MaxLength = 32767;
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.PasswordChar = '\0';
            this.txtCellphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCellphone.SelectedText = "";
            this.txtCellphone.SelectionLength = 0;
            this.txtCellphone.SelectionStart = 0;
            this.txtCellphone.ShortcutsEnabled = true;
            this.txtCellphone.Size = new System.Drawing.Size(222, 23);
            this.txtCellphone.TabIndex = 53;
            this.txtCellphone.UseSelectable = true;
            this.txtCellphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCellphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(222, 70);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(222, 23);
            this.txtLastName.TabIndex = 51;
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
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachBindingSource, "FirstName", true));
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(222, 45);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(222, 23);
            this.txtFirstName.TabIndex = 50;
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
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachBindingSource, "Id", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(222, 16);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(222, 23);
            this.txtId.TabIndex = 49;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(117, 132);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 19);
            this.lblemail.TabIndex = 47;
            this.lblemail.Text = "e-mail";
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(117, 107);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(68, 19);
            this.lblCellphone.TabIndex = 46;
            this.lblCellphone.Text = "Cellphone";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(481, 180);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(0, 0);
            this.lblPhoneNumber.TabIndex = 45;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(117, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 19);
            this.lblLastName.TabIndex = 44;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(117, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 19);
            this.lblFirstName.TabIndex = 43;
            this.lblFirstName.Text = "First Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(117, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 42;
            this.lblId.Text = "Id";
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(13, 109);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(75, 23);
            this.bttSearch.TabIndex = 41;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseSelectable = true;
            // 
            // pctphoto
            // 
            this.pctphoto.Location = new System.Drawing.Point(3, 3);
            this.pctphoto.Name = "pctphoto";
            this.pctphoto.Size = new System.Drawing.Size(97, 100);
            this.pctphoto.TabIndex = 40;
            this.pctphoto.TabStop = false;
            // 
            // grdConcentradodeDatos
            // 
            this.grdConcentradodeDatos.AllowUserToResizeRows = false;
            this.grdConcentradodeDatos.AutoGenerateColumns = false;
            this.grdConcentradodeDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConcentradodeDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdConcentradodeDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdConcentradodeDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConcentradodeDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdConcentradodeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConcentradodeDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.cellphoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.grdConcentradodeDatos.DataSource = this.coachBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConcentradodeDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdConcentradodeDatos.EnableHeadersVisualStyles = false;
            this.grdConcentradodeDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdConcentradodeDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConcentradodeDatos.Location = new System.Drawing.Point(6, 55);
            this.grdConcentradodeDatos.Name = "grdConcentradodeDatos";
            this.grdConcentradodeDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConcentradodeDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdConcentradodeDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConcentradodeDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConcentradodeDatos.Size = new System.Drawing.Size(463, 234);
            this.grdConcentradodeDatos.TabIndex = 38;
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
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.pctphoto);
            this.metroPanel1.Controls.Add(this.bttSearch);
            this.metroPanel1.Controls.Add(this.lblFirstName);
            this.metroPanel1.Controls.Add(this.lblId);
            this.metroPanel1.Controls.Add(this.txtLastName);
            this.metroPanel1.Controls.Add(this.lblLastName);
            this.metroPanel1.Controls.Add(this.txtemail);
            this.metroPanel1.Controls.Add(this.lblCellphone);
            this.metroPanel1.Controls.Add(this.txtCellphone);
            this.metroPanel1.Controls.Add(this.lblemail);
            this.metroPanel1.Controls.Add(this.txtId);
            this.metroPanel1.Controls.Add(this.txtFirstName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(475, 55);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(469, 176);
            this.metroPanel1.TabIndex = 62;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // frmCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 396);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttEdit);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.grdConcentradodeDatos);
            this.Name = "frmCoach";
            this.Text = "Coach";
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctphoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdConcentradodeDatos)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
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
        private MetroFramework.Controls.MetroTextBox txtCellphone;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblemail;
        private MetroFramework.Controls.MetroLabel lblCellphone;
        private MetroFramework.Controls.MetroLabel lblPhoneNumber;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton bttSearch;
        private System.Windows.Forms.PictureBox pctphoto;
        private MetroFramework.Controls.MetroGrid grdConcentradodeDatos;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}