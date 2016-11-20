using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia_Literaria.Pojos
{
    class clsLibros
    {
        private string cNombre;
        private string cGenero;
        private string cAutor;

        public string nombre {
            get {
                return cNombre;
            }
            set {
                cNombre = value;
            }
        }

        public string Genero
        {
            get
            {
                return cGenero;
            }
            set
            {
                cGenero = value;
            }
        }

        public string Autor
        {
            get
            {
                return cAutor;
            }
            set
            {
                cAutor = value;
            }
        }
    }
}
