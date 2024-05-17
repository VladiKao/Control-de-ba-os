using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BO
{
    class Checklist_productos_BO
    {
        private bool fabuloso;
        private bool fab;
        private bool jabon;
        private bool cloro;
        private bool aromatizante;
        private bool trapeador;
        private bool jalador;
        private bool escoba;
        private bool mechudo;
        private bool cubeta;
        private string otro;

        public bool Fabuloso { get => fabuloso; set => fabuloso = value; }
        public bool Fab { get => fab; set => fab = value; }
        public bool Jabon { get => jabon; set => jabon = value; }
        public bool Cloro { get => cloro; set => cloro = value; }
        public bool Aromatizante { get => aromatizante; set => aromatizante = value; }
        public bool Trapeador { get => trapeador; set => trapeador = value; }
        public bool Jalador { get => jalador; set => jalador = value; }
        public bool Escoba { get => escoba; set => escoba = value; }
        public bool Mechudo { get => mechudo; set => mechudo = value; }
        public bool Cubeta { get => cubeta; set => cubeta = value; }
        public string Otro { get => otro; set => otro = value; }
    }
}
