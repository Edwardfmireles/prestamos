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
    public partial class buscarCliente : Form
    {
        public buscarCliente()
        {
            InitializeComponent();
        }

        private void bcBusqueda_TextChanged(object sender, EventArgs e)
        {
            TextBox sen = (TextBox)sender;

            if (sen.Text.ToString().Trim() != "" && Convert.ToInt16(bcDataGridView.Rows[0].Cells[0].Value.ToString()) >= 1)
            {
                for (int i = 0; i < bcDataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (bcDataGridView.Rows[i].Cells[j].Value.ToString().Contains(sen.Text.ToString()))
                        {
                            bcDataGridView.Rows[i].Cells[j].Selected = true;
                        }
                    }
                }
            }
        }

        private void bcDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(bcDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
