using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol2_retezec_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zjistit_Click(object sender, EventArgs e)
        {
            cifry.Items.Clear();

            string vstup2 = vstup.Text;
            int cifra = 0;

            if (vstup2 == "")
            {
                MessageBox.Show("Musíš zadat hodnoty!", "Error");
            }
            else
            {
                vstup2 = String.Join(" ", vstup2.Split(' ').Where(slovo => !String.IsNullOrWhiteSpace(slovo)));

                string[] slova = (vstup.Text.Trim()).Split(' ');

                foreach (string slovo in slova)
                {
                    if (slovo != "")
                    {
                        foreach (char znak in slovo)
                        {
                            if (znak >= '0' && znak <= '9')
                            {
                                cifry.Items.Add(slovo);
                                cifra++;
                                break;
                            }
                        }
                    }
                }

                vystup.Text = vstup2;
                MessageBox.Show("Počet slov s ciframi: " + cifra, "Výsledek");
            }
        }
    }
}
