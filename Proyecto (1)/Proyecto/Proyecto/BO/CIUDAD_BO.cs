using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BO
{
    class CIUDAD_BO
    {

        private int ID_Ciudad;
        private string Nombre_Ciudad;
        private int idEstado; 

        public int ID_Ciudad1 { get => ID_Ciudad; set => ID_Ciudad = value; }
        public string Nombre_Ciudad1 { get => Nombre_Ciudad; set => Nombre_Ciudad = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
    }
}
