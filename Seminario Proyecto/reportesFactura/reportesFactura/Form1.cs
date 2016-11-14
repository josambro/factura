using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportesFactura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MostrarReporte mp = new MostrarReporte();
             mp.Fecha=dateTimePicker1.Value;
              mp.Fecha1 = dateTimePicker2.Value;
              mp.MdiParent = this;
            mp.ShowDialog();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
