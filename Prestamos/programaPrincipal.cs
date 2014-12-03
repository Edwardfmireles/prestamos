using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class programaPrincipal : Form
    {

        private abilitarDessabilitarBotones adb;
        private short quinsenalMensualAnual;
        private short calculoquincenasMensualidadAnual;
        private int montoTotal;
        private short cuotas;

        public programaPrincipal()
        {
            InitializeComponent();
            nfnombre.Text = "asdkf";
            //adb = new abilitarDessabilitarBotones(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void programaPrincipal_Load(object sender, EventArgs e)
        {
            dropregistrarClientes.Visible = false;
            dropeliminarcliente.Visible = false;
            groupactualizarcliente.Visible = false;
            groupabono.Visible = false;
            groupnuevafactura.Visible = false;
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dropregistrarClientes.Visible = true;
            dropeliminarcliente.Visible = false;
            groupactualizarcliente.Visible = false;
            groupabono.Visible = false;
            groupnuevafactura.Visible = false;

            this.ClientSize = new System.Drawing.Size(751, dropregistrarClientes.Height + 20);
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dropeliminarcliente.Visible = true;
            dropregistrarClientes.Visible = false;
            groupactualizarcliente.Visible = false;
            groupabono.Visible = false;
            groupnuevafactura.Visible = false;

            this.ClientSize = new System.Drawing.Size(751, dropeliminarcliente.Height + 20);

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dropregistrarClientes.Visible = false;
            dropeliminarcliente.Visible = false;
            groupactualizarcliente.Visible = true;
            groupabono.Visible = false;
            groupnuevafactura.Visible = false;

            this.ClientSize = new System.Drawing.Size(751,groupactualizarcliente.Height + 20);
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dropregistrarClientes.Visible = false;
            dropeliminarcliente.Visible = false;
            groupactualizarcliente.Visible = false;
            groupabono.Visible = false;
            groupnuevafactura.Visible = true;
            this.nfbuscarcliente.Focus();
            this.ClientSize = new System.Drawing.Size(751, groupnuevafactura.Height + 20);

            
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dropregistrarClientes.Visible = false;
            dropeliminarcliente.Visible = false;
            groupactualizarcliente.Visible = false;
            groupabono.Visible = true;
            groupnuevafactura.Visible = false;

            this.ClientSize = new System.Drawing.Size(751, groupabono.Height + 20);
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void nfbuscarcliente_Click(object sender, EventArgs e)
        {
            buscarCliente bc = new buscarCliente(this);
            bc.ShowDialog();
        }

        private void nfnombre_TextChanged(object sender, EventArgs e)
        {
            if (nfnombre.Text.Length > 0)
            {
                nfmonto.Enabled = true;
                nfperiodopago.Enabled = true;
                nfmeses.Enabled = true;
                nfinteres.Enabled = true;
                nfmora.Enabled = true;
            }
        }

        private void nfmonto_TextChanged(object sender, EventArgs e)
        {
            TextBox sen = (TextBox)sender;
            int parse;


            if (!int.TryParse(sen.Text.ToString().Trim(), out parse) && parse < 1)
            {
                sen.Text = "";
            }

        }

        private void nfperiodopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (nfperiodopago.SelectedText) 
            {
                case "QUINCENAL":
                    this.quinsenalMensualAnual = 15; 
                    nfcambiomeses.Text = "Quinsenas";
                    break;
                case "MENSUAL":
                    this.quinsenalMensualAnual = 30; // 30 días
                    nfcambiomeses.Text = "Meses";
                    break;
                case "ANUAL":
                    this.quinsenalMensualAnual = 365; // 365 días
                    nfcambiomeses.Text = "Año(s)";
                    break;
            }
        }

        private void nfmeses_TextChanged(object sender, EventArgs e)
        {
            TextBox sen = (TextBox)sender;
            int parse;


            if (!int.TryParse(sen.Text.ToString().Trim(), out parse) && parse < 1)
            {
                sen.Text = "";
            }



            if (this.quinsenalMensualAnual == 15)
            {
                if (parse > 999) sen.Text = ""; // si es quincenal y el 
            }
            else if (this.quinsenalMensualAnual == 30)
            {
                if (parse < 999 && parse > 20000) sen.Text = "";
            }
            else if(this.quinsenalMensualAnual == 365)
            {
                if (parse < 20000) sen.Text = "";
            }



        }

        private void nfinteres_TextChanged(object sender, EventArgs e)
        {
            TextBox sen = (TextBox)sender;
            int parse;


            if (!int.TryParse(sen.Text.ToString().Trim(), out parse) && parse < 1)
            {
                sen.Text = "";
            }
        }

        private void nfmora_TextChanged(object sender, EventArgs e)
        {
            TextBox sen = (TextBox)sender;
            int parse;


            if (!int.TryParse(sen.Text.ToString().Trim(), out parse) && parse < 1)
            {
                sen.Text = "";
            }
        }

        private void nffacturar_Click(object sender, EventArgs e)
        {

        }

        private void nfcancelar_Click(object sender, EventArgs e)
        {
            groupnuevafactura.Visible = false;
            adb = new abilitarDessabilitarBotones(this);
            nfperiodopago.SelectedIndex = -1;
            nfnombre.Text = "asd";
        }
    }
}