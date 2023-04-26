using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_em_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string frase = "meu texto";

            //labelFrase.Text = "O comprimento da frase: " + frase + " é " + frase.Length.ToString();

            labelFrase.Text = frase.ToUpper();
        }
    }
}
