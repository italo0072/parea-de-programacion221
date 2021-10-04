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
    public partial class Form3 : Form
    {
        public Form3()
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


            Deportivos repo = new Deportivos();

            repo.word = false;
            repo.fabricante = "Mazda";
            repo.silindros = 4;
            repo.aceleracion = "8.95";

            listBox1.Items.Add(repo.hg());
            listBox1.Items.Add("MODELO  :   " + repo.kl());
            listBox1.Items.Add("COLOR  :  " + repo.colores("gris"));
            listBox1.Items.Add(repo.getinformacion());
            listBox1.Items.Add(repo.silindro2());
            listBox1.Items.Add(repo.aceleracion2());
            listBox1.Items.Add("****************************************************");

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deportivos repo = new Deportivos();
            repo.word = true;
            repo.fabricante = "Porsche";
            repo.aceleracion = "4.2";
            repo.silindros = 6;

            listBox1.Items.Add(repo.hg());
            listBox1.Items.Add("MODELO  :  " + repo.k3());
            listBox1.Items.Add("COLOR  :  " + repo.colores("gris claro"));
            listBox1.Items.Add(repo.getinformacion());
            listBox1.Items.Add(repo.silindro2());
            listBox1.Items.Add(repo.aceleracion2());

            listBox1.Items.Add("****************************************************");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Deportivos repo = new Deportivos();
            repo.word = false;
            repo.aceleracion = "4.4";
            repo.fabricante = "Alpine";
            repo.silindros = 4;

            listBox1.Items.Add(repo.hg());
            listBox1.Items.Add("MODELO :" + repo.kk2());
            listBox1.Items.Add("COLOR : " + repo.colores("AZUL"));
            listBox1.Items.Add(repo.getinformacion());
            listBox1.Items.Add(repo.silindro2());
            listBox1.Items.Add(repo.aceleracion2());
            listBox1.Items.Add("****************************************************");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
