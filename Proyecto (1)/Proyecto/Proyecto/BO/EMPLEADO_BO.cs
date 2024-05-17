using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.BO
{
    class EMPLEADO_BO
    {
        private int idusuarioemp;
        private string nombre_usuarioemp;
        private string apellido_paterno;
        private string apellido_materno;
        private string foto;
        private int Edad;
        private string contrasenia;
        private int idturno;
        private int idrol;
        private int idestado;
        private int ID_Colonia;
        private int ID_Ciudad;
        private string calle;
        private string cruzamientos;
        private int casa;
       

        public int Idusuarioemp { get => idusuarioemp; set => idusuarioemp = value; }
        public string Nombre_usuarioemp { get => nombre_usuarioemp; set => nombre_usuarioemp = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public string Foto { get => foto; set => foto = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
       
       
        public int Estado { get => idestado; set => idestado = value; }
        public int ID_Col { get => ID_Colonia; set => ID_Colonia = value; }
        public int IDciudad1 { get => ID_Ciudad; set => ID_Ciudad = value; }
        public int Idturno { get => idturno; set => idturno = value; }
        public int Idrol { get => idrol; set => idrol = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Cruzamientos { get => cruzamientos; set => cruzamientos = value; }
        public int Casa { get => casa; set => casa = value; }
    }
}
