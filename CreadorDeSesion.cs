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
        private Dictionary<string,bool> seleccion;
        private List<string> paises;
        private List<string> topicos;

        public CreadorDeSesion()
        {
            InitializeComponent();
            paises = new List<string>();
            topicos = new List<string>();

            seleccion = new Dictionary<string, bool>();

        }

        private void CreadorDeSesion_Load(object sender, EventArgs e)
        {
            AñadirTopico.Enabled = false;
            AñadirDelegacion.Enabled = false;
            SeleccionarTodo.Visible = true;
            clean.Visible = true;

            string paises = Properties.Resources.paises;
            List<string> lista = paises.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string pais in lista)
            {
                seleccionadorDePaises.Items.Add(pais);
                seleccion.Add(pais,false);
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

        private void SeleccionarTodo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seleccionadorDePaises.Items.Count; i++)
            {  seleccionadorDePaises.SetItemChecked(i, true);   }
               
            foreach (string item in seleccionadorDePaises.Items)
            {              
                seleccion[item] = true;
            }            
        }

        private void buscador_TextChanged(object sender, EventArgs e)
        {
            if (seleccionadorDePaises.FindString(buscador.Text) != ListBox.NoMatches)
            { seleccionadorDePaises.SetSelected(seleccionadorDePaises.FindString(buscador.Text), true); }
           
        }

        private void clean_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < seleccionadorDePaises.Items.Count; i++)
            { seleccionadorDePaises.SetItemChecked(i, false); }

            foreach (string item in seleccionadorDePaises.Items)
            {
                seleccion[item] = false;
            }           
        }

    
        private void seleccionadorDePaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion[(string)seleccionadorDePaises.SelectedItem] = seleccionadorDePaises.GetItemChecked(seleccionadorDePaises.SelectedIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  seleccionadorDePaises.Items.Clear();
            if (comboBox1.Text == "☐")
            {
                foreach (var item in seleccion)
                {
                    seleccionadorDePaises.Items.Add(item.Key, item.Value);
                }
            }
            else
            {    if(comboBox1.Text == "☑")
                { 
                    foreach (var item in seleccion)
                    {
                        if (item.Value == true)
                        { seleccionadorDePaises.Items.Add(item.Key, item.Value); }
                    }
                }
                else
                {
                    foreach (var item in seleccion)
                    {
                        if (item.Value == false)
                        { seleccionadorDePaises.Items.Add(item.Key, item.Value); }
                    }

                }
            }
        }
    }
}