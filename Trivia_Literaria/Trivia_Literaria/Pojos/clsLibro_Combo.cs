using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Literaria.Pojos
{
    class clsLibro_Combo
    {
        private string cLibro;
        private char cCombo;

        public string Libro {
            get {
                return cLibro;
            }
            set {
                cLibro = value;
            }
        }

        public char Combo {
            get {
                return cCombo;
            }
            set {
                cCombo = value;
            }
        }
    }
}
