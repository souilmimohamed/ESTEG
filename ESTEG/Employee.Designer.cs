namespace ESTEG
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            nomPrenomtxt = new TextBox();
            label4 = new Label();
            TarifTxt = new TextBox();
            label1 = new Label();
            saveBtn = new Button();
            idTxt = new TextBox();
            employeeList = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nomPrenom = new DataGridViewTextBoxColumn();
            tarif = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeList).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // nomPrenomtxt
            // 
            nomPrenomtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nomPrenomtxt.Location = new Point(475, 18);
            nomPrenomtxt.Margin = new Padding(3, 4, 3, 4);
            nomPrenomtxt.Name = "nomPrenomtxt";
            nomPrenomtxt.Size = new Size(331, 38);
            nomPrenomtxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(307, 18);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 12;
            label4.Text = "Nom et Prenom";
            // 
            // TarifTxt
            // 
            TarifTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TarifTxt.Location = new Point(475, 65);
            TarifTxt.Margin = new Padding(3, 4, 3, 4);
            TarifTxt.Name = "TarifTxt";
            TarifTxt.Size = new Size(331, 38);
            TarifTxt.TabIndex = 13;
            TarifTxt.KeyPress += TarifTxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(305, 65);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 14;
            label1.Text = "Tarif Journalier";
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Image = Properties.Resources.icons8_save_25;
            saveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            saveBtn.Location = new Point(475, 107);
            saveBtn.Margin = new Padding(3, 4, 3, 4);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(219, 61);
            saveBtn.TabIndex = 15;
            saveBtn.Text = "SAUVGARDER";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // idTxt
            // 
            idTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.Location = new Point(3, 120);
            idTxt.Margin = new Padding(3, 4, 3, 4);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(39, 34);
            idTxt.TabIndex = 16;
            idTxt.Visible = false;
            // 
            // employeeList
            // 
            employeeList.AllowUserToAddRows = false;
            employeeList.AllowUserToDeleteRows = false;
            employeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeeList.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            employeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            employeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeList.Columns.AddRange(new DataGridViewColumn[] { id, nomPrenom, tarif, edit, delete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            employeeList.DefaultCellStyle = dataGridViewCellStyle5;
            employeeList.EnableHeadersVisualStyles = false;
            employeeList.Location = new Point(3, 176);
            employeeList.Margin = new Padding(3, 4, 3, 4);
            employeeList.Name = "employeeList";
            employeeList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            employeeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            employeeList.RowHeadersWidth = 51;
            employeeList.RowTemplate.Height = 35;
            employeeList.Size = new Size(905, 259);
            employeeList.TabIndex = 17;
            employeeList.CellContentClick += employeeList_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 250;
            // 
            // nomPrenom
            // 
            nomPrenom.HeaderText = "NOM PRENOM";
            nomPrenom.MinimumWidth = 6;
            nomPrenom.Name = "nomPrenom";
            nomPrenom.ReadOnly = true;
            nomPrenom.Width = 400;
            // 
            // tarif
            // 
            tarif.HeaderText = "TARIF JOURNALIER";
            tarif.MinimumWidth = 6;
            tarif.Name = "tarif";
            tarif.ReadOnly = true;
            tarif.Width = 200;
            // 
            // edit
            // 
            edit.HeaderText = "MODIFIER";
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Resizable = DataGridViewTriState.True;
            edit.SortMode = DataGridViewColumnSortMode.Automatic;
            edit.Width = 125;
            // 
            // delete
            // 
            delete.HeaderText = "SUPPRIMER";
            delete.Image = Properties.Resources.icons8_delete_20;
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Width = 125;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 441);
            Controls.Add(employeeList);
            Controls.Add(idTxt);
            Controls.Add(saveBtn);
            Controls.Add(TarifTxt);
            Controls.Add(label1);
            Controls.Add(nomPrenomtxt);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(930, 488);
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox nomPrenomtxt;
        private Label label4;
        private TextBox TarifTxt;
        private Label label1;
        private Button saveBtn;
        private TextBox idTxt;
        private DataGridView employeeList;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nomPrenom;
        private DataGridViewTextBoxColumn tarif;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
    }
}