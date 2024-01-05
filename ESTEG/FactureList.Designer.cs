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
            see = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            pdf = new DataGridViewButtonColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            DEVIS = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)factures).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DEVIS).BeginInit();
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
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
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
            factures.Location = new Point(8, 59);
            factures.Margin = new Padding(3, 4, 3, 4);
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
            factures.Size = new Size(961, 530);
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
            numero.Width = 125;
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
            client.Width = 200;
            // 
            // see
            // 
            see.HeaderText = "VOIR";
            see.MinimumWidth = 6;
            see.Name = "see";
            see.ReadOnly = true;
            see.Resizable = DataGridViewTriState.True;
            see.SortMode = DataGridViewColumnSortMode.Automatic;
            see.Text = "Voir";
            see.UseColumnTextForButtonValue = true;
            see.Width = 125;
            // 
            // delete
            // 
            delete.HeaderText = "SUPPRIMER";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Text = "Supp.";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 125;
            // 
            // pdf
            // 
            pdf.HeaderText = "PDF";
            pdf.MinimumWidth = 6;
            pdf.Name = "pdf";
            pdf.ReadOnly = true;
            pdf.Resizable = DataGridViewTriState.True;
            pdf.SortMode = DataGridViewColumnSortMode.Automatic;
            pdf.Text = "PDF";
            pdf.UseColumnTextForButtonValue = true;
            pdf.Width = 125;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 626);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(factures);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(975, 593);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "FACTURE";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(8, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(DEVIS);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(975, 593);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "DEVIS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DEVIS
            // 
            DEVIS.AllowUserToAddRows = false;
            DEVIS.AllowUserToDeleteRows = false;
            DEVIS.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DEVIS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DEVIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DEVIS.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewButtonColumn1, dataGridViewButtonColumn2, dataGridViewButtonColumn3 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DEVIS.DefaultCellStyle = dataGridViewCellStyle5;
            DEVIS.Location = new Point(7, 56);
            DEVIS.Margin = new Padding(3, 4, 3, 4);
            DEVIS.Name = "DEVIS";
            DEVIS.ReadOnly = true;
            DEVIS.RowHeadersWidth = 51;
            DEVIS.RowTemplate.Height = 35;
            DEVIS.Size = new Size(961, 531);
            DEVIS.TabIndex = 1;
            DEVIS.CellContentClick += DEVIS_CellContentClick;
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
            dataGridViewTextBoxColumn2.Width = 125;
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
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "VOIR";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewButtonColumn1.Text = "Voir";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 125;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.HeaderText = "SUPPRIMER";
            dataGridViewButtonColumn2.MinimumWidth = 6;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.ReadOnly = true;
            dataGridViewButtonColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewButtonColumn2.Text = "Supp.";
            dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn2.Width = 125;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.HeaderText = "PDF";
            dataGridViewButtonColumn3.MinimumWidth = 6;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.ReadOnly = true;
            dataGridViewButtonColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewButtonColumn3.Text = "PDF";
            dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn3.Width = 125;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(8, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 34);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // FactureList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 639);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)DEVIS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView factures;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn client;
        private DataGridViewButtonColumn see;
        private DataGridViewButtonColumn delete;
        private DataGridViewButtonColumn pdf;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView DEVIS;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}