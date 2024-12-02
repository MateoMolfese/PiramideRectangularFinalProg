using PiramideRectangularFinalProg.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiramideRectangularFinalProg.Windows
{
    public partial class frmPiramideAE : Form
    {
        private PiramideRectangular? piramide;
        public frmPiramideAE()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
