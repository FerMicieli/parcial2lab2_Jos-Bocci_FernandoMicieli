using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Prenda
    {
        private bool calidadPrenda = false;
        private int precio;
        private int cantidadPrendas;

        protected bool CalidadPrenda { get => calidadPrenda; set => calidadPrenda = value; }
        protected int CantidadPrendas { get => cantidadPrendas; set => cantidadPrendas = value; }
        protected int Precio { get => precio; set => precio = value; }

        public Prenda() { }

        public Prenda(bool calidadPrenda, int precio, int cantidadPrendas)
        {
            this.calidadPrenda = calidadPrenda;
            this.precio = precio;
            this.calidadPrenda = calidadPrenda;
        }
    }
}
