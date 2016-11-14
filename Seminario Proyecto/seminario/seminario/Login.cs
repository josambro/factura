using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace seminario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT nom_usuario,contra_usuario,tipo_usuario FROM tbl_usuario WHERE nom_usuario='" + txtUsuario.Text + "'AND contra_usuario='" + txtContrasena.Text + "' ", conexcioBD.BDcomun.ObtenerConexion()); //Realizamos una selecion de la tabla usuarios.
                MySqlDataReader leer = cmd.ExecuteReader();



                string codigo = null;



                if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    codigo = leer.GetString("tipo_usuario");
                    if (codigo.Equals("1") == true)
                    {

                        string usu;
                        usu = txtUsuario.Text;
                        form1 principal = new form1(usu, codigo);

                        principal.Show();



                    }
                    if (codigo.Equals("2") == true)
                    {

                        string usu;
                        usu = txtUsuario.Text;
                        MessageBox.Show("Bienvenido al sistema " + usu);
                        form1 principal = new form1(usu, codigo);

                        principal.Show();


                    }

                }
                else //Si no lo es mostrara este mensaje.
                    MessageBox.Show("Error - Ingrese sus datos correctamente");

            }catch(Exception EX)
            {
                MessageBox.Show("Error - DE CONEXION A BASE DE DATOS");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
