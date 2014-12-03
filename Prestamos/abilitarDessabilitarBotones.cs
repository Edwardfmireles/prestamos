using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    class abilitarDessabilitarBotones 
    {
        public programaPrincipal f;

        public abilitarDessabilitarBotones(programaPrincipal formu)
        {
            this.f = formu;

            deshabilitarLimpiarnuevaFactura();
        }

        public void deshabilitarLimpiarnuevaFactura() 
        {
          // NUEVA FACTURA

            this.f.nfnombre.Enabled = false;
            this.f.nfcedula.Enabled = false;
            this.f.nfmonto.Enabled = false;
            this.f.nfperiodopago.Enabled = false;
            this.f.nfmeses.Enabled = false;
            this.f.nfinteres.Enabled = false;
            this.f.nfmora.Enabled = false;
            this.f.nffacturar.Enabled = false;
            this.f.nfCalcularMonto.Enabled = false;

            this.f.nfnumerofactura.Text = "00001";
            this.f.nfnombre.Text = "";
            this.f.nfcedula.Text = "";
            this.f.nfmonto.Text = "";
            this.f.nfperiodopago.Text = "";
            this.f.nfmeses.Text = "";
            this.f.nfinteres.Text = "";
            this.f.nfmora.Text = "";
            this.f.nffechainicial.Text = "";
            this.f.nffechafinal.Text = "";
            this.f.nfMontoTotal.Text = "";




            // ABONO



        }
    }
}
