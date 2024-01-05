using System.Data;

namespace ESTEG
{
    public partial class FactureList : Form
    {
        public FactureList()
        {
            InitializeComponent();
        }
        private void FactureList_Load(object sender, EventArgs e)
        {
            var list = Infrastructure.Data.Access.DocumentAccess.Get();
            var factures = list.Where(l => l.Type == Enums.DocumentType.facture.ToString()).ToList();
            var devis = list.Where(l => l.Type == Enums.DocumentType.devis.ToString()).ToList();
            FillFactures(factures);
            FillDevis(devis);
        }
        private void factures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                var id = Convert.ToInt32(factures.Rows[rowIndex].Cells[0].Value);
                if (factures.Columns[e.ColumnIndex].Name == "see")
                {
                    Facture facture = (Facture)Application.OpenForms["Facture"];
                    facture.setFacture(id);
                    this.Close();
                }
                if (factures.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult dialogResult = MessageBox.Show(text: "vous etes sure de vouloir supprimer ce document ?", "VALIDATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Infrastructure.Data.Access.DocumentAccess.Delete(id);
                        Infrastructure.Data.Access.ArticlesAccess.DeleteByDocument(id);
                        factures.Rows.Clear();
                        factures.Refresh();
                        FactureList_Load(sender, e);
                        MessageBox.Show(this, "Document supprimee", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void DEVIS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                var id = Convert.ToInt32(DEVIS.Rows[rowIndex].Cells[0].Value);
                if (factures.Columns[e.ColumnIndex].Name == "see")
                {
                    Facture facture = (Facture)Application.OpenForms["Facture"];
                    facture.setFacture(id);
                    this.Close();
                }
                if (DEVIS.Columns[e.ColumnIndex].Name == "delete")
                {
                    DialogResult dialogResult = MessageBox.Show(text: "vous etes sure de vouloir supprimer ce document ?", "VALIDATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Infrastructure.Data.Access.DocumentAccess.Delete(id);
                        Infrastructure.Data.Access.ArticlesAccess.DeleteByDocument(id);
                        DEVIS.Rows.Clear();
                        DEVIS.Refresh();
                        FactureList_Load(sender, e);
                        MessageBox.Show(this, "Document supprimee", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var list = Infrastructure.Data.Access.DocumentAccess.Get();
            var factures = list.Where(l => l.Type == Enums.DocumentType.facture.ToString()).ToList();
            if (!(sender as TextBox).Text.StringIsNullOrEmptyOrWhiteSpaces())
            {
                var text = (sender as TextBox).Text.ToLower();
                factures = factures.Where(f => f.Client.ToLower().Contains(text)
                || f.Num.ToLower().Contains(text)
                || f.DateDocument.ToString("dd/MM/yyyy").Contains(text)).ToList();
                FillFactures(factures);
            }
        }
        #region Helpers
        public void FillFactures(List<Infrastructure.Data.Entities.DocumentEntity> _factures)
        {
            factures.Rows.Clear();
            factures.Refresh();
            foreach (var item in _factures)
            {
                this.factures.Rows.Add(
                    item.Id,
                    item.Num,
                    item.DateDocument.ToString("dd/MM/yyyy"),
                    item.Client
                    );
            }
        }
        public void FillDevis(List<Infrastructure.Data.Entities.DocumentEntity> devis)
        {
            DEVIS.Rows.Clear();
            DEVIS.Refresh();
            foreach (var item in devis)
            {
                this.DEVIS.Rows.Add(
                    item.Id,
                    item.Num,
                    item.DateDocument.ToString("dd/MM/yyyy"),
                    item.Client
                    );
            }
        }
        #endregion

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var list = Infrastructure.Data.Access.DocumentAccess.Get();
            var devis = list.Where(l => l.Type == Enums.DocumentType.devis.ToString()).ToList();
            if (!(sender as TextBox).Text.StringIsNullOrEmptyOrWhiteSpaces())
            {
                var text = (sender as TextBox).Text.ToLower();
                devis = devis.Where(f => f.Client.ToLower().Contains(text)
                || f.Num.ToLower().Contains(text)
                || f.DateDocument.ToString("dd/MM/yyyy").Contains(text)).ToList();
                FillFactures(devis);
            }
        }
    }
}