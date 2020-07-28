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
    public partial class PantallaPrincipal : Form
    {
        Sesion sesion;
        public PantallaPrincipal(Sesion sesion)
        {
            this.sesion = sesion;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sesión_Load(object sender, EventArgs e)
        {            
            AbrirFormHija(new Temporizador());
            AbrirFormHija2(new Cronometro());            
        }
        private void AbrirFormHija(object form_hija) 
        {
            if (this.panel_tempo.Controls.Count > 0)
                this.panel_tempo.Controls.RemoveAt(0);
            Form tempo = form_hija as Form;
            tempo.TopLevel = false;
            tempo.Dock = DockStyle.Fill;
            this.panel_tempo.Controls.Add(tempo);
            this.panel_tempo.Tag = tempo;
            tempo.Show();
        }

        private void AbrirFormHija2(object form_hija)
        {
            if (this.panel_crono.Controls.Count > 0)
                this.panel_crono.Controls.RemoveAt(0);
            Form tempo = form_hija as Form;
            tempo.TopLevel = false;
            tempo.Dock = DockStyle.Fill;
            this.panel_crono.Controls.Add(tempo);
            this.panel_crono.Tag = tempo;
            tempo.Show();
        }
    }
}
