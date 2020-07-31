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
        private Sesion sesion;


        public PantallaPrincipal(Sesion sesion)
        {
            this.sesion = sesion;
            InitializeComponent();
        }

        private void Sesión_Load(object sender, EventArgs e)
        {            
            AbrirFormHija(new Temporizador());
            AbrirFormHija2(new Cronometro());

            //Carga ListView de delegaciones

            ImageList iconos = new ImageList();
            iconos.ImageSize = new Size(30, 30);

            int cont = 0;
            foreach (Delegacion delegacion in sesion.getListaPaises())
            {               
                iconos.Images.Add(delegacion.getBandera());
                ListViewItem listViewItem = new ListViewItem(delegacion.getNombre(), cont);
                Delegaciones.Items.Add(listViewItem);
                cont++;
            }           
            Delegaciones.SmallImageList = iconos;  
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
        private void AbrirFormHija3(object form_hija)
        {
            if (this.panel_principal.Controls.Count > 0)  
                this.panel_principal.Controls.RemoveAt(0);//si hay algun control en el panel se elimina
            Form asist = form_hija as Form; //se crea un formulario asist
            asist.TopLevel = false;// es un formulario secundario
            asist.Dock = DockStyle.Fill;//se acopla al panel
            this.panel_principal.Controls.Add(asist);//se agrega al panel
            this.panel_principal.Tag = asist;
            asist.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija3(new asistencia(sesion.getDiccionarioPaises()));
        }

        private void terminarPrograma(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
