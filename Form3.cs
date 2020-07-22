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
    public partial class CreadorDeSesion : Form
    {
        public CreadorDeSesion()
        {
            InitializeComponent();
        }

        private void CreadorDeSesion_Load(object sender, EventArgs e)
        {
            string paises = Properties.Resources.paises;
            List<string> lista = paises.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string pais in lista)
            {
                seleccionadorDePaises.Items.Add(pais);
            }
        }
    }
}
