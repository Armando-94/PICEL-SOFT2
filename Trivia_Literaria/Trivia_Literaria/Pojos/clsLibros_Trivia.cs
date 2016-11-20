using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Literaria.Pojos
{
    class clsLibros_Trivia
    {
        private int cId_Libro;
        private int cId_trivia;
        private char cCombo;

        public int Libros_idLibro {
            get {
                return cId_Libro;
            }
            set {
                cId_Libro = value;
            }
        }

        public int Trivias_idTrivias
        {
            get
            {
                return cId_trivia;
            }
            set
            {
                cId_trivia = value;
            }
        }

        public char combo
        {
            get
            {
                return cCombo;
            }
            set
            {
                cCombo = value;
            }
        }
    }
}
