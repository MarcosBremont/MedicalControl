using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalControl
{
    public partial class FrmPantallaCarga : Form
    {
        public int move = 0;
        public FrmPantallaCarga()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

       
            panelslide.Width += 2;
            if (panelslide.Width > 270)
            {
                panelslide.Width = 0;
            }
            if (panelslide.Width < 0)
            {
                move = 2;
            }
        }

        private void FrmPantallaCarga_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
