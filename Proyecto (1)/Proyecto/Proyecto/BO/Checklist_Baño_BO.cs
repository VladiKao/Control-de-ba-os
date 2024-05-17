using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BO
{
    class Checklist_Baño_BO
    {
        private bool espejo;
        private bool luz;
        private bool papel;
        private bool jabon;
        private bool detergente;
        private bool aromatizante;
        private bool basurero;
        private bool piso_limpio;
        private bool falta_de_agua;
        private bool tuberia_mala;
        private bool falla_inodoro;
        private string otros;

        public bool Espejo { get => espejo; set => espejo = value; }
        public bool Luz { get => luz; set => luz = value; }
        public bool Papel { get => papel; set => papel = value; }
        public bool Jabon { get => jabon; set => jabon = value; }
        public bool Detergente { get => detergente; set => detergente = value; }
        public bool Aromatizante { get => aromatizante; set => aromatizante = value; }
        public bool Basurero { get => basurero; set => basurero = value; }
        public bool Piso_limpio { get => piso_limpio; set => piso_limpio = value; }
        public bool Falta_de_agua { get => falta_de_agua; set => falta_de_agua = value; }
        public bool Tuberia_mala { get => tuberia_mala; set => tuberia_mala = value; }
        public bool Falla_inodoro { get => falla_inodoro; set => falla_inodoro = value; }
        public string Otros { get => otros; set => otros = value; }
    }
}
