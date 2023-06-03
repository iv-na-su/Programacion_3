using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_De_Turismo
{
    class CEjecutora
    {
        static void Main()
        {
            ushort Numero;
            CPaquete Menor = null, Paquete_act = null;

            Console.Write("Ingresar porcentaje de impuesto de imposiciones brutas: %");
            CPaquete.SetImpuesto(float.Parse(Console.ReadLine()));


            Console.Write("Ingresar el codigo del paquete: ");
            Numero = ushort.Parse(Console.ReadLine());


            while(Numero != 0)
            {
                Console.Write("Ingresar los detalles del paquete: ");
                Paquete_act = new CPaquete (Numero, Console.ReadLine());

                Console.Write("Ingresar costo del paquete: $");
                Paquete_act.SetCosto(float.Parse(Console.ReadLine()));

                if (Menor == null || Paquete_act.EsMasBaratoQue(Menor) == true)
                    Menor = Paquete_act;

                Console.Write("\n\n\n\n"+ Paquete_act.DarDatos());

                Console.Write("\n\n\nIngresar codigo del paquete: ");
                Numero = ushort.Parse(Console.ReadLine());

            }

            if (Menor != null)
            {
                Console.Write("\n\n\n\nEl paquete mas barato es: \n\n" + Menor.DarDatos());
                Console.Write("\n\n\n\nEl valor del paquete en 1 Cuota es : $" + Menor.DarPrecio());
                Console.Write("\n\n\n\nEl valor del paquete en 12 Cuotas es : $" + Menor.DarPrecio(12));
            }
            else
                Console.Write("\n\n\n\nNo se ingresaron paquetes turísticos válidos");

            Console.ReadLine();
        }
    }
}



