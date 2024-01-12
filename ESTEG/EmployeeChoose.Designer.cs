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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            employeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            employeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeList.Columns.AddRange(new DataGridViewColumn[] { id, nomPrenom, choose });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            employeeList.DefaultCellStyle = dataGridViewCellStyle5;
            employeeList.EnableHeadersVisualStyles = false;
            employeeList.Location = new Point(12, 13);
            employeeList.Margin = new Padding(3, 4, 3, 4);
            employeeList.Name = "employeeList";
            employeeList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            employeeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            employeeList.RowHeadersWidth = 51;
            employeeList.RowTemplate.Height = 35;
            employeeList.Size = new Size(735, 414);
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
            ClientSize = new Size(759, 440);
            Controls.Add(employeeList);
            MaximumSize = new Size(777, 487);
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