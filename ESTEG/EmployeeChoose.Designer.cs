namespace ESTEG
{
    partial class EmployeeChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeChoose));
            employeeList = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nomPrenom = new DataGridViewTextBoxColumn();
            choose = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)employeeList).BeginInit();
            SuspendLayout();
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
            employeeList.Columns.AddRange(new DataGridViewColumn[] { id, nomPrenom, choose });
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
            employeeList.Location = new Point(12, 13);
            employeeList.Margin = new Padding(3, 4, 3, 4);
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
            employeeList.Size = new Size(583, 414);
            employeeList.TabIndex = 18;
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
            // choose
            // 
            choose.HeaderText = "CHOISIR";
            choose.Image = (Image)resources.GetObject("choose.Image");
            choose.ImageLayout = DataGridViewImageCellLayout.Zoom;
            choose.MinimumWidth = 6;
            choose.Name = "choose";
            choose.ReadOnly = true;
            choose.Resizable = DataGridViewTriState.True;
            choose.SortMode = DataGridViewColumnSortMode.Automatic;
            choose.Width = 125;
            // 
            // EmployeeChoose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 440);
            Controls.Add(employeeList);
            MaximumSize = new Size(625, 487);
            Name = "EmployeeChoose";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeChoose";
            Load += EmployeeChoose_Load;
            ((System.ComponentModel.ISupportInitialize)employeeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView employeeList;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nomPrenom;
        private DataGridViewImageColumn choose;
    }
}