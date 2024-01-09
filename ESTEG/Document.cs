

namespace ESTEG
{
    public partial class Document : Form
    {
        public Document()
        {
            InitializeComponent();
        }
        public void SetDocument(string file)
        {
            axAcropdf1.src = file;
            axAcropdf1.setView("Fit");
            axAcropdf1.setShowToolbar(true);
            axAcropdf1.setLayoutMode("SinglePage");
            axAcropdf1.setPageMode("none");
        }
    }
}
