using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{

    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

        }

        private void txtsum_Click(object sender, EventArgs e)
        {
            mashin m1 = new mashin(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            label1.Text = m1.sum();

        }

        private void txtsum_Click_1(object sender, EventArgs e)
        {
            mashin m1 = new mashin(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            label1.Text = m1.sum();
        }

        private void taghsim_Click(object sender, EventArgs e)
        {
            mashin m1 = new mashin(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            label1.Text = m1.taghsim();
        }

        private void zarb_Click(object sender, EventArgs e)
        {
            mashin m1 = new mashin(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            label1.Text = m1.zarb();
        }

        private void menha_Click(object sender, EventArgs e)
        {
            mashin m1 = new mashin(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            label1.Text = m1.menha();
        }
    }
    class mashin
    {
       
        public int n1;
        public int n2;
        public int result;
        public string r = "";

        public mashin(int N1, int N2)
        {
            n1 = N1;
            n2 = N2;
        }
        public string sum()
        {
            result = n1 + n2;
            r = result.ToString();
            return r;
        }
        public string menha()
        {
            result = n1 - n2;
            r = result.ToString();
            return r;


        }
        public string zarb()
        {
            result = n1 * n2;
            r = result.ToString();
            return r;


        }
        public string taghsim()
        {
            result = n1 / n2;
            r = result.ToString();
            return r;


        }
    }

}