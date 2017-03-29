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
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }
        public static String Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();


                if (cuenta == textBox1.Text.Trim() && contra==textBox2.Text.Trim())
                {

                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {

                        VentanaAdmin VenAd = new VentanaAdmin();
                        this.Hide();
                        VenAd.Show();

                    }
                    else
                    {

                        VentanaUser VenUse = new VentanaUser();
                        this.Hide();
                        VenUse.Show();

                    }


                }




            }catch(Exception error)
            {

                MessageBox.Show("Usuario o Contraseña incorrecta");

            }
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
