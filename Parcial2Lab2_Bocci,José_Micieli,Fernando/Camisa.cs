using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Camisa : Prenda
    {
        private bool mangaCorta;

        public Camisa() { }
        public Camisa(bool mangaCorta)
        {
            this.mangaCorta = mangaCorta;
        }

        public bool MangaCorta { get => mangaCorta; set => mangaCorta = value; }
    }
}
