using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pantalon : Prenda
    {
        private bool bermuda = false;

        public Pantalon() { }

        public Pantalon(bool bermuda)
        {
            this.bermuda = bermuda;
        }

        public bool Bermuda { get => bermuda; set => bermuda = value; }
    }
}
