using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BO
{
    class CUBICULOS_BO
    {

        private int idcubiculo;
        private string matricula_cubiculo;
        private string papelera;
        private string papel;
        private string inodoro_roto;
        private string agua;
        private string puerta;
        private int idbanio_hom;
        private int idbanio_muje;

        public int Idcubiculo { get => idcubiculo; set => idcubiculo = value; }
        public string Matricula_cubiculo { get => matricula_cubiculo; set => matricula_cubiculo = value; }
        public string Papelera { get => papelera; set => papelera = value; }
        public string Papel { get => papel; set => papel = value; }
        public string Inodoro_roto { get => inodoro_roto; set => inodoro_roto = value; }
        public string Agua { get => agua; set => agua = value; }
        public string Puerta { get => puerta; set => puerta = value; }
        public int Idbanio_hom { get => idbanio_hom; set => idbanio_hom = value; }
        public int Idbanio_muje { get => idbanio_muje; set => idbanio_muje = value; }
    }
}
