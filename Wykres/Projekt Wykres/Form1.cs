using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Falkowski
{
    public partial class Form1 : Form
    {    
        public Form1()
        {
            InitializeComponent();
        }
        public static Int32[] zliczone;
        public Int32 rozmiar = 0;
        public Int32 sprawdzRozmiar(Int32[] tab)
        {
            int max = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (max < tab[i]) max = tab[i];
            }

            return max;
        }
        public Int32[] zliczanie(Int32[] tab)
        {
            Int32[] listaUlozona = new Int32[rozmiar];

            foreach (var item in listaUlozona)
            {
                listaUlozona[item] = 0;
            }

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                    if (tab[i] == j) listaUlozona[j]++;
            }
            return listaUlozona;
        }

        private void Wczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog otworz = new OpenFileDialog();
            otworz.CheckFileExists = true;
            otworz.Filter = "txt file (*.txt)|*.txt";

            if(otworz.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = otworz.FileName;
                    string czytane = File.ReadAllText(path);

                    Int32[] liczby = czytane.Split(',', ';', ' ', '.').Select(s => Int32.Parse(s)).ToArray();

                    rozmiar = sprawdzRozmiar(liczby) + 1;
                    zliczone = zliczanie(liczby);

                    pokazWykres.Visible = true;
                    zapisz.Visible = true;
                    label1.Visible = true;
                    label3.Visible = true;
                    MessageBox.Show("Prawidłowo załadowano plik:" + otworz.FileName);

                }
                catch(Exception)
                {
                    pokazWykres.Visible = false;
                    zapisz.Visible = false;
                    label1.Visible = false;
                    label3.Visible = false;
                    MessageBox.Show("Nie udało się załadowac pliku!");
                    MessageBox.Show("Wybrano zły plik. Przykładowy plik:(1,2,4.5;6,3 7)");
                }
            }
        }

        private void pokazWykres_Click(object sender, EventArgs e)
        {
            Form2 wykres = new Form2();
            wykres.ShowDialog();
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog zapis = new SaveFileDialog();
            zapis.Filter = "txt file (*.txt)|*.txt";

            if (zapis.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(zapis.FileName);
                for(int i = 0; i<=rozmiar; i++)
                {
                    if (i + 1 < rozmiar)
                    {
                        int z = i + 1;
                        int odp = zliczone[i] + zliczone[i + 1];
                        sw.WriteLine("Oceny" + i + "-" + z + ": " + odp);
                    }
                    else break;
                    
                }
                MessageBox.Show("Zapisano dane do pliku: " + zapis.FileName);

                sw.Close();

            }
        }
    }
}
