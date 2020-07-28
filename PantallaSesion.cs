using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónModelo
{
    public partial class PantallaSesion : Form
    {
        private Sesion sesion;
        public PantallaSesion(Sesion sesion)
        {
            this.sesion = sesion;
            InitializeComponent();
        }
    }
}
