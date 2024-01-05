using System;
using System.Diagnostics;

namespace ESTEG
{
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
            initAll();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (idTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
                    MessageBox.Show(this, "Veullier charger ou enregistrer le document", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var id = Convert.ToInt32(idTxt.Text);
                    var document = Infrastructure.Data.Access.DocumentAccess.Get(id);
                    var articles = Infrastructure.Data.Access.ArticlesAccess.GetByFactureId(id);
                    var tht = articles.Sum(a => a.PTHT);
                    var split = tvaCbx.Text.Split("%");
                    var tvaValue = Convert.ToInt32(split[0]);
                    var ttva = (int)((tht * tvaValue) / 100);
                    document.THT = tht;
                    document.TTVA = ttva;
                    document.TTTC = tht + ttva + document.Timbre;
                    document.Letters = $"{NumberToWords(tht + ttva + document.Timbre)}";

                    var report = new Infrastructure.Reportig.FastReport();
                    var file = report.GenerateReport(document, articles);
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(file) { UseShellExecute = true };
                    p.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            article.ShowDialog();
        }
        private void facturePositions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                var row = facturePositions.Rows[rowIndex];
                if (facturePositions.Columns[e.ColumnIndex].Name == "edit")
                {
                    var article = new Infrastructure.Data.Entities.ArticleEntity
                    {
                        Id = Convert.ToInt32(row.Cells[0].Value),
                        Quantite = Convert.ToInt32(row.Cells[1].Value),
                        Designation = row.Cells[2].Value.ToString(),
                        Unite = row.Cells[3].Value.ToString(),
                        PUHT = Convert.ToInt32(row.Cells[4].Value.ToString().Replace("\u00A0", "")),
                    };
                    Article art = new Article();
                    art.setArticle(article);
                    art.ShowDialog();
                }
                if (facturePositions.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult dialogResult = MessageBox.Show(text: "vous etes sure de vouloir supprimer cet article ?", "VALIDATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!idTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
                        {
                            var id = Convert.ToInt32(facturePositions.Rows[rowIndex].Cells[0].Value);
                            Infrastructure.Data.Access.ArticlesAccess.Delete(id);
                            MessageBox.Show(this, "Article supprimee.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        facturePositions.Rows.RemoveAt(rowIndex);
                        CalculerTotaux();
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturePositions.Rows.Count <= 0)
                    MessageBox.Show(this, "Veullier saisir des articles", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (typeCbx.Text.StringIsNullOrEmptyOrWhiteSpaces() || timbreCbx.Text.StringIsNullOrEmptyOrWhiteSpaces() || clientTxt.Text.StringIsNullOrEmptyOrWhiteSpaces() || AdresseTxt.Text.StringIsNullOrEmptyOrWhiteSpaces() || mfTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
                    MessageBox.Show(this, "Veullier saisir les champs de l'entete", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (idTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
                        InsertFacture();
                    else
                        UpdateFacture();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listBtn_Click(object sender, EventArgs e)
        {
            FactureList list = new FactureList();
            list.ShowDialog();
        }
        private void tvaCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            tvaValueLbl.Text = tvaCbx.Text;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timbreLbl.Text = timbreCbx.Text;
            CalculerTotaux();
        }
        private void newBtn_Click(object sender, EventArgs e)
        {
            initAll();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!idTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
            {
                DialogResult dialogResult = MessageBox.Show(text: "vous etes sure de vouloir supprimer ce document ?", "VALIDATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTxt.Text);
                    Infrastructure.Data.Access.DocumentAccess.Delete(id);
                    Infrastructure.Data.Access.ArticlesAccess.DeleteByDocument(id);
                    initAll();
                    MessageBox.Show(this, "Document supprimee", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #region Helpers
        public void SetArticle(Infrastructure.Data.Entities.ArticleEntity article)
        {
            facturePositions.Rows.Add(
                article.Id,
                article.Quantite,
                article.Designation,
                article.Unite,
                article.PUHT.ToString("#,#"),
                tvaCbx.Text,
                article.PTHT.ToString("#,#")
                );
            CalculerTotaux();
            if (!idTxt.Text.StringIsNullOrEmptyOrWhiteSpaces())
                Infrastructure.Data.Access.ArticlesAccess.Update(article);
        }
        public void updateArticle(Infrastructure.Data.Entities.ArticleEntity article)
        {
            foreach (DataGridViewRow row in facturePositions.Rows)
            {
                if (row.Cells[0].Value.ToString() == article.Id.ToString())
                {
                    row.Cells[1].Value = article.Quantite;
                    row.Cells[2].Value = article.Designation;
                    row.Cells[3].Value = article.Unite;
                    row.Cells[4].Value = article.PUHT.ToString("#,#");
                    row.Cells[6].Value = (article.PTHT).ToString("#,#");
                }
            }
            CalculerTotaux();
        }
        public void CalculerTotaux()
        {
            if (facturePositions.Rows.Count > 0)
            {
                var tht = 0;
                var split = tvaCbx.Text.Split("%");
                var tvaValue = Convert.ToInt32(split[0]);
                var timbre = Convert.ToInt32(timbreCbx.Text) * 1000;
                for (int i = 0; i <= facturePositions.Rows.Count - 1; i++)
                {
                    var puhtText = facturePositions.Rows[i].Cells[6].Value;
                    puhtText = puhtText.ToString().Replace("\u00A0", "");
                    tht += Convert.ToInt32(puhtText);
                }
                thtLbl.Text = tht.ToString("#,#");
                var tva = (int)((tht * tvaValue) / 100);
                ttvaLbl.Text = tva.ToString("#,#");
                tttcLbl.Text = (tht + tva + timbre).ToString("#,#");
            }
        }
        public void setFacture(int id)
        {
            var document = Infrastructure.Data.Access.DocumentAccess.Get(id);
            var articles = Infrastructure.Data.Access.ArticlesAccess.GetByFactureId(id);

            typeCbx.Text = document.Type.ToUpper();
            numFactureLbl.Text = document.Num;
            dateDte.Value = document.DateDocument;
            clientTxt.Text = document.Client;
            AdresseTxt.Text = document.Adresse;
            mfTxt.Text = document.MF;
            tvaCbx.Text = document.TVA;
            timbreCbx.Text = document.Timbre.ToString();
            facturePositions.Rows.Clear();
            facturePositions.Refresh();
            projetsTxt.Text = document.Projets;
            foreach (var item in articles)
            {
                SetArticle(item);
            }
            CalculerTotaux();
            idTxt.Text = id.ToString();
            var tht = Convert.ToInt32(tttcLbl.Text.Replace("\u00A0", ""));
        }
        public void InsertFacture()
        {
            var num = Infrastructure.Data.Access.DocumentAccess.GetMaxId(Enums.DocumentType.facture.ToString());
            var entete = new Infrastructure.Data.Entities.DocumentEntity
            {
                Type = typeCbx.Text.ToLower(),
                Num = $"{num + 1}/{DateTime.Now.Year}",
                DateDocument = dateDte.Value.Date,
                Client = clientTxt.Text,
                Adresse = AdresseTxt.Text,
                MF = mfTxt.Text,
                TVA = tvaCbx.Text,
                Projets = projetsTxt.Text,
            };
            Infrastructure.Data.Access.DocumentAccess.Insert(entete);
            for (int i = 0; i <= facturePositions.Rows.Count - 1; i++)
            {
                var row = facturePositions.Rows[i];
                var article = new Infrastructure.Data.Entities.ArticleEntity
                {
                    Quantite = Convert.ToInt32(row.Cells[1].Value.ToString()),
                    Designation = row.Cells[2].Value.ToString(),
                    Unite = row.Cells[3].Value.ToString(),
                    PUHT = Convert.ToInt32(row.Cells[4].Value.ToString().Replace("\u00A0", "")),
                    TVA = row.Cells[5].Value.ToString(),
                    PTHT = Convert.ToInt32(row.Cells[6].Value.ToString().Replace("\u00A0", "")),
                    IdFacture = Infrastructure.Data.Access.DocumentAccess.GetMaxId(typeCbx.Text.ToLower()),
                };
                Infrastructure.Data.Access.ArticlesAccess.Insert(article);
                idTxt.Text = Infrastructure.Data.Access.DocumentAccess.GetMaxId(typeCbx.Text.ToLower()).ToString();
            }
            MessageBox.Show(this, "Document enregistree", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateFacture()
        {
            var entete = new Infrastructure.Data.Entities.DocumentEntity
            {
                Type = typeCbx.Text.ToLower(),
                Num = numFactureLbl.Text,
                DateDocument = dateDte.Value.Date,
                Client = clientTxt.Text,
                Adresse = AdresseTxt.Text,
                MF = mfTxt.Text,
                TVA = tvaCbx.Text,
                Id = Convert.ToInt32(idTxt.Text),
                Projets = projetsTxt.Text,
            };
            Infrastructure.Data.Access.DocumentAccess.Update(entete);
            foreach (DataGridViewRow row in facturePositions.Rows)
            {
                var article = new Infrastructure.Data.Entities.ArticleEntity
                {
                    Id = Convert.ToInt32(row.Cells[0].Value.ToString()),
                    Quantite = Convert.ToInt32(row.Cells[1].Value.ToString()),
                    Designation = row.Cells[2].Value.ToString(),
                    Unite = row.Cells[3].Value.ToString(),
                    PUHT = Convert.ToInt32(row.Cells[4].Value.ToString().Replace("\u00A0", "")),
                    TVA = row.Cells[5].Value.ToString(),
                    PTHT = Convert.ToInt32(row.Cells[6].Value.ToString().Replace("\u00A0", "")),
                    IdFacture = Convert.ToInt32(idTxt.Text),
                };
                Infrastructure.Data.Access.ArticlesAccess.Update(article);
            }
            MessageBox.Show(this, "Document modifiee", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void initAll()
        {
            typeCbx.Text = "FACTURE";
            dateDte.Value = DateTime.Now;
            clientTxt.Clear();
            AdresseTxt.Clear();
            mfTxt.Clear();
            thtLbl.Text = "0";
            ttvaLbl.Text = "0";
            timbreLbl.Text = "0";
            tttcLbl.Text = "0";
            timbreCbx.Text = "0";
            tvaCbx.Text = "19%";
            numFactureLbl.Text = $"/{DateTime.Now.Year}";
            facturePositions.Rows.Clear();
            facturePositions.Refresh();
            idTxt.Clear();
            numFactureLbl.Text = $"/{DateTime.Now.Year}";
        }
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "moin " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " mille ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + "dinars ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " cent ";
                number %= 100;
            }

            if (number > 0)
            {
                //if (words != "")
                //    words += "and ";

                var unitsMap = new[] { "zero", "", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf" };
                var tensMap = new[] { "zero", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingts", "quatre-vingt-dix" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }
            if (words.Contains("dinars"))
            {
                var split = words.Split("dinars");
                if (split.Length > 1)
                {
                    if (split[1] == " ")
                        split[1] = "et zero millimes";
                    else
                        split[1] = $"et {split[1]} millimes";
                }
                words = $"{split[0]} dinars {split[1]}";
            }
            return words;
        }
        #endregion
    }
}