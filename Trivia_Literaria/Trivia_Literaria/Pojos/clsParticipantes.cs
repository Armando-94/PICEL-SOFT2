using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Literaria.Pojos
{
    class clsParticipantes
    {
        private int cId_participante;
        private int cId_equipo;
        private string cNombre;
        private string cLibroDeseado;

        public int id_participante {
            get {
                return cId_participante;
            }
            set {
                cId_participante = value;
            }
        }

        public int id_equipo
        {
            get
            {
                return cId_equipo;
            }
            set
            {
                cId_equipo= value;
            }
        }

        public string Nombre
        {
            get
            {
                return cNombre;
            }
            set
            {
                cNombre = value;
            }
        }

        public string LibroDeseado
        {
            get
            {
                return cLibroDeseado;
            }
            set
            {
                cLibroDeseado = value;
            }
        }
    }
}
