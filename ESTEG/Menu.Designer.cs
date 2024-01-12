namespace ESTEG
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pictureBox1 = new PictureBox();
            devisFactireBtn = new Button();
            employeeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(489, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // devisFactireBtn
            // 
            devisFactireBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            devisFactireBtn.Image = (Image)resources.GetObject("devisFactireBtn.Image");
            devisFactireBtn.ImageAlign = ContentAlignment.MiddleLeft;
            devisFactireBtn.Location = new Point(3, 149);
            devisFactireBtn.Margin = new Padding(3, 4, 3, 4);
            devisFactireBtn.Name = "devisFactireBtn";
            devisFactireBtn.Size = new Size(489, 74);
            devisFactireBtn.TabIndex = 5;
            devisFactireBtn.Text = "DEVIS/FACTURE";
            devisFactireBtn.UseVisualStyleBackColor = true;
            devisFactireBtn.Click += devisFactireBtn_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            employeeBtn.Image = (Image)resources.GetObject("employeeBtn.Image");
            employeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            employeeBtn.Location = new Point(3, 232);
            employeeBtn.Margin = new Padding(3, 4, 3, 4);
            employeeBtn.MaximumSize = new Size(489, 74);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(489, 74);
            employeeBtn.TabIndex = 6;
            employeeBtn.Text = "EMPLOYEE";
            employeeBtn.UseVisualStyleBackColor = true;
            employeeBtn.Click += employeeBtn_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 311);
            Controls.Add(employeeBtn);
            Controls.Add(devisFactireBtn);
            Controls.Add(pictureBox1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button devisFactireBtn;
        private Button employeeBtn;
    }
}