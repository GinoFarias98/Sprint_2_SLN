using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suscrito
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string DNI { get; set; }

        public string NSuscripto { get; set; }

        public string CuotasPagadas { get; set; }

        public int MontoCuota { get; set; }


        public void Agregar(string aNombre, string aApellido, string aTelefono, string aDNI, string aNSuscripto, string aCuotasPagadas, int aMontoCuota)
        {
            Nombre = aNombre;
            Apellido = aApellido;
            Telefono = aTelefono;
            DNI = aDNI;
            NSuscripto = aNSuscripto;
            CuotasPagadas = aCuotasPagadas;
            MontoCuota = aMontoCuota;
        }

    }
}
