namespace ESTEG
{
    partial class FactureList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            factures = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            client = new DataGridViewTextBoxColumn();
            see = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            pdf = new DataGridViewImageColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            textBox2 = new TextBox();
            devis = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            see_d = new DataGridViewImageColumn();
            delete_d = new DataGridViewImageColumn();
            pdf_d = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)factures).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)devis).BeginInit();
            SuspendLayout();
            // 
            // factures
            // 
            factures.AllowUserToAddRows = false;
            factures.AllowUserToDeleteRows = false;
            factures.AllowUserToResizeColumns = false;
            factures.AllowUserToResizeRows = false;
            factures.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            factures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            factures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            factures.Columns.AddRange(new DataGridViewColumn[] { id, numero, date, client, see, delete, pdf });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            factures.DefaultCellStyle = dataGridViewCellStyle2;
            factures.EnableHeadersVisualStyles = false;
            factures.Location = new Point(13, 94);
            factures.Margin = new Padding(5, 6, 5, 6);
            factures.Name = "factures";
            factures.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            factures.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            factures.RowHeadersWidth = 51;
            factures.RowTemplate.Height = 35;
            factures.Size = new Size(1622, 848);
            factures.TabIndex = 0;
            factures.CellContentClick += factures_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // numero
            // 
            numero.HeaderText = "NUMERO";
            numero.MinimumWidth = 6;
            numero.Name = "numero";
            numero.ReadOnly = true;
            numero.Width = 200;
            // 
            // date
            // 
            date.HeaderText = "DATE";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 200;
            // 
            // client
            // 
            client.HeaderText = "CLIENT";
            client.MinimumWidth = 6;
            client.Name = "client";
            client.ReadOnly = true;
            client.Width = 300;
            // 
            // see
            // 
            see.HeaderText = "VOIR";
            see.Image = Properties.Resources.icons8_eye_20;
            see.ImageLayout = DataGridViewImageCellLayout.Zoom;
            see.MinimumWidth = 6;
            see.Name = "see";
            see.ReadOnly = true;
            see.Resizable = DataGridViewTriState.True;
            see.SortMode = DataGridViewColumnSortMode.Automatic;
            see.Width = 125;
            // 
            // delete
            // 
            delete.HeaderText = "SUPPRIMER";
            delete.Image = Properties.Resources.icons8_delete_201;
            delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Width = 200;
            // 
            // pdf
            // 
            pdf.HeaderText = "PDF";
            pdf.Image = Properties.Resources.icons8_pdf_20;
            pdf.ImageLayout = DataGridViewImageCellLayout.Zoom;
            pdf.MinimumWidth = 6;
            pdf.Name = "pdf";
            pdf.ReadOnly = true;
            pdf.Resizable = DataGridViewTriState.True;
            pdf.SortMode = DataGridViewColumnSortMode.Automatic;
            pdf.Width = 125;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 19);
            tabControl1.Margin = new Padding(5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1653, 1002);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(factures);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Margin = new Padding(5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5);
            tabPage1.Size = new Size(1637, 948);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "FACTURE";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(13, 29);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 50);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(devis);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5);
            tabPage2.Size = new Size(1637, 948);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "DEVIS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(13, 24);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 50);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // devis
            // 
            devis.AllowUserToAddRows = false;
            devis.AllowUserToDeleteRows = false;
            devis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            devis.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            devis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            devis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            devis.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, see_d, delete_d, pdf_d });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            devis.DefaultCellStyle = dataGridViewCellStyle5;
            devis.EnableHeadersVisualStyles = false;
            devis.Location = new Point(11, 90);
            devis.Margin = new Padding(5, 6, 5, 6);
            devis.Name = "devis";
            devis.ReadOnly = true;
            devis.RowHeadersWidth = 51;
            devis.RowTemplate.Height = 35;
            devis.Size = new Size(1618, 850);
            devis.TabIndex = 1;
            devis.CellContentClick += DEVIS_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "NUMERO";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "DATE";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "CLIENT";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 300;
            // 
            // see_d
            // 
            see_d.HeaderText = "VOIR";
            see_d.Image = Properties.Resources.icons8_eye_20;
            see_d.ImageLayout = DataGridViewImageCellLayout.Zoom;
            see_d.MinimumWidth = 6;
            see_d.Name = "see_d";
            see_d.ReadOnly = true;
            see_d.Resizable = DataGridViewTriState.True;
            see_d.SortMode = DataGridViewColumnSortMode.Automatic;
            see_d.Width = 125;
            // 
            // delete_d
            // 
            delete_d.HeaderText = "SUPPRIMER";
            delete_d.Image = Properties.Resources.icons8_delete_20;
            delete_d.ImageLayout = DataGridViewImageCellLayout.Zoom;
            delete_d.MinimumWidth = 6;
            delete_d.Name = "delete_d";
            delete_d.ReadOnly = true;
            delete_d.Resizable = DataGridViewTriState.True;
            delete_d.SortMode = DataGridViewColumnSortMode.Automatic;
            delete_d.ToolTipText = "Supp.";
            delete_d.Width = 200;
            // 
            // pdf_d
            // 
            pdf_d.HeaderText = "PDF";
            pdf_d.Image = Properties.Resources.icons8_pdf_20;
            pdf_d.ImageLayout = DataGridViewImageCellLayout.Zoom;
            pdf_d.MinimumWidth = 6;
            pdf_d.Name = "pdf_d";
            pdf_d.ReadOnly = true;
            pdf_d.Resizable = DataGridViewTriState.True;
            pdf_d.SortMode = DataGridViewColumnSortMode.Automatic;
            pdf_d.ToolTipText = "PDF";
            pdf_d.Width = 125;
            // 
            // FactureList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1672, 1022);
            Controls.Add(tabControl1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FactureList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Factures";
            Load += FactureList_Load;
            ((System.ComponentModel.ISupportInitialize)factures).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)devis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView factures;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView devis;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn client;
        private DataGridViewImageColumn see;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn pdf;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewImageColumn see_d;
        private DataGridViewImageColumn delete_d;
        private DataGridViewImageColumn pdf_d;
    }
}