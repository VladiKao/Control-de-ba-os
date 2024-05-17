using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.GUI
{
    public partial class Reporte_Baños : Form
    {
        public Reporte_Baños()
        {
            InitializeComponent();
        }

        private void Reporte_Baños_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
