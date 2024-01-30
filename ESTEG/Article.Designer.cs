namespace ESTEG
{
    partial class Article
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
            qtyTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            designationTxt = new TextBox();
            label3 = new Label();
            puhtTxt = new TextBox();
            validateBtn = new Button();
            idTxt = new TextBox();
            label6 = new Label();
            uniteCbx = new ComboBox();
            rowTxt = new TextBox();
            SuspendLayout();
            // 
            // qtyTxt
            // 
            qtyTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            qtyTxt.Location = new Point(10, 69);
            qtyTxt.Margin = new Padding(5, 6, 5, 6);
            qtyTxt.Name = "qtyTxt";
            qtyTxt.Size = new Size(241, 50);
            qtyTxt.TabIndex = 0;
            qtyTxt.KeyPress += qtyTxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 45);
            label1.TabIndex = 1;
            label1.Text = "Quantite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(271, 19);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 45);
            label2.TabIndex = 3;
            label2.Text = "Designation";
            // 
            // designationTxt
            // 
            designationTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            designationTxt.Location = new Point(265, 69);
            designationTxt.Margin = new Padding(5, 6, 5, 6);
            designationTxt.Multiline = true;
            designationTxt.Name = "designationTxt";
            designationTxt.Size = new Size(742, 300);
            designationTxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1022, 19);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 45);
            label3.TabIndex = 5;
            label3.Text = "PUHT";
            // 
            // puhtTxt
            // 
            puhtTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            puhtTxt.Location = new Point(1016, 69);
            puhtTxt.Margin = new Padding(5, 6, 5, 6);
            puhtTxt.Name = "puhtTxt";
            puhtTxt.Size = new Size(259, 50);
            puhtTxt.TabIndex = 4;
            puhtTxt.KeyPress += puhtTxt_KeyPress;
            // 
            // validateBtn
            // 
            validateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            validateBtn.Image = Properties.Resources.icons8_check_25;
            validateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            validateBtn.Location = new Point(1016, 301);
            validateBtn.Margin = new Padding(5, 6, 5, 6);
            validateBtn.Name = "validateBtn";
            validateBtn.Size = new Size(262, 70);
            validateBtn.TabIndex = 11;
            validateBtn.Text = "Valider";
            validateBtn.UseVisualStyleBackColor = true;
            validateBtn.Click += validateBtn_Click;
            // 
            // idTxt
            // 
            idTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.Location = new Point(10, 328);
            idTxt.Margin = new Padding(5, 6, 5, 6);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(61, 50);
            idTxt.TabIndex = 12;
            idTxt.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1016, 141);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 45);
            label6.TabIndex = 14;
            label6.Text = "Unite";
            // 
            // uniteCbx
            // 
            uniteCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            uniteCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uniteCbx.FormattingEnabled = true;
            uniteCbx.Items.AddRange(new object[] { "Unite", "ENS", "ML", "M²", "M³" });
            uniteCbx.Location = new Point(1016, 192);
            uniteCbx.Margin = new Padding(5, 6, 5, 6);
            uniteCbx.Name = "uniteCbx";
            uniteCbx.Size = new Size(259, 53);
            uniteCbx.TabIndex = 15;
            // 
            // rowTxt
            // 
            rowTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rowTxt.Location = new Point(83, 328);
            rowTxt.Margin = new Padding(5, 6, 5, 6);
            rowTxt.Name = "rowTxt";
            rowTxt.Size = new Size(61, 50);
            rowTxt.TabIndex = 16;
            rowTxt.Visible = false;
            // 
            // Article
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1297, 393);
            Controls.Add(rowTxt);
            Controls.Add(uniteCbx);
            Controls.Add(label6);
            Controls.Add(idTxt);
            Controls.Add(validateBtn);
            Controls.Add(label3);
            Controls.Add(puhtTxt);
            Controls.Add(label2);
            Controls.Add(designationTxt);
            Controls.Add(label1);
            Controls.Add(qtyTxt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximumSize = new Size(1323, 464);
            Name = "Article";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Article";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox qtyTxt;
        private Label label1;
        private Label label2;
        private TextBox designationTxt;
        private Label label3;
        private TextBox puhtTxt;
        private Button validateBtn;
        private TextBox idTxt;
        private Label label6;
        private ComboBox uniteCbx;
        private TextBox rowTxt;
    }
}