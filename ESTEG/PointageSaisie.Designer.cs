namespace ESTEG
{
    partial class PointageSaisie
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
            precenseChk = new CheckBox();
            lieuTxt = new TextBox();
            label4 = new Label();
            label1 = new Label();
            diversTxt = new TextBox();
            avanceTxt = new TextBox();
            label2 = new Label();
            saveBtn = new Button();
            deleteBtn = new Button();
            idTxt = new TextBox();
            dateTxt = new TextBox();
            employeeIdTxt = new TextBox();
            SuspendLayout();
            // 
            // precenseChk
            // 
            precenseChk.AutoSize = true;
            precenseChk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            precenseChk.Location = new Point(12, 12);
            precenseChk.Name = "precenseChk";
            precenseChk.Size = new Size(105, 32);
            precenseChk.TabIndex = 0;
            precenseChk.Text = "Present";
            precenseChk.UseVisualStyleBackColor = true;
            // 
            // lieuTxt
            // 
            lieuTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lieuTxt.Location = new Point(12, 158);
            lieuTxt.Margin = new Padding(3, 4, 3, 4);
            lieuTxt.Multiline = true;
            lieuTxt.Name = "lieuTxt";
            lieuTxt.Size = new Size(531, 80);
            lieuTxt.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 126);
            label4.Name = "label4";
            label4.Size = new Size(51, 28);
            label4.TabIndex = 13;
            label4.Text = "Lieu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 242);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 15;
            label1.Text = "Divers";
            // 
            // diversTxt
            // 
            diversTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            diversTxt.Location = new Point(12, 274);
            diversTxt.Margin = new Padding(3, 4, 3, 4);
            diversTxt.Multiline = true;
            diversTxt.Name = "diversTxt";
            diversTxt.Size = new Size(531, 80);
            diversTxt.TabIndex = 14;
            // 
            // avanceTxt
            // 
            avanceTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            avanceTxt.Location = new Point(12, 82);
            avanceTxt.Margin = new Padding(3, 4, 3, 4);
            avanceTxt.Name = "avanceTxt";
            avanceTxt.Size = new Size(201, 38);
            avanceTxt.TabIndex = 16;
            avanceTxt.KeyPress += avanceTxt_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 17;
            label2.Text = "Avance";
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Image = Properties.Resources.icons8_save_25;
            saveBtn.ImageAlign = ContentAlignment.MiddleLeft;
            saveBtn.Location = new Point(609, 5);
            saveBtn.Margin = new Padding(3, 4, 3, 4);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(205, 61);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "SAUVGARDER";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.Image = Properties.Resources.icons8_delete_25;
            deleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteBtn.Location = new Point(609, 74);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(205, 61);
            deleteBtn.TabIndex = 19;
            deleteBtn.Text = "SUPPRIMER";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // idTxt
            // 
            idTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            idTxt.Location = new Point(769, 325);
            idTxt.Margin = new Padding(3, 4, 3, 4);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(45, 38);
            idTxt.TabIndex = 20;
            idTxt.Visible = false;
            // 
            // dateTxt
            // 
            dateTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTxt.Location = new Point(560, 325);
            dateTxt.Margin = new Padding(3, 4, 3, 4);
            dateTxt.Name = "dateTxt";
            dateTxt.Size = new Size(152, 38);
            dateTxt.TabIndex = 21;
            dateTxt.Visible = false;
            // 
            // employeeIdTxt
            // 
            employeeIdTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            employeeIdTxt.Location = new Point(718, 325);
            employeeIdTxt.Margin = new Padding(3, 4, 3, 4);
            employeeIdTxt.Name = "employeeIdTxt";
            employeeIdTxt.Size = new Size(45, 38);
            employeeIdTxt.TabIndex = 22;
            employeeIdTxt.Visible = false;
            // 
            // PointageSaisie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 367);
            Controls.Add(employeeIdTxt);
            Controls.Add(dateTxt);
            Controls.Add(idTxt);
            Controls.Add(deleteBtn);
            Controls.Add(saveBtn);
            Controls.Add(label2);
            Controls.Add(avanceTxt);
            Controls.Add(label1);
            Controls.Add(diversTxt);
            Controls.Add(label4);
            Controls.Add(lieuTxt);
            Controls.Add(precenseChk);
            MaximumSize = new Size(835, 414);
            Name = "PointageSaisie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PointageSaisie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox precenseChk;
        private TextBox lieuTxt;
        private Label label4;
        private Label label1;
        private TextBox diversTxt;
        private TextBox avanceTxt;
        private Label label2;
        private Button saveBtn;
        private Button deleteBtn;
        private TextBox idTxt;
        private TextBox dateTxt;
        private TextBox employeeIdTxt;
    }
}