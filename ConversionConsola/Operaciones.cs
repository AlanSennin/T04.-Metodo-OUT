using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionConsola
{
    class Operaciones
    {
        public void Calcular()
        {
            int totalCentavos; //Declaro las variables a usar...
            int Pesos = 0;
            int Centavos = 0;

            Console.WriteLine("Introduce la Cantidad de Centavos:");

            totalCentavos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Convertir(totalCentavos, out Pesos, out Centavos); //Mando a llamar el metodo Convertir con los parametros necesarios

            Console.WriteLine("C: "+Centavos); //Imprimir resultados
            Console.WriteLine(" ");
            Console.WriteLine("P: "+Pesos); //Imprimir resultados

            Console.WriteLine(" ");

            Console.WriteLine("Presione cualquier boton para Salir...");
            Console.ReadKey();
        }

        public void Convertir(int totalCentavos, out int Pesos, out int Centavos)
        {
            Pesos = totalCentavos / 100; //Operacion para calcular los pesos
            Centavos = totalCentavos % 100; //Operacion para calcular el residuo de los centavos
        }
    }
}
