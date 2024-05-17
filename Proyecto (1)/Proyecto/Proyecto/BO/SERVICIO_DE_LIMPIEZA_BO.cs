using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BO
{
    class SERVICIO_DE_LIMPIEZA_BO
    {

        private int ID_actimp;
        private DateTime Fecha_Hora_Servicio;
        private string nombre_actimp;

        public int ID_actimp1 { get => ID_actimp; set => ID_actimp = value; }
        public DateTime Fecha_Hora_Servicio1 { get => Fecha_Hora_Servicio; set => Fecha_Hora_Servicio = value; }
        public string Nombre_actimp { get => nombre_actimp; set => nombre_actimp = value; }
    }
}
