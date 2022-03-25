using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chebash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] daiMassiv(int n, int m)
        {
            int[,] tarkovMoyaZizn = new int[n,m];

            Random rand = new Random();

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    tarkovMoyaZizn[i, j] = rand.Next(-50, 51);
                }
            }

            return tarkovMoyaZizn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textN.Text);
            int m = Convert.ToInt32(textM.Text);

            int[,] massiv = daiMassiv(n, m);

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    massiv[j, i] = 1 - massiv[j, i];
                    bilo.Text += massiv[j, i];
                    yasosBiba.Text += massiv[j, i].ToString() + " ";
                }
                yasosBiba.Text += "\n";
                bilo.Text += "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textN.Text);
            int m = Convert.ToInt32(textM.Text);

            int[,] massiv = daiMassiv(n, m);
            int[] massiv2 = new int[n*m];

            int dif = 0;

            for (int i = 0; i < n; i++)
            {
                bool estOtricatelnoe = false;
                for (int j = 0; j < m; j++)
                {
                    if (massiv[j, i] < 0)
                    {
                        for(int k = 0; k < m; k++)
                        {
                            massiv2[k+(i-dif)*m] = massiv[k, i];
                        }
                        estOtricatelnoe = true;
                        break;
                    }
                }

                if (!estOtricatelnoe)
                    dif++;

                Array.Resize(ref massiv2, (n - dif) * m);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    bilo.Text += massiv[j, i] + " ";
                }
                bilo.Text += "\n";
            }

            int kostil = 0;
            for(int i = 0; i < massiv2.Length; i++)
            {
                yasosBiba.Text += massiv2[i].ToString() + " ";
                if (++kostil >= m)
                {
                    kostil = 0;
                    yasosBiba.Text += "\n";
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
