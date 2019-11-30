using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9CamposK
{ //HOJA
    public abstract class AComponente
    {
        public string fabricante { get; set; }
        public string modelo { get; set; }
        public double precio { get; set; }




        public AComponente(string fabricante, string modelo, double precio) {

            this.fabricante=fabricante;
            this.modelo=modelo;
            this.precio=precio;
        }

    }
}
