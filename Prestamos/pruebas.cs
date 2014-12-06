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
    public partial class pruebas : Form
    {
        public pruebas()
        {
            InitializeComponent();


            DateTime t = DateTime.Today;
            DateTime n = DateTime.Now;

            

            MessageBox.Show( n.ToString("yyyy-mm-dd"));

        }
    }
}
