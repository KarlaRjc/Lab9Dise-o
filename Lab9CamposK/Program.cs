using System;

namespace Lab9CamposK
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmarComputadora();
        }
        public static void ArmarComputadora()
        {
            //hojitas
            AComponente c1 = new UnidadCentral("Intel", "Corei5", 150000);
            AComponente c2 = new Dispositivo("Dell", "Mouse HFG", 5000,1);
            AComponente c3 = new Dispositivo("Dell", "Teclado TSR", 15000,1);
            AComponente c4 = new Dispositivo("Dell", "Monitor DFCF", 10000, 2);


            // compuesto
            Computadora compu =new Computadora("Karla", "Basic", 0);
            compu.AgregarComponente(c1);
            compu.AgregarComponente(c3);
            compu.AgregarComponente(c4);

            //hojitas+compuesto
            Computadora compu2 = new Computadora("Karla", "Basic + Mouse", 0);
            compu2.AgregarComponente(compu);
            compu2.AgregarComponente(c2);

            Console.WriteLine("Costo de la computadora " + compu.modelo+":" + compu.CostoTotal);
            Console.WriteLine("Costo de la computadora " + compu2.modelo + ":" + compu2.CostoTotal);
            Console.ReadLine();
        }
    }
}
