using System.Globalization;
using System.Xml.Linq;

namespace ESTEG
{
    public partial class Pointage : Form
    {
        public Pointage()
        {
            InitializeComponent();
            FillLists();
        }
        private void listEmployeeBtn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.ShowDialog();
        }
        private void chooseEmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeChoose choose = new EmployeeChoose();
            choose.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (idText.Text.StringIsNullOrEmptyOrWhiteSpaces())
                MessageBox.Show(this, "Choisissez un employee pour afficher le pointage", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var id = Convert.ToInt32(idText.Text);
                var name = employeeNomLbl.Text;
                SetPointage(id);
            }
        }
        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            menu.Show();
        }
        private void ficheDePaieBtn_Click(object sender, EventArgs e)
        {
            if (idText.Text.StringIsNullOrEmptyOrWhiteSpaces())
                MessageBox.Show(this, "Choisissez un employee pour afficher le pointage", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var idEmployee = Convert.ToInt32(idText.Text);
                var mois = Convert.ToInt32(moisCbx.SelectedValue);
                var annee = Convert.ToInt32(anneeCbx.SelectedValue);

                var employee = Infrastructure.Data.Access.EmployeeAccess.Get(idEmployee);
                var pointage = Infrastructure.Data.Access.PointageAccess.GetByEmployeeIdAndYear(idEmployee, annee);
                pointage = pointage?.Where(p => p.Mois == mois).ToList();

                var jourTravaille = pointage.Where(p => p.Presence)?.Count() ?? 0;
                var totalParMois = jourTravaille * employee.TarifJounalier;
                var totalAvance = pointage?.Sum(p => p.Avance) ?? 0;
                var totalAPayer = totalParMois - totalAvance;
                var culture = CultureInfo.CreateSpecificCulture("fr");
                var sommaire = new Infrastructure.Data.Entities.PointageSommaire
                {
                    Mois = culture.DateTimeFormat.GetMonthName(mois),
                    Annee = annee,
                    NombreJoursTravailee = pointage.Where(p => p.Presence)?.Count() ?? 0,
                    NomPrenom = employee.NomPrenom,
                    TarifJournalier = employee.TarifJounalier,
                    TotalAPayer = totalAPayer,
                    TotalAvance = totalAvance,
                    TotalParMois = totalParMois,
                };
                var details = pointage?.Select(p => new Infrastructure.Data.Entities.PointageDetails
                {
                    Avance = p.Avance,
                    Date = $"{(p.Jour <= 9 ? $"0{p.Jour}" : p.Jour)}/{(p.Mois <= 9 ? $"0{p.Mois}" : p.Mois)}/{p.Annee}",
                    Divers = p.Divers,
                    Lieu = p.Lieu,
                }).ToList();

                var report = new Infrastructure.Reportig.FastReport();
                var file = report.GeneratePointageReport(sommaire, details);

                Document doc = new Document();
                doc.SetDocument(file);
                doc.ShowDialog();
            }
        }
        #region Helpers
        public void FillLists()
        {
            //years
            var pointages = Infrastructure.Data.Access.PointageAccess.Get();
            var years = new List<int>();
            if (pointages != null && pointages.Count > 0)
            {
                years = pointages.Select(p => p.Annee).Distinct().ToList();
            }
            if (years == null || years.Count == 0)
                years.Add(DateTime.Now.Year);
            else
                if (!years.Contains(DateTime.Now.Year))
                years.Add(DateTime.Now.Year);

            anneeCbx.DataSource = years
                      .Select(y => new KeyValuePair<int, int>(y, y))
                      .ToList();
            anneeCbx.ValueMember = "Key";
            anneeCbx.DisplayMember = "Value";

            anneeCbx.SelectedValue = DateTime.Now.Year;
            //months
            var months = new List<KeyValuePair<int, string>>();
            var culture = CultureInfo.CreateSpecificCulture("fr");
            for (int i = 1; i <= 12; i++)
            {
                months.Add(new KeyValuePair<int, string>(i, culture.DateTimeFormat.GetMonthName(i)));
            }
            moisCbx.DataSource = months;
            moisCbx.ValueMember = "Key";
            moisCbx.DisplayMember = "Value";

            moisCbx.SelectedValue = DateTime.Now.Month;
        }
        public void SetPointage(int id)
        {
            var employee = Infrastructure.Data.Access.EmployeeAccess.Get(id);
            idText.Text = employee.Id.ToString();
            employeeNomLbl.Text = employee.NomPrenom;
            var year = Convert.ToInt32(anneeCbx.SelectedValue);
            var month = Convert.ToInt32(moisCbx.SelectedValue);
            var pointage = Infrastructure.Data.Access.PointageAccess.GetByEmployeeIdAndYear(id, year);
            //
            var monthDays = DateTime.DaysInMonth(year, month);
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i <= monthDays; i++)
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var point = pointage?.FirstOrDefault(x => x.Jour == i && x.Mois == month && x.Annee == year);
                var redImage = Image.FromFile(Path.Combine(basePath, "Images/red.png"));
                var greenImage = Image.FromFile(Path.Combine(basePath, "Images/green.png"));
                int day = i;
                //
                Button button = new Button();
                button.Text = $"{i}{(point != null && point.Avance > 0 ? $"\n avance +{point.Avance}" : "")}";
                button.Width = 120;
                button.Height = 70;
                button.Font = new Font(button.Font.Name, button.Font.Size, FontStyle.Bold);
                button.Image = point != null ? greenImage : redImage;
                button.ImageAlign = ContentAlignment.TopLeft;
                this.flowLayoutPanel1.Controls.Add(button);
                button.Click += (e, s) =>
                {
                    PointageSaisie saisie = new PointageSaisie();
                    if (point != null)
                        saisie.SetPointage(point.Id, employee.Id);
                    else
                        saisie.SetInfo(day, month, year, employee.Id);
                    saisie.ShowDialog();
                };
                //
                var pointageMois = pointage?.Where(p => p.Annee == year && p.Mois == month).ToList();
                var jourTravaille = pointageMois?.Count ?? 0;
                var totalMois = employee.TarifJounalier * jourTravaille;
                var totalAvance = pointageMois?.Sum(p => p.Avance) ?? 0;
                var totalAPayer = totalMois - totalAvance;
                tarifLbl.Text = employee.TarifJounalier.ToString();
                totalAvanceLbl.Text = totalAvance.ToString("#,#");
                totalMoisLbl.Text = (totalMois).ToString("#,#");
                joursTravalieeLbl.Text = jourTravaille.ToString();
                totalApayerLbl.Text = totalAPayer.ToString("#,#");

                if (totalAPayer < 0)
                    totalApayerLbl.BackColor = Color.Red;
                else
                    totalApayerLbl.BackColor = Color.Green;
                totalApayerLbl.ForeColor = Color.White;
            }
        }
        #endregion
    }
}