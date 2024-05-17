using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BO
{
    class BañoMuje_BO
    {

        private int idbanio_muje;
        private string matriculabanio_muje;
        private string luz;
        private string agua;
        private string espejo;
        private string jabon;
        private string gelantibacterial;
        private string basurero;
        private string papel_servilletero;
        private string lavabos;
        private int inodoros;
        private int IDEdificio;
        private int idusuarioemp;

        public int Idbanio_muje { get => idbanio_muje; set => idbanio_muje = value; }
        public string Matriculabanio_muje { get => matriculabanio_muje; set => matriculabanio_muje = value; }
        public string Luz { get => luz; set => luz = value; }
        public string Agua { get => agua; set => agua = value; }
        public string Espejo { get => espejo; set => espejo = value; }
        public string Jabon { get => jabon; set => jabon = value; }
        public string Gelantibacterial { get => gelantibacterial; set => gelantibacterial = value; }
        public string Basurero { get => basurero; set => basurero = value; }
        public string Papel_servilletero { get => papel_servilletero; set => papel_servilletero = value; }
        public string Lavabos { get => lavabos; set => lavabos = value; }
        public int Inodoros { get => inodoros; set => inodoros = value; }
        
        public int Idusuarioemp { get => idusuarioemp; set => idusuarioemp = value; }
        public int IDEdificio1 { get => IDEdificio; set => IDEdificio = value; }
    }
}
