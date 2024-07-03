using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suscriptos
    {
        private DataTable SuscriptosLista = new DataTable();

        public DataTable P_SuscriptosLista
        { 
            set { SuscriptosLista = value; }
            get { return SuscriptosLista; }
        }

        public Suscriptos()
        {
            P_SuscriptosLista.TableName = "Tabla_Suscriptos";
            P_SuscriptosLista.Columns.Add("Nombre");
            P_SuscriptosLista.Columns.Add("Apellido");
            P_SuscriptosLista.Columns.Add("Telefono");
            P_SuscriptosLista.Columns.Add("DNI");
            P_SuscriptosLista.Columns.Add("N-Suscripto");
            P_SuscriptosLista.Columns.Add("Cuotas-Pagadas");
            P_SuscriptosLista.Columns.Add("Monto-Cuotas");
            Validador();
        }


        private void Validador()
        {
            if (System.IO.File.Exists("Tabla_Suscriptos"))
            {
                P_SuscriptosLista.ReadXml("Tabla_Suscriptos");
            }
        }

        public void InsertSuscrito(Suscrito aSuscrito)
        {
            P_SuscriptosLista.Rows.Add();
            int NuevoRenglon = P_SuscriptosLista.Rows.Count - 1;
            P_SuscriptosLista.Rows[NuevoRenglon]["Nombre"] = aSuscrito.Nombre;
            P_SuscriptosLista.Rows[NuevoRenglon]["Apellido"] = aSuscrito.Apellido;
            P_SuscriptosLista.Rows[NuevoRenglon]["Telefono"] = aSuscrito.Telefono;
            P_SuscriptosLista.Rows[NuevoRenglon]["DNI"] = aSuscrito.DNI;
            P_SuscriptosLista.Rows[NuevoRenglon]["N-Suscripto"] = aSuscrito.NSuscripto;
            P_SuscriptosLista.Rows[NuevoRenglon]["Cuotas-Pagadas"] = aSuscrito.CuotasPagadas;
            P_SuscriptosLista.Rows[NuevoRenglon]["Monto-Cuotas"] = aSuscrito.MontoCuota;

            P_SuscriptosLista.WriteXml("Tabla_Suscriptos");
        }

        public Suscrito BuscarSuscripto(string Accion, string ValorBuscado)
        {
            Suscrito suscripto = null;
                    
                suscripto = new Suscrito();

                foreach (DataRow fila in P_SuscriptosLista.Rows)
                {
                    if ((Accion == "DNI" && fila["DNI"].ToString().Equals(ValorBuscado)) ||
                (Accion == "aNSuscripto" && fila["N-Suscripto"].ToString().Equals(ValorBuscado)))
                    {
                        suscripto.Nombre = (fila["Nombre"].ToString());
                        suscripto.Apellido = (fila["Apellido"].ToString());
                        suscripto.Telefono = (fila["Telefono"].ToString());
                        suscripto.DNI = (fila["DNI"].ToString());
                        suscripto.NSuscripto = (fila["N-Suscripto"].ToString());
                        suscripto.CuotasPagadas = (fila["Cuotas-Pagadas"].ToString());
                        suscripto.MontoCuota = (Convert.ToInt32(fila["Monto-Cuotas"]));

                        break;
                    }
                }                          
            return suscripto;
        }

        public void EliminarSuscripto(string aNSuscripto)
        {

            foreach (DataRow fila in P_SuscriptosLista.Rows)
            {
                if (fila["N-Suscripto"].ToString().Equals(aNSuscripto))
                {
                    P_SuscriptosLista.Rows.Remove(fila);
                    break;
                }
            }
            P_SuscriptosLista.WriteXml("Tabla_Suscriptos");
        }
    }
}
