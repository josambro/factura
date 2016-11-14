using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdFormula
{
    class cs_Datos
    {
       
        ArrayList cbollenado = new ArrayList();

        public ArrayList obtenerDatosCombo()
        {
            try
            {
                cbollenado = ODBCconnector.csFunciones.alConsultar("select idtbl_empleados, nombre_emp from tbl_empleados");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return cbollenado;
        }



    }
}
