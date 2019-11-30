using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9CamposK
{
    class Dispositivo:AComponente

    {
        //1 = Entrada 2= Salida
        public int tipo { get; set; }
        public Dispositivo(string fabricante, string modelo, double precio, int tipo) : base(fabricante, modelo, precio) {

            this.tipo = tipo;


        }
    }
}
