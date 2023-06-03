using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia_De_Turismo
{
    class CPaquete
    {
        private static float Impuesto;

        private uint Num_Paq;
        private string Detalle;
        private float Costo;



        public static void SetImpuesto(float porcentaje)
        {
            CPaquete.Impuesto = porcentaje;
        }


        public CPaquete(uint numero, string descripcion)
        {
            this.Num_Paq = numero;
            this.Detalle = descripcion;
        }


        public void SetCosto(float monto)
        {
            this.Costo = monto;
        }


        public float GetCosto()
        {
            return this.Costo;
        }


        public float DarPrecio()
        {
            return this.Costo * (1F + CPaquete.Impuesto / 100);
        }

        public float DarPrecio(ushort cuotas)
        {
            return this.DarPrecio() * (1 + ((cuotas-1) * 0.1F)); 
        }


        public string DarDatos()
        {
            string datos = "\n Numero de paquete: " + this.Num_Paq.ToString();
            datos += "\tDetalle: " + this.Detalle;
            datos += "\tCosto: $" + this.Costo.ToString();
            datos += "\tImpuesto: " + CPaquete.Impuesto.ToString() + "%";
            datos += "\tPrecio total: $" + this.DarPrecio().ToString();

            return datos;
        }


        public float COSTO
            {
            get { return this.Costo; }
            set { this.Costo = value; }
            }

        public bool EsMasBaratoQue(CPaquete otroPaquete)
        {
            if (this.DarPrecio() < otroPaquete.DarPrecio())
                return true;
            else
                return false;
        }

    }
}
