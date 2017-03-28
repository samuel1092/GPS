using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregamos el espacio de nombre que sql
using System.Data.SqlClient;
using MiLibrary;


namespace FactuxD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();


                if (cuenta == textBox1.Text.Trim() && contra==textBox2.Text.Trim())
                {

                    MessageBox.Show("Se ha iniciado sesión");


                }




            }catch(Exception error)
            {

                MessageBox.Show("Usuario o Contraseña incorrecta");

            }
        }
    }
}
