using pdFormula;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servicios
{
    public partial class Usuarios : Form
    {
        
        cs_Negocios cbo = new cs_Negocios();
        ArrayList EnviaDatos = new ArrayList();

        public Usuarios()
        {
            InitializeComponent();
        }



        private void llenarCBO()
        {

            BindingSource bdcbo = new BindingSource();
            bdcbo.DataSource = cbo.obtemp();
            cbo_emp.DataSource = bdcbo.DataSource;
            cbo_emp.DisplayMember = "nombre_emp";
            cbo_emp.ValueMember = "idtbl_empleados";
            cbo_emp.Refresh();
            cbo_emp.DropDownStyle = ComboBoxStyle.DropDownList;
            
          
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_emp.DropDownStyle = ComboBoxStyle.DropDownList;
            string valor = cbo_emp.SelectedValue.ToString();
            txt_emp.Text = " "+valor;
            //txt_emp.Text = valor;
            
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            
            EnviaDatos.Add(txt_id);
            EnviaDatos.Add(txt_emp);
            EnviaDatos.Add(txt_tipoemp);
            EnviaDatos.Add(txt_usuario);
            EnviaDatos.Add(txt_contraseña);
           // EnviaDatos.Add(txt_descser);
            navegador1.alDatosEntrada = EnviaDatos;
            navegador1.vIniciarNavegador();

            llenarCBO();

        }

     
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

           switch
              (comboBox1.SelectedIndex)
            {
                case 0: txt_tipoemp.Text = "1";
                    break;
                case 1: txt_tipoemp.Text = "0";
                    break;
                default: break;
            }
        }
    }
}
