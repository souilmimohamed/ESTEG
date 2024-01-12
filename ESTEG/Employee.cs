

namespace ESTEG
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            GetEmployes();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nomPrenomtxt.Text.StringIsNullOrEmptyOrWhiteSpaces() || TarifTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
            {
                MessageBox.Show(this, "Veulliez saisir nom et tarif", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (idTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
                    Infrastructure.Data.Access.EmployeeAccess.Insert(new Infrastructure.Data.Entities.EmployeeEntity
                    {
                        NomPrenom = nomPrenomtxt.Text,
                        TarifJounalier = Convert.ToInt32(TarifTxt.Text)
                    });
                else
                    Infrastructure.Data.Access.EmployeeAccess.Update(new Infrastructure.Data.Entities.EmployeeEntity
                    {
                        Id = Convert.ToInt32(idTxt.Text),
                        NomPrenom = nomPrenomtxt.Text,
                        TarifJounalier = Convert.ToInt32(TarifTxt.Text)
                    });
                GetEmployes();
                nomPrenomtxt.Clear();
                TarifTxt.Clear();
                idTxt.Clear();
            }
        }
        #region Helpers
        public void GetEmployes()
        {
            var employees = Infrastructure.Data.Access.EmployeeAccess.Get();
            employeeList.Rows.Clear();
            employeeList.Refresh();
            foreach (var employee in employees)
            {
                employeeList.Rows.Add(
                    employee.Id,
                    employee.NomPrenom,
                    employee.TarifJounalier.ToString()
                    );
            }
        }
        #endregion
        private void TarifTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void employeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                var row = employeeList.Rows[rowIndex];
                var id = Convert.ToInt32(row.Cells[0].Value);
                if (employeeList.Columns[e.ColumnIndex].Name == "edit")
                {
                    var employee = Infrastructure.Data.Access.EmployeeAccess.Get(id);
                    nomPrenomtxt.Text = employee.NomPrenom;
                    TarifTxt.Text = employee.TarifJounalier.ToString();
                    idTxt.Text = employee.Id.ToString();
                }
                if (employeeList.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult dialogResult = MessageBox.Show(text: "vous etes sure de vouloir supprimer cet employee ?", "VALIDATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Infrastructure.Data.Access.EmployeeAccess.Delete(id);
                        GetEmployes();
                    }
                }
            }
        }
    }
}