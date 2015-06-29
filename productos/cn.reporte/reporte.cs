using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using cd.reporte;

namespace cn.reporte
{
    public class reporte
    {
        public static DataTable reporteVentasNombre(string nombre)
        {
            return cd.reporte.reporte.reporteNombre(nombre);
        }

        public static DataTable reporteVentasProducto(string producto)
        {
            return cd.reporte.reporte.reporteProducto(producto);
        }

        public static DataTable reporteVentasPeriodo(DateTime inicio, DateTime fin)
        {
            return cd.reporte.reporte.reportePeriodo(inicio, fin);
        }
    }
}
