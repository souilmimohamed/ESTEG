namespace ESTEG
{
    partial class Facture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            newBtn = new Button();
            deleteBtn = new Button();
            pdfBtn = new Button();
            listBtn = new Button();
            facturePositions = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            qte = new DataGridViewTextBoxColumn();
            designation = new DataGridViewTextBoxColumn();
            unite = new DataGridViewTextBoxColumn();
            puht = new DataGridViewTextBoxColumn();
            tva = new DataGridViewTextBoxColumn();
            ptht = new DataGridViewTextBoxColumn();
            puht_h = new DataGridViewTextBoxColumn();
            ptht_h = new DataGridViewTextBoxColumn();
            edit = new DataGridViewImageColumn();
            delete = new DataGridViewImageColumn();
            button1 = new Button();
            panel1 = new Panel();
            bcTxt = new TextBox();
            label13 = new Label();
            typeCbx = new ComboBox();
            numFactureLbl = new Label();
            dateDte = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            timbreCbx = new ComboBox();
            label12 = new Label();
            tvaCbx = new ComboBox();
            label11 = new Label();
            mfTxt = new TextBox();
            AdresseTxt = new TextBox();
            clientTxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            tvaValueLbl = new Label();
            label10 = new Label();
            label7 = new Label();
            tttcLbl = new Label();
            timbreLbl = new Label();
            ttvaLbl = new Label();
            thtLbl = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            idTxt = new TextBox();
            projetsTxt = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facturePositions).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // newBtn
            // 
            newBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newBtn.Image = Properties.Resources.icons8_add_25;
            newBtn.ImageAlign = ContentAlignment.MiddleLeft;
            newBtn.Location = new Point(5, 307);
            newBtn.Margin = new Padding(3, 4, 3, 4);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(167, 61);
            newBtn.TabIndex = 1;
            newBtn.Text = "Nouveau";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.Image = Properties.Resources.icons8_delete_25;
            deleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteBtn.Location = new Point(5, 376);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(167, 61);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Supprimer";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // pdfBtn
            // 
            pdfBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pdfBtn.Image = Properties.Resources.icons8_pdf_25;
            pdfBtn.ImageAlign = ContentAlignment.MiddleLeft;
            pdfBtn.Location = new Point(5, 445);
            pdfBtn.Margin = new Padding(3, 4, 3, 4);
            pdfBtn.Name = "pdfBtn";
            pdfBtn.Size = new Size(167, 61);
            pdfBtn.TabIndex = 3;
            pdfBtn.Text = "PDF";
            pdfBtn.UseVisualStyleBackColor = true;
            pdfBtn.Click += button3_Click;
            // 
            // listBtn
            // 
            listBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBtn.Image = Properties.Resources.icons8_list_25;
            listBtn.ImageAlign = ContentAlignment.MiddleLeft;
            listBtn.Location = new Point(5, 239);
            listBtn.Margin = new Padding(3, 4, 3, 4);
            listBtn.Name = "listBtn";
            listBtn.Size = new Size(167, 61);
            listBtn.TabIndex = 4;
            listBtn.Text = "LIST";
            listBtn.UseVisualStyleBackColor = true;
            listBtn.Click += listBtn_Click;
            // 
            // facturePositions
            // 
            facturePositions.AllowUserToAddRows = false;
            facturePositions.AllowUserToDeleteRows = false;
            facturePositions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            facturePositions.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            facturePositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            facturePositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            facturePositions.Columns.AddRange(new DataGridViewColumn[] { id, qte, designation, unite, puht, tva, ptht, puht_h, ptht_h, edit, delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            facturePositions.DefaultCellStyle = dataGridViewCellStyle2;
            facturePositions.EnableHeadersVisualStyles = false;
            facturePositions.Location = new Point(178, 406);
            facturePositions.Margin = new Padding(3, 4, 3, 4);
            facturePositions.Name = "facturePositions";
            facturePositions.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            facturePositions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            facturePositions.RowHeadersWidth = 51;
            facturePositions.RowTemplate.Height = 35;
            facturePositions.Size = new Size(1221, 653);
            facturePositions.TabIndex = 6;
            facturePositions.CellContentClick += facturePositions_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // qte
            // 
            qte.HeaderText = "QTE";
            qte.MinimumWidth = 6;
            qte.Name = "qte";
            qte.ReadOnly = true;
            qte.Width = 125;
            // 
            // designation
            // 
            designation.HeaderText = "DESIGNATION";
            designation.MinimumWidth = 6;
            designation.Name = "designation";
            designation.ReadOnly = true;
            designation.Width = 800;
            // 
            // unite
            // 
            unite.HeaderText = "UNITE";
            unite.MinimumWidth = 6;
            unite.Name = "unite";
            unite.ReadOnly = true;
            unite.Width = 125;
            // 
            // puht
            // 
            puht.HeaderText = "PUHT";
            puht.MinimumWidth = 6;
            puht.Name = "puht";
            puht.ReadOnly = true;
            puht.Width = 125;
            // 
            // tva
            // 
            tva.HeaderText = "TVA";
            tva.MinimumWidth = 6;
            tva.Name = "tva";
            tva.ReadOnly = true;
            tva.Width = 125;
            // 
            // ptht
            // 
            ptht.HeaderText = "PTHT";
            ptht.MinimumWidth = 6;
            ptht.Name = "ptht";
            ptht.ReadOnly = true;
            ptht.Width = 125;
            // 
            // puht_h
            // 
            puht_h.HeaderText = "puht_h";
            puht_h.MinimumWidth = 6;
            puht_h.Name = "puht_h";
            puht_h.ReadOnly = true;
            puht_h.Visible = false;
            puht_h.Width = 125;
            // 
            // ptht_h
            // 
            ptht_h.HeaderText = "ptht_h";
            ptht_h.MinimumWidth = 6;
            ptht_h.Name = "ptht_h";
            ptht_h.ReadOnly = true;
            ptht_h.Visible = false;
            ptht_h.Width = 125;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.icons8_add_25__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(177, 337);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(234, 61);
            button1.TabIndex = 7;
            button1.Text = "     NOUVEAU ARTICLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(bcTxt);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(typeCbx);
            panel1.Controls.Add(numFactureLbl);
            panel1.Controls.Add(dateDte);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(428, 3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 200);
            panel1.TabIndex = 8;
            // 
            // bcTxt
            // 
            bcTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bcTxt.Location = new Point(77, 131);
            bcTxt.Margin = new Padding(3, 4, 3, 4);
            bcTxt.Name = "bcTxt";
            bcTxt.Size = new Size(250, 34);
            bcTxt.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(6, 131);
            label13.Name = "label13";
            label13.Size = new Size(42, 28);
            label13.TabIndex = 17;
            label13.Text = "BC:";
            // 
            // typeCbx
            // 
            typeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            typeCbx.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            typeCbx.FormattingEnabled = true;
            typeCbx.Items.AddRange(new object[] { "FACTURE", "DEVIS" });
            typeCbx.Location = new Point(6, 6);
            typeCbx.Margin = new Padding(3, 4, 3, 4);
            typeCbx.Name = "typeCbx";
            typeCbx.Size = new Size(343, 39);
            typeCbx.TabIndex = 16;
            // 
            // numFactureLbl
            // 
            numFactureLbl.AutoSize = true;
            numFactureLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numFactureLbl.Location = new Point(186, 56);
            numFactureLbl.Name = "numFactureLbl";
            numFactureLbl.Size = new Size(21, 28);
            numFactureLbl.TabIndex = 12;
            numFactureLbl.Text = "/";
            // 
            // dateDte
            // 
            dateDte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateDte.Location = new Point(77, 89);
            dateDte.Margin = new Padding(3, 4, 3, 4);
            dateDte.Name = "dateDte";
            dateDte.Size = new Size(250, 34);
            dateDte.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 93);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 10;
            label3.Text = "DATE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 9;
            label2.Text = "NUM:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(timbreCbx);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(tvaCbx);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(mfTxt);
            panel2.Controls.Add(AdresseTxt);
            panel2.Controls.Add(clientTxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(978, 3);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 200);
            panel2.TabIndex = 9;
            // 
            // timbreCbx
            // 
            timbreCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            timbreCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timbreCbx.FormattingEnabled = true;
            timbreCbx.Items.AddRange(new object[] { "0", "1000" });
            timbreCbx.Location = new Point(268, 128);
            timbreCbx.Margin = new Padding(3, 4, 3, 4);
            timbreCbx.Name = "timbreCbx";
            timbreCbx.Size = new Size(141, 36);
            timbreCbx.TabIndex = 15;
            timbreCbx.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(228, 128);
            label12.Name = "label12";
            label12.Size = new Size(34, 28);
            label12.TabIndex = 14;
            label12.Text = "TF";
            // 
            // tvaCbx
            // 
            tvaCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            tvaCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tvaCbx.FormattingEnabled = true;
            tvaCbx.Items.AddRange(new object[] { "19%", "13%", "7%", "0%" });
            tvaCbx.Location = new Point(102, 128);
            tvaCbx.Margin = new Padding(3, 4, 3, 4);
            tvaCbx.Name = "tvaCbx";
            tvaCbx.Size = new Size(114, 36);
            tvaCbx.TabIndex = 13;
            tvaCbx.SelectedIndexChanged += tvaCbx_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 131);
            label11.Name = "label11";
            label11.Size = new Size(56, 28);
            label11.TabIndex = 12;
            label11.Text = "TVA:";
            // 
            // mfTxt
            // 
            mfTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mfTxt.Location = new Point(102, 88);
            mfTxt.Margin = new Padding(3, 4, 3, 4);
            mfTxt.Name = "mfTxt";
            mfTxt.Size = new Size(307, 34);
            mfTxt.TabIndex = 10;
            // 
            // AdresseTxt
            // 
            AdresseTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AdresseTxt.Location = new Point(102, 47);
            AdresseTxt.Margin = new Padding(3, 4, 3, 4);
            AdresseTxt.Name = "AdresseTxt";
            AdresseTxt.Size = new Size(307, 34);
            AdresseTxt.TabIndex = 10;
            // 
            // clientTxt
            // 
            clientTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clientTxt.Location = new Point(104, 8);
            clientTxt.Margin = new Padding(3, 4, 3, 4);
            clientTxt.Name = "clientTxt";
            clientTxt.Size = new Size(305, 34);
            clientTxt.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 93);
            label4.Name = "label4";
            label4.Size = new Size(46, 28);
            label4.TabIndex = 10;
            label4.Text = "MF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 51);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 9;
            label5.Text = "ADRESSE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(84, 28);
            label6.TabIndex = 0;
            label6.Text = "CLIENT:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tvaValueLbl);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(tttcLbl);
            panel3.Controls.Add(timbreLbl);
            panel3.Controls.Add(ttvaLbl);
            panel3.Controls.Add(thtLbl);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(1064, 1067);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 165);
            panel3.TabIndex = 10;
            // 
            // tvaValueLbl
            // 
            tvaValueLbl.AutoSize = true;
            tvaValueLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tvaValueLbl.Location = new Point(118, 51);
            tvaValueLbl.Name = "tvaValueLbl";
            tvaValueLbl.Size = new Size(20, 28);
            tvaValueLbl.TabIndex = 13;
            tvaValueLbl.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 89);
            label10.Name = "label10";
            label10.Size = new Size(142, 28);
            label10.TabIndex = 11;
            label10.Text = "timbre fiscale";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 128);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 11;
            label7.Text = "TOTAL TTC";
            // 
            // tttcLbl
            // 
            tttcLbl.AutoSize = true;
            tttcLbl.BackColor = Color.Black;
            tttcLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tttcLbl.ForeColor = Color.White;
            tttcLbl.Location = new Point(202, 128);
            tttcLbl.Name = "tttcLbl";
            tttcLbl.Size = new Size(24, 28);
            tttcLbl.TabIndex = 11;
            tttcLbl.Text = "0";
            // 
            // timbreLbl
            // 
            timbreLbl.AutoSize = true;
            timbreLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            timbreLbl.Location = new Point(202, 89);
            timbreLbl.Name = "timbreLbl";
            timbreLbl.Size = new Size(24, 28);
            timbreLbl.TabIndex = 14;
            timbreLbl.Text = "0";
            // 
            // ttvaLbl
            // 
            ttvaLbl.AutoSize = true;
            ttvaLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ttvaLbl.Location = new Point(202, 51);
            ttvaLbl.Name = "ttvaLbl";
            ttvaLbl.Size = new Size(24, 28);
            ttvaLbl.TabIndex = 13;
            ttvaLbl.Text = "0";
            // 
            // thtLbl
            // 
            thtLbl.AutoSize = true;
            thtLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thtLbl.Location = new Point(202, 9);
            thtLbl.Name = "thtLbl";
            thtLbl.Size = new Size(24, 28);
            thtLbl.TabIndex = 12;
            thtLbl.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 51);
            label8.Name = "label8";
            label8.Size = new Size(117, 28);
            label8.TabIndex = 9;
            label8.Text = "TOTAL TVA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 9);
            label9.Name = "label9";
            label9.Size = new Size(105, 28);
            label9.TabIndex = 0;
            label9.Text = "TOTAL HT";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.icons8_save_25;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(177, 1067);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(234, 61);
            button2.TabIndex = 11;
            button2.Text = "SAUVGARDER";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // idTxt
            // 
            idTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            idTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.Location = new Point(3, 1198);
            idTxt.Margin = new Padding(3, 4, 3, 4);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(35, 34);
            idTxt.TabIndex = 12;
            idTxt.Visible = false;
            // 
            // projetsTxt
            // 
            projetsTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projetsTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            projetsTxt.Location = new Point(178, 239);
            projetsTxt.Margin = new Padding(3, 4, 3, 4);
            projetsTxt.Multiline = true;
            projetsTxt.Name = "projetsTxt";
            projetsTxt.Size = new Size(1221, 90);
            projetsTxt.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(178, 207);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 14;
            label1.Text = "PROJETS:";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            // 
            // menuBtn
            // 
            menuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuBtn.Image = (Image)resources.GetObject("menuBtn.Image");
            menuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            menuBtn.Location = new Point(5, 514);
            menuBtn.Margin = new Padding(3, 4, 3, 4);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(167, 61);
            menuBtn.TabIndex = 38;
            menuBtn.Text = "MENU";
            menuBtn.UseVisualStyleBackColor = true;
            menuBtn.Click += menuBtn_Click;
            // 
            // Facture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 1240);
            Controls.Add(menuBtn);
            Controls.Add(label1);
            Controls.Add(projetsTxt);
            Controls.Add(idTxt);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(facturePositions);
            Controls.Add(listBtn);
            Controls.Add(pdfBtn);
            Controls.Add(deleteBtn);
            Controls.Add(newBtn);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Facture";
            Text = "Facture";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)facturePositions).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button newBtn;
        private Button deleteBtn;
        private Button pdfBtn;
        private Button listBtn;
        private DataGridView facturePositions;
        private Button button1;
        private Panel panel1;
        private DateTimePicker dateDte;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox mfTxt;
        private TextBox AdresseTxt;
        private TextBox clientTxt;
        private Label numFactureLbl;
        private Panel panel3;
        private Label tttcLbl;
        private Label timbreLbl;
        private Label label8;
        private Label label9;
        private Label ttvaLbl;
        private Label thtLbl;
        private Label label10;
        private Label label7;
        private Button button2;
        private TextBox idTxt;
        private Label label11;
        private ComboBox tvaCbx;
        private Label tvaValueLbl;
        private ComboBox timbreCbx;
        private Label label12;
        private ComboBox typeCbx;
        private TextBox projetsTxt;
        private Label label1;
        private TextBox bcTxt;
        private Label label13;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn qte;
        private DataGridViewTextBoxColumn designation;
        private DataGridViewTextBoxColumn unite;
        private DataGridViewTextBoxColumn puht;
        private DataGridViewTextBoxColumn tva;
        private DataGridViewTextBoxColumn ptht;
        private DataGridViewTextBoxColumn puht_h;
        private DataGridViewTextBoxColumn ptht_h;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button menuBtn;
    }
}