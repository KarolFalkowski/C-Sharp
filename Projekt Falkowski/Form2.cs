using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Falkowski
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.zliczone.Length; i++)
            {
                Wykres.Series[0].Points.AddXY(i, Form1.zliczone[i]);
                ListaDoUkrycia.Items.Add("Dana: " + i);
            }
        }

        private void ZmienKolor_Click(object sender, EventArgs e)
        {
            if (radioCzerwony.Checked == true) Wykres.Series[0].Color = Color.FromName("Red");
            else if (radioZielony.Checked == true) Wykres.Series[0].Color = Color.FromName("Green");
            else if (radioNiebieski.Checked == true) Wykres.Series[0].Color = Color.Blue;
        }

        private void wlLegende_Click(object sender, EventArgs e)
        {
            Wykres.Legends[0].Enabled = true;
        }

        private void wylegende_Click(object sender, EventArgs e)
        {
            Wykres.Legends[0].Enabled = false;
        }

        private void PokazDane_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< wybrane.Count;i++)
            {
                Wykres.Series[0].Points[wybrane[i]].SetValueY(Form1.zliczone[wybrane[i]]);
            }
            Wykres.Invalidate();
        }
        List<int> wybrane = new List<int>();
       
        private void ListaDoUkrycia_SelectedIndexChanged(object sender, EventArgs e)
        {
            wybrane.Add(ListaDoUkrycia.SelectedIndex);
            Wykres.Series[0].Points[ListaDoUkrycia.SelectedIndex].SetValueY(0);
            Wykres.Invalidate();
        }
    }
}
