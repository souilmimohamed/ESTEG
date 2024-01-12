namespace ESTEG
{
    public partial class PointageSaisie : Form
    {
        public PointageSaisie()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!precenseChk.Checked || lieuTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
            {
                MessageBox.Show(this, "Veullier marquer la presence et indiquer le lieu", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var split = dateTxt.Text.Split("/");
                var jour = Convert.ToInt32(split[0]);
                var mois = Convert.ToInt32(split[1]);
                var annee = Convert.ToInt32(split[2]);
                var employeeId = Convert.ToInt32(employeeIdTxt.Text); value:
                var avance = avanceTxt.Text.StringIsNullOrEmptyOrWhiteSpaces() ? 0 : Convert.ToInt32(avanceTxt.Text);
                if (idTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
                {
                    Infrastructure.Data.Access.PointageAccess.Insert(new Infrastructure.Data.Entities.PointageEntity
                    {
                        Mois = mois,
                        Annee = annee,
                        Jour = jour,
                        Avance = avance,
                        Divers = diversTxt.Text,
                        IdEmployee = employeeId,
                        Lieu = lieuTxt.Text,
                        Presence = precenseChk.Checked,
                    });
                }
                else
                {
                    var id = Convert.ToInt32(idTxt.Text);
                    var pointage = Infrastructure.Data.Access.PointageAccess.Get(id);
                    pointage.Lieu = lieuTxt.Text;
                    pointage.Divers = diversTxt.Text;
                    pointage.Avance = avanceTxt.Text.StringIsNullOrEmptyOrWhiteSpaces() ? 0 : Convert.ToInt32(avanceTxt.Text);
                    Infrastructure.Data.Access.PointageAccess.Update(pointage);
                }
                Pointage facture = (Pointage)Application.OpenForms["Pointage"];
                facture.SetPointage(employeeId);
                this.Close();
            }
        }
        #region Helpers
        public void SetPointage(int pointageId, int employeeId)
        {
            var pointage = Infrastructure.Data.Access.PointageAccess.Get(pointageId);
            precenseChk.Checked = pointage.Presence;
            avanceTxt.Text = pointage.Avance.ToString();
            lieuTxt.Text = pointage.Lieu;
            diversTxt.Text = pointage.Divers;
            idTxt.Text = pointage.Id.ToString();
            employeeIdTxt.Text = employeeId.ToString();
            dateTxt.Text = $"{pointage.Jour}/{pointage.Mois}/{pointage.Annee}";
        }
        public void SetInfo(int day, int month, int year, int employeeId)
        {
            dateTxt.Text = $"{day}/{month}/{year}";
            employeeIdTxt.Text = employeeId.ToString();
        }
        #endregion

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (idTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
                MessageBox.Show(this, "Pointage inexsistant", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var id = Convert.ToInt32(idTxt.Text);
                var employeeId = Convert.ToInt32(employeeIdTxt.Text); value:
                Infrastructure.Data.Access.PointageAccess.Delete(id);
                Pointage facture = (Pointage)Application.OpenForms["Pointage"];
                facture.SetPointage(employeeId);
                this.Close();
            }
        }

        private void avanceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
