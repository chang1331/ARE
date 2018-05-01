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
        List<List<int>> horario = new List<List<int>>();
        List<int>[] resHorario;
       // Dictionary<int,int> resHorario= new Dictionary<int, int>() ;
        Boolean[,] adyacencia;
        String[] linea;
        char c;
        int indexN,indexAdj,index, n,resSalon ;

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
            n = Int16.Parse(txtnumClases.Text);

            adyacencia= new Boolean[n,n];
            for (int i=0; i<txtClases.Lines.Length; i++)
            {
                linea=txtClases.Lines[i].Split('-'); //clique a array
                    
                c = Convert.ToChar(linea[0]);        //convierte a char el primer elemento del clique
                indexN = char.ToUpper(c) - 65;       //convierte a indice el char

                if (linea.Length == 2)
                {
                    for (int j = 1; j < linea.Length; j++)
                    {
                        c = Convert.ToChar(linea[j]);
                        indexAdj = char.ToUpper(c) - 65;

                        adyacencia[indexN, indexAdj] = true;
                        adyacencia[indexAdj, indexN] = true;

                    }
                    
                }
                else
                {
                    conectaN(linea);//conecta todos con todos del clique
                }
                

            }

            //agrego restricciones de maestro
            
             for (int i = 0; i < txtResMaes.Lines.Length; i++)
            {
                linea = txtResMaes.Lines[i].Split('-'); //clique a array
                c = Convert.ToChar(linea[0]);        //convierte a char el primer elemento del clique
                indexN = char.ToUpper(c) - 65;       //convierte a indice el char

                for (int j = 1; j < linea.Length; j++)
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

            //inicio la matriz de salon con restriccion, y la lleno con n listas
            resHorario = new List<int>[n];

            for (int i=0;i<n;i++)
            {
                resHorario[i]=new List<int>();
            }

            for (int j = 0; j < txtResHor.Lines.Length; j++)
            {
                String lineaResHor = txtResHor.Lines[j];
                Console.WriteLine(txtResHor.Lines[j]);
                if (lineaResHor[1] == '<')
                {
                    c = Convert.ToChar(lineaResHor[0]);
                    index = char.ToUpper(c) - 65;

                    Console.WriteLine(index);
                    for (int i = (int)Char.GetNumericValue(lineaResHor[3])-2 ; i > 0; i--)
                    {
                        resHorario[index].Add(i);
                    }
                }
                //si es mayor no hay que llenar el arreglo con for
                else
                {
                    
                    c = Convert.ToChar(lineaResHor[0]);
                    index = char.ToUpper(c) - 65;

                    Console.WriteLine(index);
                    for (int i = (int)Char.GetNumericValue(lineaResHor[3]) - 2; i >= 0; i--)
                    {
                        resHorario[index].Add(i);
                    }
                }
            }
            //imprimo restricciones
            for (int i = 0; i < resHorario.Length; i++)
            {
                for (int j = 0; j < resHorario[i].Count; j++)
                {
                    Console.Write(string.Format("{0} ", resHorario[i][j]));
                }
                Console.Write(Environment.NewLine);
            }


            salones = new int[n];

            for(int i = 0; i < n; i++)
             {
                for(int j=0; j<n; j++)
                {
                    if (adyacencia[i,j])
                    {
                        salones[i]++;
                    }
                }
            }
            Console.WriteLine("salones numero de conex");
            for(int i = 0; i < n; i++)
            {
                Console.Write(salones[i]);
            }
            resSalon= Int16.Parse(txtMaxSalones.Text);
            horario.Add(new List<int>());
            //agrego las restricciones de horario a horario
            

            areBi();

            //imprime matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Format("{0} ", adyacencia[i, j]));
                }
                Console.Write(Environment.NewLine);
            }

            for (int i = 0; i < horario.Count; i++)
            {
                for (int j = 0; j < horario[i].Count; j++)
                {
                    Console.Write(string.Format("{0} ", (char)(horario[i][j]+65)));
                }
                Console.Write(Environment.NewLine);
            }



        }

        private void btnllenaDef_Click(object sender, EventArgs e)
        {
             txtnumClases.Text = "11";
             txtClases.Text = "A-B-C\r\nF-D-E\r\nE-G-H-J\r\nB-K-H\r\nE-H-I\r\nD-J\r\nA-H-D\r\nK-E-G\r\nC-D";
             txtMaxSalones.Text = "2";
             txtResHor.Text = "E>=3\r\nH>=3\r\nJ>=2";
             txtResMaes.Text= "A-I\r\nK-J";

            /*txtnumClases.Text = "9";
            txtClases.Text = "A-E\r\nB-C\r\nC-D\r\nE-D\r\nA-B-D\r\nA-H-I\r\nF-G-H\r\nB-H-I\r\nD-F-I\r\nD-H-I";
            txtMaxSalones.Text = "2";
            txtResHor.Text = "A>=3";*/


        }

        //conecta n nodos en un n-clique con n>2
        public void conectaN(String[] l)
        {
            
            for (int i = 0; i < l.Length; i++)
            {

                c = Convert.ToChar(l[i]);
                indexN = char.ToUpper(c) - 65;
                for (int j = 0; j < l.Length; j++)
                {
                    if (i!=j)
                    {
                        c = Convert.ToChar(l[j]);
                        indexAdj = char.ToUpper(c) - 65;

                        adyacencia[indexN, indexAdj] = true;
                        adyacencia[indexAdj, indexN] = true;
                    }

                }

            }
        }

        public void areBi()
        {
            for (int k=0;k<n;k++) {
              
                Console.WriteLine("k " + k);
                int iMax = obtenerMaxIndex();
                Console.WriteLine("indice de salon con mas conex " + (char)(iMax+65));
                int x = 0;
                Console.WriteLine("contains " + resHorario[iMax].Contains(x));
                Console.WriteLine("count " + (horario[x].Count >= resSalon));
                while (resHorario[iMax].Contains(x) || horario[x].Count >= resSalon)
                {
                    x++;
                    Console.WriteLine("tam horario " + horario.Count + "\n x " + x);
                    if (x >= horario.Count)
                    {
                        horario.Add(new List<int>());
                    }
                    Console.WriteLine("tam h antes de if " + horario.Count);
                    Console.WriteLine("contains siguiente " + resHorario[iMax].Contains(x));
                    Console.WriteLine("count siguiente " + (horario[x].Count >= resSalon));
                }
                horario[x].Add(iMax);
                Console.WriteLine("agregué " + (char)(iMax + 65) + " a horario " + x);

                for (int i = 0; i < n; i++)
                {
                    if (adyacencia[iMax,i])
                    {
                        salones[i]--;
                        resHorario[i].Add(x);
                    }
                }

                //elimino el salón
                salones[iMax] = -1;

                Console.WriteLine("salones numero de conex");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(salones[i]);
                }

            }
            
        }

        public int obtenerMaxIndex()
        {
            int max=0, maxIndex=0;
            for (int i = 0; i < n; i++)
            {
                if (salones[i] == 0)
                {
                    max = salones[i];
                    maxIndex = i;
                    break;
                }
               else if (salones[i] > max) {
                    max = salones[i];
                    maxIndex =  i;
                }   
              
            }
            return maxIndex;
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
