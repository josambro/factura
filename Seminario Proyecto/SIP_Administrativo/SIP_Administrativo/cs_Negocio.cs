using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIP_Administrativo
{
    class cs_Negocio
    {
        cs_Datos cbo = new cs_Datos();
        public DataTable obtenerDatosCombo()
        {
            ArrayList cbo2 = cbo.obtenerDatosCombo();
            DataTable dt = new DataTable("Empresa");
            DataColumn colunm, dcol;
            DataRow row;

            dcol = new DataColumn();
            dcol.DataType = System.Type.GetType("System.String");
            dcol.ColumnName = "cod_empsa";

            colunm = new DataColumn();
            colunm.DataType = System.Type.GetType("System.String");
            colunm.ColumnName = "nomcomercial_empsa";

            dt.Columns.Add(dcol);
            dt.Columns.Add(colunm);

            foreach (ArrayList item in cbo2)
            {
                row = dt.NewRow();
                row["cod_empsa"] = item[0].ToString();
                row["nomcomercial_empsa"] = item[1].ToString();
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
