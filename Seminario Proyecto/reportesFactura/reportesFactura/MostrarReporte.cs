﻿using System;
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
    public partial class MostrarReporte : Form
    {
        
        public MostrarReporte()
        {
            InitializeComponent();
            
        }
        public DateTime Fecha { get; set; }
        public DateTime Fecha1 { get; set; }

       public void MostrarReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.dtfactura' Puede moverla o quitarla según sea necesario.
            this.dtfacturaTableAdapter.Fill(this.DataSetPrincipal.dtfactura,Fecha,Fecha1);

            this.reportViewer1.RefreshReport();
        }
    }
}
