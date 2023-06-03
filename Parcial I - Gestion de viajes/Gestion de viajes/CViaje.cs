using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_viajes
{
    class CViaje
    {

        private static float Costo_Km;
        private static ushort Km_Min;
        private string Dominio;
        private ushort Distancia_R;



        public static void SetCosto_Km(float costo)
        {
            CViaje.Costo_Km = costo;
        }


        public static float GetCosto_Km()
        {
            return CViaje.Costo_Km;
        }


        public static void SetKm_Min(ushort minimo)
        {
            CViaje.Km_Min = minimo;
        }

        public static ushort GetKm_Min()
        {
            return CViaje.Km_Min;
        }


        public CViaje()
        {
            this.Dominio = "XX XXX XX";

        }

        public CViaje(string domin, ushort recorrida)
        {
            this.Dominio = domin;
            this.Distancia_R = recorrida;
        }


        public void SetDominio(string domin)
        {
            this.Dominio = domin;
        }


        public string GetDominio()
        {
            return this.Dominio;
        }


        public ushort Kilometraje
        {
            get { return this.Distancia_R; }
            set { this.Distancia_R = value; }
        }


        public float DarCosto()
        {
            if (this.Distancia_R <= CViaje.Km_Min)
                return CViaje.Costo_Km * CViaje.Km_Min;
            else
                return this.Distancia_R * CViaje.Costo_Km;
        }


        public float DarCosto(float peajes)
        {
            if (this.Distancia_R <= CViaje.Km_Min)
                return (CViaje.Costo_Km * CViaje.Km_Min) + peajes;
            else
                return (this.Distancia_R * CViaje.Costo_Km) + peajes;
        }


        public string DarDatos()
        {
            string datos = "\n\n\n\nDominio: " + this.Dominio;
            datos += "\tDistancia recorrida: " + Convert.ToString(this.Distancia_R) + "km";
            datos += "\tCosto por Kilometro: $" + Convert.ToString(CViaje.Costo_Km);
            datos += "\tKilometraje minimo: " + Convert.ToString(CViaje.Km_Min) + "km";
            datos += "\tCosto total del viaje: $" + Convert.ToString(DarCosto());

            return datos;
        }

        public int MayorDistancia(CViaje OtroViaje)
        {
            return this.Distancia_R - OtroViaje.Distancia_R; //devuelve un resultado negativo si OtroViaje tiene mas kilometros, y positivo si el viaje actual tiene mas kilometros
        }


    }
}
