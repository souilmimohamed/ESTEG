using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTEG
{
    public partial class EmployeeChoose : Form
    {
        public EmployeeChoose()
        {
            InitializeComponent();
        }

        private void EmployeeChoose_Load(object sender, EventArgs e)
        {
            var employees = Infrastructure.Data.Access.EmployeeAccess.Get();
            employeeList.Rows.Clear();
            employeeList.Refresh();
            foreach (var employee in employees)
            {
                employeeList.Rows.Add(
                    employee.Id,
                    employee.NomPrenom
                    );
            }
        }

        private void employeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                var row = employeeList.Rows[rowIndex];
                var id = Convert.ToInt32(row.Cells[0].Value);
                if (employeeList.Columns[e.ColumnIndex].Name == "choose")
                {
                    var employee = Infrastructure.Data.Access.EmployeeAccess.Get(id);
                    Pointage facture = (Pointage)Application.OpenForms["Pointage"];
                    facture.SetPointage(employee.Id);
                    this.Close();
                }
            }
        }
    }
}
