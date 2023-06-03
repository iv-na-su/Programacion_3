using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_viajes
{
    class CEjecutora
    {
        static void Main()
        {
            string Dominio_act;
            CViaje Viaje_act = null, Mayor_R = null;


            Console.Write("Ingresar el costo por kilometro: $");
            CViaje.SetCosto_Km(Convert.ToSingle(Console.ReadLine()));

            Console.Write("Ingresar el kilometraje minimo: ");
            CViaje.SetKm_Min(Convert.ToUInt16(Console.ReadLine()));

            Console.Write("Ingresar dominio(Finaliza con Fin): ");
            Dominio_act = Console.ReadLine();

            while (Dominio_act.ToUpper() != "FIN")
            {

                Console.Write("Ingresar distancia recorrida: ");

                Viaje_act = new CViaje(Dominio_act, Convert.ToUInt16(Console.ReadLine()));

                if (Mayor_R == null || Viaje_act.MayorDistancia(Mayor_R) > 0)
                    Mayor_R = Viaje_act;

                Console.Write(Viaje_act.DarDatos());

                Console.Write("\n\n\n\n\nIngresar dominio(Finaliza con Fin): ");
                Dominio_act = Console.ReadLine();
            }


            if (Mayor_R != null)
                Console.Write("\n\n\nEl viaje mas largo es: " + Mayor_R.DarDatos());
            else
                Console.Write("\n\n\nNo se ingresaron viajes válidos");


            Console.Write("\n\n\n\n\nPulse ENTER para finalizar");
            Console.ReadLine();
        }
    }
}
