using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Literaria.Pojos
{
    class clsPreguntasReporte
    {
        private char cCombo;
        private int cId;
        private string cLibro;
        private string cPregunta;
        private string cRespuesta;

        public char Combo {
            get { return cCombo; }
            set { cCombo = value; }
        }

        public int idPreguntas {
            get { return cId; }
            set { cId = value; }
        }

        public string Libro {
            get { return cLibro; }
            set { cLibro = value; }
        }

        public string Pregunta {
            get { return cPregunta; }
            set { cPregunta = value; }
        }

        public string Respuesta {
            get { return cRespuesta; }
            set { cRespuesta = value; }
        }
    }
}
