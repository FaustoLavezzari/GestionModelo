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

        private List<string> paises;
        private List<string> topicos;

        public CreadorDeSesion()
        {
            InitializeComponent();
            paises = new List<string>();
            topicos = new List<string>();
        }

        private void CreadorDeSesion_Load(object sender, EventArgs e)
        {
            AñadirTopico.Enabled = false;
            AñadirDelegacion.Enabled = false;

            string paises = Properties.Resources.paises;
            List<string> lista = paises.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string pais in lista)
            {
                seleccionadorDePaises.Items.Add(pais);
            }
        }

        private void ChequeoTexto(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text != null)
            {
                if (textBox.Equals(NombreDelegacion))
                {
                    AñadirDelegacion.Enabled = true;
                }
                else
                {
                    AñadirTopico.Enabled = true;
                }
            }
        }

        private void AñadirNuevaDelegacion(object sender, EventArgs e)
        {
            paises.Add(NombreDelegacion.Text);
            DelegacionesAñadidas.Items.Add(NombreDelegacion.Text);
            NombreDelegacion.Text = null;
        }

        private void AñadirNuevoTopico(object sender, EventArgs e)
        {
            topicos.Add(NombreTopico.Text);
            TopicosAñadidos.Items.Add(NombreTopico.Text);
            NombreTopico.Text = null;
        }

        private void CrearNuevaSesion(object sender, EventArgs e)
        {
            foreach (string seleccionado in seleccionadorDePaises.CheckedItems)
            {
                paises.Add(seleccionado);
            }
            if (topicos.Count == 0)
            {
                topicos.Add("Debate");
            }

            Sesion sesion = new Sesion(paises, topicos);
            PantallaPrincipal pantalla = new PantallaPrincipal(sesion);
            pantalla.Show();
            this.Close();

        }
    }
}