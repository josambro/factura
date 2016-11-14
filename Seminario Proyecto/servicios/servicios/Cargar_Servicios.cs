using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace servicios
{
    public partial class Cargar_Servicios : Form
    {
        public Cargar_Servicios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region pasar datos de datagrid a otro datagrid y suma de columna precio
            foreach (DataGridViewRow rowPrincipal in dataGridView1.SelectedRows)
            {



                dataGridView2.Rows.Add(rowPrincipal.Cells["Numero"].Value, rowPrincipal.Cells["Descripcion"].Value, Convert.ToDouble(rowPrincipal.Cells["Precio"].Value.ToString()) * Convert.ToDouble((numericUpDown1.Value.ToString())), numericUpDown1.Value.ToString());

                DataGridViewRow roee = dataGridView2.CurrentRow;



                //dgv_empleados.Rows.Remove(rowPrincipal);





            }
            double suma = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                suma += Convert.ToDouble(row.Cells[2].Value);


            }


            #endregion

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            
           // string sql = @"SELECT cliente,Direccion,Rfc from clientes where Nit='"+textBox1.Text+"'";
           
            MySqlConnection con = new MySqlConnection(@"server=localhost; database=seminario; Uid=root; pwd=;");

           
            con.Open();// abro conexion.
            string StrComando = @"SELECT cliente,Direccion,Nit from clientes where Nit='" + textBox1.Text + "'";
           
          MySqlCommand COMAND = new MySqlCommand(StrComando, con);
            DataTable tabla = new DataTable(); // El resultado lo guardaremos en una tabla
            MySqlDataAdapter AdaptadorTabla = new MySqlDataAdapter(StrComando, con); // Usaremos un DataAdapter para leer los datos
            //DataSet ds = new DataSet();
            AdaptadorTabla.Fill(tabla);// Llenamos la tabla con los datos leídos



            string nom = tabla.Rows[0]["cliente"].ToString();//guardo informacion en variables
            string dire = tabla.Rows[0]["Direccion"].ToString();
            string nit = tabla.Rows[0]["Nit"].ToString();
          



          
            textBox2.Text = nom;
            textBox3.Text = dire;
            textBox4.Text = nit;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            txt_codf.Enabled = true;
            dataGridView1.Enabled = true;
            dataGridView2.Enabled = true;
            dateTimePicker1.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

        }

        private void codigof()
        {
            #region obtenr id de formula
            MySqlConnection Nconexion = conexcioBD.BDcomun.ObtenerConexion();
            int antes = 0;
            string consulta = "select max(Numero) from factura";
            MySqlCommand comando = new MySqlCommand(consulta, Nconexion);

            MySqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    antes = int.Parse(Convert.ToString(dr["max(Numero)"]));
                }
            }

            txt_codf.Text = Convert.ToString(antes + 1);
            dr.Close();
            #endregion
        }

        private void llenardgv()
        {
            MySqlConnection Nconexion = conexcioBD.BDcomun.ObtenerConexion();    
            string consulta = "select Numero,Descripcion,Precio from articulo";
            MySqlCommand comando = new MySqlCommand(consulta, Nconexion);
            MySqlDataReader dr;
            dr = comando.ExecuteReader();
            
            while(dr.Read())
            {
                this.dataGridView1.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2));

            }
        }

        private void Cargar_Servicios_Load(object sender, EventArgs e)
        {
            
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            txt_codf.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            dateTimePicker1.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;


                
            
            codigof();
            llenardgv();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region quitando linea de datagrid
            try
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                double resta = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    resta -= Convert.ToDouble(row.Cells[2].Value);


                }
               // txt_preciou.Text = Convert.ToString(Math.Abs(resta));
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.dataGridView2.Rows.Clear();

            #region  guardar detalle formula
            MySqlConnection myConnection = conexcioBD.BDcomun.ObtenerConexion();


            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            MySqlTransaction myTrans;

            // iniciando la trasaccion
            myTrans = myConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            myCommand.Transaction = myTrans;
               string cadena2 = txt_codf.Text;

            try
            {



                myCommand.CommandText = "INSERT INTO detallefactura values (@NumeroFactura,@NumeroArticulo,@Piezas)";

               // string cadena = cbo_estaf.SelectedItem.ToString();
                string cad = numericUpDown1.Value.ToString();
              
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    myCommand.Parameters.Clear();

                    myCommand.Parameters.AddWithValue("@NumeroFactura", Convert.ToString(cadena2));
                    myCommand.Parameters.AddWithValue("@NumeroArticulo", Convert.ToString(row.Cells["num"].Value));
                    myCommand.Parameters.AddWithValue("@Piezas", Convert.ToString(row.Cells["can"].Value));
                  
                    myCommand.CommandTimeout = 0;

                    myCommand.ExecuteNonQuery();


                }


                string nombref = textBox2.Text;
                string unidadf = textBox3.Text;
                string nit = textBox4.Text;
                string fecha = dateTimePicker1.Value.ToString("yyyyMMdd");
             


                myCommand.CommandText = "INSERT INTO factura(Numero,Cliente,Rfc,Direccion,FechaFacturacion) Values('" + cadena2 + "','" + nombref + "','" + nit + "','" + unidadf + "','" + fecha + "')";
                myCommand.ExecuteNonQuery();

               
                /*myCommand.CommandText = ")";
                myCommand.ExecuteNonQuery();*/
               
                myTrans.Commit();
                MessageBox.Show("Los Datos Se Han Guardado Exitosamente");
               /* dataGridView2.Enabled = false;
                numericUpDown1.Enabled = false;
                cbo_unif.Enabled = false;
                cbo_estaf.Enabled = false;*/

            }
            catch (Exception a)
            {
                myTrans.Rollback();
                MessageBox.Show(a.ToString());
                MessageBox.Show("Datos no ingresados a la Base de Datos");
            }
            finally
            {
                myConnection.Close();
            }
            #endregion
        }
    }
}
