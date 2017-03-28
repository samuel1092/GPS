using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryHerramientas;

namespace Programa_Operaciones_basicas_dll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            operaciones op = new operaciones();
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            String respuestas = textBox3.Text + "" + op.suma(a, b);
            textBox3.Text = respuestas;

            String resmul = textBox4.Text + " " + op.multiplica(a, b);
           textBox4.Text = resmul;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text= "";
            textBox4.Text = "";
        }
    }
}
