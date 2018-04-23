using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARE
{
    public partial class frmSalones : Form
    {
        int[] salones;
        Boolean[,] adyacencia;
        String[] linea;
        char c;
        int indexN,indexAdj;

        public frmSalones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSalones_Load(object sender, EventArgs e)
        {

        }

        private void rBMaestro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            int n = Int16.Parse(txtnumClases.Text);

            adyacencia= new Boolean[n,n];
            for (int i=0; i<txtClases.Lines.Length; i++)
            {
                linea=txtClases.Lines[i].Split('-'); //clique a array
                c = Convert.ToChar(linea[0]);        //convierte a char el primer elemento del clique
                indexN = char.ToUpper(c) - 65;       //convierte a indice el char

                for (int j=1; j<linea.Length; j++)
                {
                    if (linea.Length == 2)
                    {
                        c = Convert.ToChar(linea[j]);
                        indexAdj = char.ToUpper(c) - 65;

                        adyacencia[indexN, indexAdj] = true;
                        adyacencia[indexAdj, indexN] = true;
                    }
                    else
                    {
                        conectaN(linea);//conecta todos con todos del clique
                    }

                }

            }

            //imprime matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Format("{0} ", adyacencia[i, j]));
                }
                Console.Write(Environment.NewLine);
            }

        }
/*A-E
B-C
C-D
E-D
E-D
A-B-D
A-H-I
F-G-H
B-H-I
D-F-I
D-H-I*/
        //conecta n nodos en un n-clique con n>2
        public void conectaN(String[] l)
        {
            for (int i = 0; i < l.Length; i++)
            {
                l = txtClases.Lines[i].Split('-');
                c = Convert.ToChar(linea[i]);
                indexN = char.ToUpper(c) - 65;
                for (int j = 0; j < linea.Length; j++)
                {
                    if (i!=j)
                    {
                        c = Convert.ToChar(linea[j]);
                        indexAdj = char.ToUpper(c) - 65;

                        adyacencia[indexN, indexAdj] = true;
                        adyacencia[indexAdj, indexN] = true;
                    }

                }

            }
        }

        public void areBi()
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char l;
            cBSalones.Items.Clear();
            if (txtnumClases.Text != "")
            {
                int n = Int16.Parse(txtnumClases.Text);
                for (int i = 0; i < n; i++)
                {
                    l = (char)(i + 65);
                    l = Convert.ToChar(l);
                    cBSalones.Items.Add(l);
                }

            }

        }
    }
}
