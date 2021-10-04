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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("");
            listBox1.Items.Add("ITALO ANTONIO GUEVARA GARCIA");
            listBox1.Items.Add("");
            listBox1.Items.Add("MELVIN ALEXIS JIMENEZ LOPEZ");

        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 mv = new Form2();
            mv.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 mv = new Form3();
            mv.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
