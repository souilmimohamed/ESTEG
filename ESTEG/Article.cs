

using Infrastructure.Data.Entities;

namespace ESTEG
{
    public partial class Article : Form
    {
        public Article()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void validateBtn_Click(object sender, EventArgs e)
        {
            if (qtyTxt.Text.StringIsNullOrEmptyOrWhiteSpaces() || designationTxt.Text.StringIsNullOrEmptyOrWhiteSpaces() || uniteCbx.Text.StringIsNullOrEmptyOrWhiteSpaces()
                || puhtTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
            {
                MessageBox.Show(this, "Veullier saisir tout les champs.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var puht = Convert.ToInt32(puhtTxt.Text);
                var qty = Convert.ToInt32(qtyTxt.Text);
                var article = new Infrastructure.Data.Entities.ArticleEntity
                {
                    Quantite = Convert.ToInt32(qtyTxt.Text),
                    Designation = designationTxt.Text,
                    PTHT = (puht * qty),
                    PUHT = Convert.ToInt32(puhtTxt.Text),
                    Unite = uniteCbx.Text,
                };
                Facture facture = (Facture)Application.OpenForms["Facture"];
                if (idTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
                {
                    facture.SetArticle(article);
                    InitAll();
                }
                else
                {
                    article.Id = Convert.ToInt32(idTxt.Text);
                    facture.updateArticle(article);
                    this.Close();
                }

            }
        }
        private void qtyTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #region Helpers
        public void setArticle(ArticleEntity article)
        {
            qtyTxt.Text = article.Quantite.ToString();
            designationTxt.Text = article.Designation;
            puhtTxt.Text = article.PUHT.ToString();
            uniteCbx.Text = article.Unite;
            idTxt.Text = article.Id.ToString();
        }
        public void InitAll()
        {
            qtyTxt.Clear();
            designationTxt.Clear();
            puhtTxt.Clear();
            uniteCbx.SelectedIndex = -1;
        }
        #endregion
    }
}