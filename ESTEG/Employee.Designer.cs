﻿namespace ESTEG
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // nomPrenomtxt
            // 
            nomPrenomtxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nomPrenomtxt.Location = new Point(772, 29);
            nomPrenomtxt.Margin = new Padding(5, 6, 5, 6);
            nomPrenomtxt.Name = "nomPrenomtxt";
            nomPrenomtxt.Size = new Size(535, 56);
            nomPrenomtxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(499, 29);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(259, 45);
            label4.TabIndex = 12;
            label4.Text = "Nom et Prenom";
            // 
            // TarifTxt
            // 
            TarifTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TarifTxt.Location = new Point(772, 104);
            TarifTxt.Margin = new Padding(5, 6, 5, 6);
            TarifTxt.Name = "TarifTxt";
            TarifTxt.Size = new Size(535, 56);
            TarifTxt.TabIndex = 13;
            TarifTxt.KeyPress += TarifTxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(496, 104);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(246, 45);
            label1.TabIndex = 14;
            label1.Text = "Tarif Journalier";
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Image = Properties.Resources.icons8_save_25;
            saveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            saveBtn.Location = new Point(772, 171);
            saveBtn.Margin = new Padding(5, 6, 5, 6);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(356, 98);
            saveBtn.TabIndex = 15;
            saveBtn.Text = "SAUVGARDER";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // idTxt
            // 
            idTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.Location = new Point(5, 192);
            idTxt.Margin = new Padding(5, 6, 5, 6);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(61, 50);
            idTxt.TabIndex = 16;
            idTxt.Visible = false;
            // 
            // employeeList
            // 
            employeeList.AllowUserToAddRows = false;
            employeeList.AllowUserToDeleteRows = false;
            employeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeeList.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            employeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            employeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeList.Columns.AddRange(new DataGridViewColumn[] { id, nomPrenom, tarif, edit, delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            employeeList.DefaultCellStyle = dataGridViewCellStyle2;
            employeeList.EnableHeadersVisualStyles = false;
            employeeList.Location = new Point(5, 282);
            employeeList.Margin = new Padding(5, 6, 5, 6);
            employeeList.Name = "employeeList";
            employeeList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            employeeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            employeeList.RowHeadersWidth = 51;
            employeeList.RowTemplate.Height = 35;
            employeeList.Size = new Size(1770, 376);
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
            tarif.Width = 400;
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
            edit.Width = 300;
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
            delete.Width = 300;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1781, 667);
            Controls.Add(employeeList);
            Controls.Add(idTxt);
            Controls.Add(saveBtn);
            Controls.Add(TarifTxt);
            Controls.Add(label1);
            Controls.Add(nomPrenomtxt);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Margin = new Padding(5, 5, 5, 5);
            MaximumSize = new Size(1807, 738);
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