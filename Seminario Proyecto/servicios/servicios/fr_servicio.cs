using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servicios
{
    public partial class fr_servicio : Form
    {
        ArrayList EnviaDatos = new ArrayList();
        public fr_servicio()
        {
            InitializeComponent();

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fr_servicio_Load(object sender, EventArgs e)
        {

            EnviaDatos.Add(txt_cod);
            EnviaDatos.Add(txt_nomser);
            EnviaDatos.Add(txt_preser);
            EnviaDatos.Add(txt_estser);
                   
            navegador1.alDatosEntrada = EnviaDatos;
            navegador1.vIniciarNavegador();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             switch (comboBox1.SelectedIndex)
            {
                case 0: txt_estser.Text = "1";
                    break;
                case 1: txt_estser.Text = "0";
                    break;
                default: break;
            }
        }

      
        }
    }

