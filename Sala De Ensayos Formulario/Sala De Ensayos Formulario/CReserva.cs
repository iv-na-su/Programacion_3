using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sala_De_Ensayos_Formulario
{
    class CReserva
    {
        //variables miembro de la clase
        private static float Costo_h;
        private static float Descuento;
        private static float Cotizacion;

        //variables miembro de la instancia
        private ulong Num_reserva;
        private string Inic_reserva;
        private int Duracion;
        private string Banda;



        //metodos
        public CReserva()
        {
            this.Inic_reserva = "N";
            this.Duracion = 0;
            this.Banda = "N";
        }

        public CReserva(string ini, int dur, string ban)
        {
            this.Inic_reserva = ini;
            this.Duracion = dur;
            this.Banda = ban;
        }

        public void SetNumeroReserva(ulong numero)
        {
            this.Num_reserva = numero;
        }

        public float GetNumeroReserva()
        {
            return this.Num_reserva;
        }


        public static void SetCostoHora(float monto)
        {
            CReserva.Costo_h = monto;
        }

        public static float GetCostoHora()
        {
            return CReserva.Costo_h;
        }

        public static void SetCotizacion(float monto)
        {
            CReserva.Cotizacion = monto;
        }


        public static void SetDescuento(float porcentaje)
        {
            CReserva.Descuento = porcentaje;
        }

        public static float GetDescuento()
        {
            return CReserva.Descuento;
        }




        /*setters

        public void SetInic(string inic)
        {
            this.Inic_reserva = inic;
        }

        public void SetDuracion(int dur)
        {
            this.Duracion = dur;
        }

        public void SetBanda(string band)
        {
            this.Banda = band;
        }
        */




        /*getters

        public string GetInic()
        {
            return this.Inic_reserva;
        }

        public int GetDuracion()
        {
            return this.Duracion;
        }

        public string GetBanda()
        {
            return this.Banda;
        }

       */



        //CALCULAR MONTO
        public float DarMontoTotal()
        {

            float monto = CReserva.Costo_h;
            float total = monto * this.Duracion;

            if (this.Duracion >= 6)
                return total - (total / (100.0F / CReserva.Descuento));
            else
                return total;
        }


        public float DarMontoTotal(float cot)
        {

            float monto = CReserva.Costo_h;
            float total = monto * this.Duracion;
            total = total / cot;

            if (this.Duracion >= 6)
                return total - (total / (100.0F / CReserva.Descuento));
            else
                return total;
        }



        //CALCULAR MAYOR

        public static CReserva MayorMonto(CReserva act_may, CReserva res1)
        {
            if (act_may.DarMontoTotal() < res1.DarMontoTotal())
                return res1;
            else
                return act_may;
        }





        //MOSTRAR DATOS
        public string DarDatos()
        {
            Console.Write("Desea visualizar el valor en dolares? (SI/NO): ");

            /*if (Console.ReadLine().ToUpper() == "SI")
            {
                Console.Write("Valor de cotizacion del dolar: USD");
                Cotizacion = float.Parse(Console.ReadLine());
            }
            else
                Cotizacion = 0;

                             NO SIRVE PARA EL FORMULARIO*/ 

            string datos = "\nNumero de reserva: " + this.Num_reserva.ToString();
            datos += "\n Inicio de la reserva: " + this.Inic_reserva;
            datos += "\n Nombre de la banda: " + this.Banda;
            datos += "\n Duracion: " + this.Duracion.ToString() + "hs";
            datos += "\n Cuota por hora: $" + CReserva.Costo_h.ToString();

            if (this.Duracion >= 6)
                datos += "\n - Descuento: " + CReserva.Descuento.ToString() + "% - ";
            else
                datos += "\n - Sin Descuento - ";


            if (CReserva.Cotizacion > 0)
                datos += "\n Monto a pagar final en dolares: USD" + this.DarMontoTotal(CReserva.Cotizacion).ToString();
            else
                datos += "\n Monto a pagar final en pesos: $" + this.DarMontoTotal().ToString();



            return datos;
        }


    }
}