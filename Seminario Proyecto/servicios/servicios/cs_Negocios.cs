using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdFormula
{
    class cs_Negocios
    {
        cs_Datos dgv = new cs_Datos();
        #region Datatable para empleados
        public DataTable obtemp()
        {
            try
            {
                ArrayList obtEmpleado = new ArrayList();

                obtEmpleado = dgv.obtenerDatosCombo();

                DataTable dt = new DataTable("emp");
                DataColumn col1, col2;
                DataRow fil;

                col1 = new DataColumn();
                col1.DataType = System.Type.GetType("System.String");
                col1.ColumnName = "idtbl_empleados";

                col2 = new DataColumn();
                col2.DataType = System.Type.GetType("System.String");
                col2.ColumnName = "nombre_emp";

            



                dt.Columns.Add(col1);
                dt.Columns.Add(col2);
                



                foreach (ArrayList item in obtEmpleado)
                {
                    fil = dt.NewRow();
                    fil["idtbl_empleados"] = item[0].ToString();
                    fil["nombre_emp"] = item[1].ToString();
     
                    dt.Rows.Add(fil);

                }

                return dt;
            }catch(Exception ex)
            {
                throw new Exception("Se genero el siguiente error: " + ex.Message.ToString().Replace("'", ""));
            }
        }
        #endregion
    }
}
