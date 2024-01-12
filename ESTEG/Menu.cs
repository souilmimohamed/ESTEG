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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void devisFactireBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facture facture = new Facture();
            facture.Closed += (s, args) => this.Close();
            facture.Show();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pointage pointage = new Pointage();
            pointage.Closed += (s, args) => this.Close();
            pointage.Show();
        }
    }
}
