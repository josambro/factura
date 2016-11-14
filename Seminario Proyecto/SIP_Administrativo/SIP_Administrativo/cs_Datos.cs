using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace SIP_Administrativo
{
    class cs_Datos
    {
        ArrayList cbollenado = new ArrayList();
        public ArrayList obtenerDatosCombo()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("select cod_empsa, nomcomercial_empsa from tabm_empresa");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }
    }
}
