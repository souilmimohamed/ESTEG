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
            SuspendLayout();
            // 
            // qtyTxt
            // 
            qtyTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            qtyTxt.Location = new Point(6, 43);
            qtyTxt.Margin = new Padding(3, 4, 3, 4);
            qtyTxt.Name = "qtyTxt";
            qtyTxt.Size = new Size(150, 34);
            qtyTxt.TabIndex = 0;
            qtyTxt.KeyPress += qtyTxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 1;
            label1.Text = "Quantite";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(167, 12);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 3;
            label2.Text = "Designation";
            // 
            // designationTxt
            // 
            designationTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            designationTxt.Location = new Point(163, 43);
            designationTxt.Margin = new Padding(3, 4, 3, 4);
            designationTxt.Multiline = true;
            designationTxt.Name = "designationTxt";
            designationTxt.Size = new Size(458, 189);
            designationTxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(629, 12);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 5;
            label3.Text = "PUHT";
            // 
            // puhtTxt
            // 
            puhtTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            puhtTxt.Location = new Point(625, 43);
            puhtTxt.Margin = new Padding(3, 4, 3, 4);
            puhtTxt.Name = "puhtTxt";
            puhtTxt.Size = new Size(161, 34);
            puhtTxt.TabIndex = 4;
            puhtTxt.KeyPress += puhtTxt_KeyPress;
            // 
            // validateBtn
            // 
            validateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            validateBtn.Image = Properties.Resources.icons8_check_25;
            validateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            validateBtn.Location = new Point(625, 188);
            validateBtn.Margin = new Padding(3, 4, 3, 4);
            validateBtn.Name = "validateBtn";
            validateBtn.Size = new Size(161, 44);
            validateBtn.TabIndex = 11;
            validateBtn.Text = "Valider";
            validateBtn.UseVisualStyleBackColor = true;
            validateBtn.Click += validateBtn_Click;
            // 
            // idTxt
            // 
            idTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.Location = new Point(6, 205);
            idTxt.Margin = new Padding(3, 4, 3, 4);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(39, 34);
            idTxt.TabIndex = 12;
            idTxt.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(625, 88);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 14;
            label6.Text = "Unite";
            // 
            // uniteCbx
            // 
            uniteCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            uniteCbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uniteCbx.FormattingEnabled = true;
            uniteCbx.Items.AddRange(new object[] { "Unite", "ENS", "ML", "M²", "M³" });
            uniteCbx.Location = new Point(625, 120);
            uniteCbx.Margin = new Padding(3, 4, 3, 4);
            uniteCbx.Name = "uniteCbx";
            uniteCbx.Size = new Size(161, 36);
            uniteCbx.TabIndex = 15;
            // 
            // Article
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(798, 245);
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
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(973, 292);
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
    }
}