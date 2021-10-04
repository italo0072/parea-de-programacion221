using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mv = new Form1();
            mv.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            _4x4 rop = new _4x4();


            rop.word = true;
            rop.aceleracion = "17.23";
            rop.fabricante = "Fiat Chrysler Automobiles";
            rop.m1 = 6;
            rop.m2 = 10;
            rop.marcha = "c4";


            listBox1.Items.Add(rop.hg());
            listBox1.Items.Add("MODELO :" + rop.f3());
            listBox1.Items.Add("COLOR : " + rop.colores("cafe"));
            listBox1.Items.Add(rop.getinformacion());
            listBox1.Items.Add(rop.op());
            listBox1.Items.Add(rop.aceleracion2());
            listBox1.Items.Add(rop.po());
            listBox1.Items.Add("****************************************************");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _4x4 rop = new _4x4();


            rop.word = false; 
            rop.aceleracion = "20.04";
            rop.fabricante = "Volkswagen";
            rop.m1 = 14;
            rop.m2 = 5;
            rop.marcha = "C2";


            listBox1.Items.Add(rop.hg());
            listBox1.Items.Add("MODELO :" + rop.f4());
            listBox1.Items.Add("COLOR : " + rop.colores("celeste claro "));
            listBox1.Items.Add(rop.getinformacion());
            listBox1.Items.Add(rop.op());
            listBox1.Items.Add(rop.aceleracion2());
            listBox1.Items.Add(rop.po());
            listBox1.Items.Add("****************************************************");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
