using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sala_De_Ensayos_Formulario
{
    public partial class SalaDeEnsayos : Form
    {
        CReserva reserva, Mayor = new CReserva();

        public SalaDeEnsayos()
        {
            InitializeComponent();
            InicR.Text = "";
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            reserva = new CReserva(InicR.Text, int.Parse(Duracion.Text), Banda.Text);
            reserva.SetNumeroReserva(ulong.Parse(NumR.Text));
            Mayor = CReserva.MayorMonto(Mayor, reserva);

            Salida.Text = reserva.DarDatos();

            txtReserva.Text = "DATOS DE LA RESERVA";

            InicR.Text = "";
            Duracion.Text = "0";
            Banda.Text = "";
            NumR.Text = "0";
        }



        private void cbDolar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDolar.Checked == true)
            {
                label14.Enabled = true;
                label6.Enabled = true;
                CotizUSD.Enabled = true;
            }
            else
            {
                label14.Enabled = false;
                label6.Enabled = false;
                CotizUSD.Enabled = false;
                CotizUSD.Text = Convert.ToString(0);
            }


        }



        private void btnMayor_Click(object sender, EventArgs e)
        {
            Salida.Text = Mayor.DarDatos();
            txtReserva.Text = "MAYOR RESERVA";
            btnReserva.Enabled = false;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCompartidos_Click(object sender, EventArgs e)
        {
            CReserva.SetCostoHora(float.Parse(CostoH.Text));
            CReserva.SetDescuento(float.Parse(Descuento.Text));

            CReserva.SetCotizacion(float.Parse(CotizUSD.Text));


            panel1.Enabled = false;
            panel2.Enabled = true;
            btnReserva.Enabled = true;
            btnMayor.Enabled = true;
            btnCompartidos.Enabled = false;
        }


    }
}
