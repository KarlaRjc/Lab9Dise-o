using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9CamposK
{ //COMPUESTO
    class Computadora:AComponente, IComputadora
    {
        private List<AComponente> computadora = new List<AComponente>();

        // Por medio de esta lista nos aseguramos que se está arreglando la computadora
        public Computadora(string fabricante, string modelo, double precio):base(fabricante, modelo, precio) {

        }

        public void AgregarComponente(AComponente componente)
        {
            computadora.Add(componente);

        }
        public void EliminarComponente(AComponente componente)
        {

            computadora.Remove(componente);
        }
        public double CostoTotal
        {
           get {

                double costo = 0;
                foreach (var elemento in computadora)
                {

                    if (elemento.GetType().Name == "Computadora")// si es un compuesto

                        costo += ((Computadora)elemento).CostoTotal;// recursividad

                    else

                        costo += elemento.precio;

                }
                    return costo;
                
            }

        }
    }
}
