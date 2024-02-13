namespace ESTEG
{
    partial class Pointage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pointage));
            pictureBox1 = new PictureBox();
            listEmployeeBtn = new Button();
            moisCbx = new ComboBox();
            label1 = new Label();
            anneeCbx = new ComboBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label9 = new Label();
            totalMoisTitleLbl = new Label();
            label4 = new Label();
            totalAvanceLbl = new Label();
            joursTravalieeLbl = new Label();
            totalMoisLbl = new Label();
            chooseEmployeeBtn = new Button();
            employeeNomLbl = new Label();
            idText = new TextBox();
            button1 = new Button();
            label5 = new Label();
            tarifLbl = new Label();
            totalApayerLbl = new Label();
            totalApayerTitleLbl = new Label();
            panel1 = new Panel();
            menuBtn = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            ficheDePaieBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 0);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(481, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listEmployeeBtn
            // 
            listEmployeeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listEmployeeBtn.Image = (Image)resources.GetObject("listEmployeeBtn.Image");
            listEmployeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            listEmployeeBtn.Location = new Point(5, 254);
            listEmployeeBtn.Margin = new Padding(5, 6, 5, 6);
            listEmployeeBtn.Name = "listEmployeeBtn";
            listEmployeeBtn.Size = new Size(481, 120);
            listEmployeeBtn.TabIndex = 5;
            listEmployeeBtn.Text = "LIST EMPLOYEE";
            listEmployeeBtn.UseVisualStyleBackColor = true;
            listEmployeeBtn.Click += listEmployeeBtn_Click;
            // 
            // moisCbx
            // 
            moisCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            moisCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            moisCbx.FormattingEnabled = true;
            moisCbx.Location = new Point(921, 173);
            moisCbx.Margin = new Padding(5, 6, 5, 6);
            moisCbx.Name = "moisCbx";
            moisCbx.Size = new Size(402, 53);
            moisCbx.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(921, 122);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 45);
            label1.TabIndex = 16;
            label1.Text = "MOIS:";
            // 
            // anneeCbx
            // 
            anneeCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            anneeCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            anneeCbx.FormattingEnabled = true;
            anneeCbx.Location = new Point(507, 173);
            anneeCbx.Margin = new Padding(5, 6, 5, 6);
            anneeCbx.Name = "anneeCbx";
            anneeCbx.Size = new Size(402, 53);
            anneeCbx.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(507, 122);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 45);
            label2.TabIndex = 18;
            label2.Text = "ANNEE";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(496, 254);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1513, 1102);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(11, 134);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(251, 45);
            label9.TabIndex = 21;
            label9.Text = "TOTAL AVANCE";
            // 
            // totalMoisTitleLbl
            // 
            totalMoisTitleLbl.AutoSize = true;
            totalMoisTitleLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalMoisTitleLbl.Location = new Point(11, 70);
            totalMoisTitleLbl.Margin = new Padding(5, 0, 5, 0);
            totalMoisTitleLbl.Name = "totalMoisTitleLbl";
            totalMoisTitleLbl.Size = new Size(209, 45);
            totalMoisTitleLbl.TabIndex = 22;
            totalMoisTitleLbl.Text = "TOTAL MOIS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(11, 11);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(292, 45);
            label4.TabIndex = 23;
            label4.Text = "JOURS TRAVAILEE";
            // 
            // totalAvanceLbl
            // 
            totalAvanceLbl.AutoSize = true;
            totalAvanceLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalAvanceLbl.Location = new Point(348, 134);
            totalAvanceLbl.Margin = new Padding(5, 0, 5, 0);
            totalAvanceLbl.Name = "totalAvanceLbl";
            totalAvanceLbl.Size = new Size(38, 45);
            totalAvanceLbl.TabIndex = 24;
            totalAvanceLbl.Text = "0";
            // 
            // joursTravalieeLbl
            // 
            joursTravalieeLbl.AutoSize = true;
            joursTravalieeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            joursTravalieeLbl.Location = new Point(348, 11);
            joursTravalieeLbl.Margin = new Padding(5, 0, 5, 0);
            joursTravalieeLbl.Name = "joursTravalieeLbl";
            joursTravalieeLbl.Size = new Size(38, 45);
            joursTravalieeLbl.TabIndex = 25;
            joursTravalieeLbl.Text = "0";
            // 
            // totalMoisLbl
            // 
            totalMoisLbl.AutoSize = true;
            totalMoisLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalMoisLbl.Location = new Point(348, 70);
            totalMoisLbl.Margin = new Padding(5, 0, 5, 0);
            totalMoisLbl.Name = "totalMoisLbl";
            totalMoisLbl.Size = new Size(38, 45);
            totalMoisLbl.TabIndex = 26;
            totalMoisLbl.Text = "0";
            // 
            // chooseEmployeeBtn
            // 
            chooseEmployeeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chooseEmployeeBtn.Image = (Image)resources.GetObject("chooseEmployeeBtn.Image");
            chooseEmployeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            chooseEmployeeBtn.Location = new Point(507, 10);
            chooseEmployeeBtn.Margin = new Padding(5, 6, 5, 6);
            chooseEmployeeBtn.Name = "chooseEmployeeBtn";
            chooseEmployeeBtn.Size = new Size(481, 106);
            chooseEmployeeBtn.TabIndex = 28;
            chooseEmployeeBtn.Text = "CHOISIR EMPLOYEE";
            chooseEmployeeBtn.UseVisualStyleBackColor = true;
            chooseEmployeeBtn.Click += chooseEmployeeBtn_Click;
            // 
            // employeeNomLbl
            // 
            employeeNomLbl.AutoSize = true;
            employeeNomLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            employeeNomLbl.Location = new Point(1180, 40);
            employeeNomLbl.Margin = new Padding(5, 0, 5, 0);
            employeeNomLbl.Name = "employeeNomLbl";
            employeeNomLbl.Size = new Size(47, 45);
            employeeNomLbl.TabIndex = 29;
            employeeNomLbl.Text = "...";
            // 
            // idText
            // 
            idText.Location = new Point(2041, 0);
            idText.Margin = new Padding(5);
            idText.Name = "idText";
            idText.Size = new Size(58, 39);
            idText.TabIndex = 30;
            idText.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.icons8_check_25;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1476, 144);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(268, 86);
            button1.TabIndex = 31;
            button1.Text = "VALIDER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1636, 40);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 45);
            label5.TabIndex = 32;
            label5.Text = "TARIF";
            // 
            // tarifLbl
            // 
            tarifLbl.AutoSize = true;
            tarifLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tarifLbl.Location = new Point(1815, 40);
            tarifLbl.Margin = new Padding(5, 0, 5, 0);
            tarifLbl.Name = "tarifLbl";
            tarifLbl.Size = new Size(38, 45);
            tarifLbl.TabIndex = 33;
            tarifLbl.Text = "0";
            // 
            // totalApayerLbl
            // 
            totalApayerLbl.AutoSize = true;
            totalApayerLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalApayerLbl.Location = new Point(346, 194);
            totalApayerLbl.Margin = new Padding(5, 0, 5, 0);
            totalApayerLbl.Name = "totalApayerLbl";
            totalApayerLbl.Size = new Size(38, 45);
            totalApayerLbl.TabIndex = 35;
            totalApayerLbl.Text = "0";
            // 
            // totalApayerTitleLbl
            // 
            totalApayerTitleLbl.AutoSize = true;
            totalApayerTitleLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalApayerTitleLbl.Location = new Point(10, 194);
            totalApayerTitleLbl.Margin = new Padding(5, 0, 5, 0);
            totalApayerTitleLbl.Name = "totalApayerTitleLbl";
            totalApayerTitleLbl.Size = new Size(254, 45);
            totalApayerTitleLbl.TabIndex = 34;
            totalApayerTitleLbl.Text = "TOTAL A PAYER";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(totalApayerLbl);
            panel1.Controls.Add(totalMoisTitleLbl);
            panel1.Controls.Add(totalApayerTitleLbl);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(totalAvanceLbl);
            panel1.Controls.Add(joursTravalieeLbl);
            panel1.Controls.Add(totalMoisLbl);
            panel1.Location = new Point(1474, 1367);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 268);
            panel1.TabIndex = 36;
            // 
            // menuBtn
            // 
            menuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuBtn.Image = (Image)resources.GetObject("menuBtn.Image");
            menuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            menuBtn.Location = new Point(5, 387);
            menuBtn.Margin = new Padding(5, 6, 5, 6);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(481, 122);
            menuBtn.TabIndex = 37;
            menuBtn.Text = "MENU";
            menuBtn.UseVisualStyleBackColor = true;
            menuBtn.Click += menuBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.green;
            pictureBox2.Location = new Point(1771, 144);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 37);
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1805, 136);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 45);
            label3.TabIndex = 39;
            label3.Text = "Present";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1805, 186);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(125, 45);
            label6.TabIndex = 41;
            label6.Text = "Absent";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1771, 194);
            pictureBox3.Margin = new Padding(5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 37);
            pictureBox3.TabIndex = 40;
            pictureBox3.TabStop = false;
            // 
            // ficheDePaieBtn
            // 
            ficheDePaieBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ficheDePaieBtn.Image = Properties.Resources.icons8_estimate_50;
            ficheDePaieBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ficheDePaieBtn.Location = new Point(496, 1367);
            ficheDePaieBtn.Margin = new Padding(5, 6, 5, 6);
            ficheDePaieBtn.Name = "ficheDePaieBtn";
            ficheDePaieBtn.Size = new Size(431, 96);
            ficheDePaieBtn.TabIndex = 42;
            ficheDePaieBtn.Text = "FICHE DE PAIE";
            ficheDePaieBtn.UseVisualStyleBackColor = true;
            ficheDePaieBtn.Click += ficheDePaieBtn_Click;
            // 
            // Pointage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2018, 1743);
            Controls.Add(ficheDePaieBtn);
            Controls.Add(listEmployeeBtn);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(menuBtn);
            Controls.Add(panel1);
            Controls.Add(tarifLbl);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(idText);
            Controls.Add(employeeNomLbl);
            Controls.Add(chooseEmployeeBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(anneeCbx);
            Controls.Add(label2);
            Controls.Add(moisCbx);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(5);
            Name = "Pointage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pointage";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button listEmployeeBtn;
        private ComboBox moisCbx;
        private Label label1;
        private ComboBox anneeCbx;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label9;
        private Label totalMoisTitleLbl;
        private Label label4;
        private Label totalAvanceLbl;
        private Label joursTravalieeLbl;
        private Label totalMoisLbl;
        private Button chooseEmployeeBtn;
        private Label employeeNomLbl;
        private TextBox idText;
        private Button button1;
        private Label label5;
        private Label tarifLbl;
        private Label totalApayerLbl;
        private Label totalApayerTitleLbl;
        private Panel panel1;
        private Button menuBtn;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label6;
        private PictureBox pictureBox3;
        private Button ficheDePaieBtn;
    }
}