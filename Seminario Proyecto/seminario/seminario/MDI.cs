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
      
    public partial class form1 : Form
    {
        private string usuario;
        private string codigo;
        public form1(string usua,string cod)
        {
            InitializeComponent();
            usuario = usua;
            codigo=cod;
            toolStripStatusLabel3.Text = usuario;
            //bloque de funciones segun sea su usuario
            if(codigo.Equals("1")==true)
            {
                
            }if(codigo.Equals("2")==true)
            {
                //toolStripMenuItem2.Enabled = false;
                nuevoClienteToolStripMenuItem.Enabled = false;
            }

        }

    

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            servicios.Usuarios us = new servicios.Usuarios();
            us.MdiParent = this;
            us.Show();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void ingresoDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            servicios.fr_servicio sr = new servicios.fr_servicio();
            sr.MdiParent = this;
            sr.Show();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SIP_Administrativo.wf_Clientes CTE = new SIP_Administrativo.wf_Clientes();
            CTE.MdiParent = this;
            CTE.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportViewerInvoiceReport_CSharp.Factura fc = new ReportViewerInvoiceReport_CSharp.Factura();
            fc.MdiParent = this;
            fc.Show();
        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            servicios.Cargar_Servicios cs = new servicios.Cargar_Servicios();
            cs.MdiParent = this;
            cs.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportesFactura.Form1 mr = new reportesFactura.Form1();
            mr.MdiParent = this;
            mr.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SIP_Administrativo.wf_Proveedores PROV = new SIP_Administrativo.wf_Proveedores();
            PROV.MdiParent = this;
            PROV.Show();
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SIP_Administrativo.wf_Empleados EMP = new SIP_Administrativo.wf_Empleados();
            EMP.MdiParent = this;
            EMP.Show();
        }
    }
}
