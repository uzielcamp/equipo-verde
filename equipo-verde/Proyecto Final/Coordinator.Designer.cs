﻿
namespace Proyecto_Final
{
    partial class frmCoordinator
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
            this.grddatos = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.pctPhoto = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.lblFirstName = new MetroFramework.Controls.MetroLabel();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.lblLastName = new MetroFramework.Controls.MetroLabel();
            this.txtCellphone = new MetroFramework.Controls.MetroTextBox();
            this.lblCellphone = new MetroFramework.Controls.MetroLabel();
            this.txtemail = new MetroFramework.Controls.MetroTextBox();
            this.lblemail = new MetroFramework.Controls.MetroLabel();
            this.bttSearch = new MetroFramework.Controls.MetroButton();
            this.bttAdd = new MetroFramework.Controls.MetroButton();
            this.bttEdit = new MetroFramework.Controls.MetroButton();
            this.bttDelete = new MetroFramework.Controls.MetroButton();
            this.bttCancel = new MetroFramework.Controls.MetroButton();
            this.bttSave = new MetroFramework.Controls.MetroButton();
            this.pnlDatos = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grddatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grddatos
            // 
            this.grddatos.AllowUserToResizeRows = false;
            this.grddatos.AutoGenerateColumns = false;
            this.grddatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grddatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grddatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grddatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grddatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grddatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.cellphoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.grddatos.DataSource = this.coordinatorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grddatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grddatos.EnableHeadersVisualStyles = false;
            this.grddatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grddatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grddatos.Location = new System.Drawing.Point(6, 55);
            this.grddatos.Name = "grddatos";
            this.grddatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grddatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grddatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grddatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grddatos.Size = new System.Drawing.Size(463, 234);
            this.grddatos.TabIndex = 0;
            this.grddatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grddatos_CellContentClick);
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
            // coordinatorBindingSource
            // 
            this.coordinatorBindingSource.DataSource = typeof(Proyecto_Final.Entidades.Coordinator);
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
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(226, 17);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(222, 23);
            this.txtId.TabIndex = 6;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(121, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 19);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // pctPhoto
            // 
            this.pctPhoto.Location = new System.Drawing.Point(3, 27);
            this.pctPhoto.Name = "pctPhoto";
            this.pctPhoto.Size = new System.Drawing.Size(97, 100);
            this.pctPhoto.TabIndex = 7;
            this.pctPhoto.TabStop = false;
            this.pctPhoto.Click += new System.EventHandler(this.pctPhoto_Click);
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
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "FirstName", true));
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(226, 46);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(222, 23);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstName.Click += new System.EventHandler(this.txtFirstName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(121, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(69, 19);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "FirstName";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
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
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "LastName", true));
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(226, 75);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(222, 23);
            this.txtLastName.TabIndex = 11;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastName.Click += new System.EventHandler(this.txtLastName_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(121, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 19);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "LastName";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
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
            this.txtCellphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "Cellphone", true));
            this.txtCellphone.Lines = new string[0];
            this.txtCellphone.Location = new System.Drawing.Point(226, 105);
            this.txtCellphone.MaxLength = 32767;
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.PasswordChar = '\0';
            this.txtCellphone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCellphone.SelectedText = "";
            this.txtCellphone.SelectionLength = 0;
            this.txtCellphone.SelectionStart = 0;
            this.txtCellphone.ShortcutsEnabled = true;
            this.txtCellphone.Size = new System.Drawing.Size(222, 23);
            this.txtCellphone.TabIndex = 13;
            this.txtCellphone.UseSelectable = true;
            this.txtCellphone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCellphone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCellphone.Click += new System.EventHandler(this.txtCellphone_Click);
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(121, 108);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(68, 19);
            this.lblCellphone.TabIndex = 12;
            this.lblCellphone.Text = "Cellphone";
            this.lblCellphone.Click += new System.EventHandler(this.lblCellphone_Click);
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
            this.txtemail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coordinatorBindingSource, "Email", true));
            this.txtemail.Lines = new string[0];
            this.txtemail.Location = new System.Drawing.Point(226, 133);
            this.txtemail.MaxLength = 32767;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(222, 23);
            this.txtemail.TabIndex = 15;
            this.txtemail.UseSelectable = true;
            this.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtemail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtemail.Click += new System.EventHandler(this.txtemail_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(118, 133);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 19);
            this.lblemail.TabIndex = 14;
            this.lblemail.Text = "email";
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(12, 133);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(75, 23);
            this.bttSearch.TabIndex = 16;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseSelectable = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Location = new System.Drawing.Point(485, 328);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(75, 23);
            this.bttAdd.TabIndex = 17;
            this.bttAdd.Text = "Add";
            this.bttAdd.UseSelectable = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttEdit
            // 
            this.bttEdit.Location = new System.Drawing.Point(573, 328);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(75, 23);
            this.bttEdit.TabIndex = 18;
            this.bttEdit.Text = "Edit";
            this.bttEdit.UseSelectable = true;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(660, 328);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 19;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseSelectable = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(751, 328);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 20;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseSelectable = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(849, 328);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 21;
            this.bttSave.Text = "Save";
            this.bttSave.UseSelectable = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblLastName);
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.pctPhoto);
            this.pnlDatos.Controls.Add(this.bttSearch);
            this.pnlDatos.Controls.Add(this.lblFirstName);
            this.pnlDatos.Controls.Add(this.txtemail);
            this.pnlDatos.Controls.Add(this.txtFirstName);
            this.pnlDatos.Controls.Add(this.lblemail);
            this.pnlDatos.Controls.Add(this.txtLastName);
            this.pnlDatos.Controls.Add(this.txtCellphone);
            this.pnlDatos.Controls.Add(this.lblCellphone);
            this.pnlDatos.HorizontalScrollbarBarColor = true;
            this.pnlDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlDatos.HorizontalScrollbarSize = 10;
            this.pnlDatos.Location = new System.Drawing.Point(485, 63);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(457, 195);
            this.pnlDatos.TabIndex = 22;
            this.pnlDatos.VerticalScrollbarBarColor = true;
            this.pnlDatos.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDatos.VerticalScrollbarSize = 10;
            // 
            // frmCoordinator
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
            this.Controls.Add(this.grddatos);
            this.Name = "frmCoordinator";
            this.Text = "Coordinator";
            this.Load += new System.EventHandler(this.frmCoordinator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grddatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPhoto)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grddatos;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private System.Windows.Forms.PictureBox pctPhoto;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroLabel lblFirstName;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel lblLastName;
        private MetroFramework.Controls.MetroTextBox txtCellphone;
        private MetroFramework.Controls.MetroLabel lblCellphone;
        private MetroFramework.Controls.MetroTextBox txtemail;
        private MetroFramework.Controls.MetroLabel lblemail;
        private MetroFramework.Controls.MetroButton bttSearch;
        private MetroFramework.Controls.MetroButton bttAdd;
        private MetroFramework.Controls.MetroButton bttEdit;
        private MetroFramework.Controls.MetroButton bttDelete;
        private MetroFramework.Controls.MetroButton bttCancel;
        private MetroFramework.Controls.MetroButton bttSave;
        private System.Windows.Forms.BindingSource coordinatorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel pnlDatos;
    }
}