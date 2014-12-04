using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prestamos
{
    public partial class programaPrincipal : Form
    {

        private abilitarDessabilitarBotones adb;
        private int quinsenalMensualAnual;
        private int calculoquincenasMensualidadAnual;
        private int meses;
        private List<DateTime> fechas = new List<DateTime>();
        private DateTime[] fechasArray;
        private short cuotas;
        private DateTime dFechaInicial = DateTime.Today;
        private DateTime dFechaFinal;

        public programaPrincipal()
        {
            InitializeComponent();
            nfnombre.Text = "asdkf";
            //adb = new abilitarDessabilitarBotones(this);


 

            nffecha.Text = Convert.ToString(dFechaInicial.Day + "/" + dFechaInicial.Month + "/" + dFechaInicial.Year);
            nffechainicial.Text = nffecha.Text;

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
                nffacturar.Enabled = true;
                nfCalcularMonto.Enabled = true;
            }
        }

        private void nfmonto_TextChanged(object sender, EventArgs e)
        {
            TextBox sen = (TextBox)sender;
            int parse;


            if (!int.TryParse(sen.Text.ToString().Trim(), out this.meses) && this.meses < 1 )
            {
                sen.Text = "";
                nfcuotas.Text = "";
                
            }


            nfCalcularMonto.Visible = true;
            nfMontoTotal.Text = "";
            nfcuotas.Text = "";
        }

        private void nfperiodopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (nfperiodopago.SelectedIndex) 
            {
                case 0:
                    this.quinsenalMensualAnual = 15; // 15 días
                    nfcambiomeses.Text = "Quinsenas";
                    nfmeses.Text = "";
                    nfmeses.Focus();
                    break;
                case 1:
                    this.quinsenalMensualAnual = 30; // 30 días
                    nfcambiomeses.Text = "Meses";
                    nfmeses.Text = "";
                    nfmeses.Focus();
                    break;
                case 2:
                    this.quinsenalMensualAnual = 365; // 365 días
                    nfcambiomeses.Text = "Año(s)";
                    nfmeses.Text = "";
                    nfmeses.Focus();
                    break;
            }
        }

        private void nfmeses_TextChanged(object sender, EventArgs e)
        {
            TextBox sen = (TextBox)sender;

            if (!int.TryParse(sen.Text.ToString().Trim(), out this.meses) && this.meses < 1 || this.meses > 99 || this.meses == 0)
            {
                sen.Text = "";
                nffechafinal.Text = "";
                this.fechasArray = new DateTime[0];
            }
            else
            {

                nfcuotas.Text = "";
                generarfechas(this.meses);

            }


        }

        private void nfinteres_TextChanged(object sender, EventArgs e)
        {
            TextBox sen = (TextBox)sender;

            if (!int.TryParse(sen.Text.ToString().Trim(), out this.meses) && this.meses < 1 || this.meses > 50 || this.meses == 0) 
            {
                sen.Text = "";
                
            }


            nfcuotas.Text = "";
            nfCalcularMonto.Visible = true;
            nfMontoTotal.Text = "";
        }

        private void nfmora_TextChanged(object sender, EventArgs e)
        {
            TextBox sen = (TextBox)sender;

            if (!int.TryParse(sen.Text.ToString().Trim(), out this.meses) && this.meses < 1)
            {
                sen.Text = "";
            }

            nfCalcularMonto.Visible = true;
            nfMontoTotal.Text = "";
        }


        private void nfCalcularMonto_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios() == true)
            {
                nfCalcularMonto.Visible = false;
                genearCuotasYTotal();
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
        }


        private bool validarCamposVacios()
        {
            if (nfmonto.Text.Length > 0)
            {
                if (this.quinsenalMensualAnual == 15 || this.quinsenalMensualAnual == 30 || this.quinsenalMensualAnual == 365)
                {
                    if (nfmeses.Text.Length > 0)
                    {
                        if (nfinteres.Text.Length > 0)
                        {
                            if (nfmora.Text.Length > 0)
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Debe de ingresar la mora");
                                nfmora.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe de ingresar el interés");
                            nfinteres.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe de especificar el tiempo");
                        nfmeses.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe de Elegir un periodo de pago");
                    nfperiodopago.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe de ingresar un monto");
                nfmonto.Focus();
            }

            return false;

        }

        private void generarfechas(int parse)
        {
            this.fechasArray = new DateTime[parse];


            int j = 0;


            fechas.Clear();

            if (this.quinsenalMensualAnual == 15)
            {
                this.calculoquincenasMensualidadAnual = 15 * parse;


                for (int i = 1; i <= parse; i++)
                {
                    fechas.Add(DateTime.Today.AddDays(i * 15));
                }
               

                foreach (var item in fechas)
                {
                    //MessageBox.Show(Convert.ToString(item.Day + "/" + item.Month + "/" + item.Year));


                    this.fechasArray[j] = Convert.ToDateTime(item);
                    j++;
                }


                nffechafinal.Text = Convert.ToString(this.fechasArray[fechas.Count - 1].Day + "/" + this.fechasArray[fechas.Count - 1].Month + "/" + this.fechasArray[fechas.Count - 1].Year);



            }
            else if (this.quinsenalMensualAnual == 30)
            {
                this.calculoquincenasMensualidadAnual = 30 * parse;

                for (int i = 1; i <= parse; i++)
                {
                    fechas.Add(DateTime.Today.AddDays(i * 30));
                }

                foreach (var item in fechas)
                {
                    //MessageBox.Show(Convert.ToString(item.Day + "/" + item.Month + "/" + item.Year));


                    this.fechasArray[j] = Convert.ToDateTime(item);
                    j++;
                }


                nffechafinal.Text = Convert.ToString(this.fechasArray[fechas.Count - 1].Day + "/" + this.fechasArray[fechas.Count - 1].Month + "/" + this.fechasArray[fechas.Count - 1].Year);

            }
            else if (this.quinsenalMensualAnual == 365)
            {
                this.calculoquincenasMensualidadAnual = 12 * parse;

                for (int i = 1; i <= parse; i++)
                {
                    fechas.Add(DateTime.Today.AddDays(i * 365));
                }

                foreach (var item in fechas)
                {
                    this.fechasArray[j] = Convert.ToDateTime(item);
                    j++;
                }


                nffechafinal.Text = Convert.ToString(this.fechasArray[fechas.Count - 1].Day + "/" + this.fechasArray[fechas.Count - 1].Month + "/" + this.fechasArray[fechas.Count - 1].Year);
            }
        }

        public void genearCuotasYTotal()
        {

            float monto = float.Parse(nfmonto.Text);
            float interes = (float.Parse(nfinteres.Text) / 100) * monto;
            float montoT = monto + interes;
            float cuotas = montoT / float.Parse(nfmeses.Text);

            

            nfcuotas.Text = Convert.ToString((Math.Floor(cuotas))) + ".00";

            nfMontoTotal.Text = Convert.ToString((Math.Floor(montoT))) + ".00";

        }


    }
}