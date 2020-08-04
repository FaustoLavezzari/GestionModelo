using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónModelo
{
    public partial class PantallaPrincipal : Form
    {
        private Sesion sesion;
        private Delegacion delegacion_seleccionada;

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
                cargar_ItemView(delegacion, cont);

                cont++;
            }
            control.SmallImageList = iconos;

            MostrarControlesInfoDelegacion(false);           
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
            MostrarControlesInfoDelegacion(false);
            Form asist = form_hija as Form; //se crea un formulario asist
            asist.TopLevel = false;// es un formulario secundario
            asist.Dock = DockStyle.Fill;//se acopla al panel
            this.panel_principal.Controls.Add(asist);//se agrega al panel
            this.panel_principal.Tag = asist;
            asist.Show();
        }

        // Sección Info delegación
        private void MostrarControlesInfoDelegacion(bool activar_desactivar)
        {
            foreach (Control control in panel_principal.Controls)
            {

                if (activar_desactivar)
                {
                    control.Visible = true;
                }
                else
                {
                    control.Visible = false;
                }
                if (control is Form && activar_desactivar)
                {
                    panel_principal.Controls.Remove(control);
                    Form form = (Form)control;
                    form.Close();
                }
            }

        }
        private void Delegaciones_MouseClick(object sender, MouseEventArgs e)
        {
            MostrarControlesInfoDelegacion(true);
            delegacion_seleccionada = sesion.getDelegacion(control.SelectedItems[0].Text);
            
            Bandera.Image = (Image)GestiónModelo.BanderasGrandes.ResourceManager.GetObject(delegacion_seleccionada.getNombre() + "G");
            Nombre.Text = delegacion_seleccionada.getNombre();

            if (delegacion_seleccionada.getAsistencia())
                Asistencia.Text = "Presente";
            else
                Asistencia.Text = "Ausente";

            if (sesion.getTopicoActivo().leyoDiscurso(delegacion_seleccionada))
                LeyoDiscurso.Text = "Leido";
            else
                LeyoDiscurso.Text = "Sin leer";

            InterpelacionesRealizadas.Text = delegacion_seleccionada.getInterpelaciones().ToString();
            InterpelacionesRespondidas.Text = delegacion_seleccionada.getPregResp().ToString();
        }

        private void AbrirFormHija4(object form_hija)
        {
            if (this.panel_del_Estrado.Controls.Count > 0)
                this.panel_del_Estrado.Controls.RemoveAt(0);
            Form del_est = form_hija as Form;
            del_est.TopLevel = false;
            del_est.Dock = DockStyle.Fill;
            this.panel_del_Estrado.Controls.Add(del_est);
            this.panel_del_Estrado.Tag = del_est;
            del_est.Show();
        }

        private void SubirAlEstrado(object sender, EventArgs e)
        {
            Del_Estrado del_est = new Del_Estrado();
            del_est.CargarDelegacion(sesion.getDelegacion(delegacion_seleccionada.getNombre()));
            AbrirFormHija4(del_est);
        }

        private void MarcarDiscurso(object sender, EventArgs e)
        {
            if (btn_discurso.Text == "Marcar Discurso")
            {
                sesion.getTopicoActivo().discursosLeidos().Add(delegacion_seleccionada);
                btn_discurso.Text = "Desmarcar Discurso";
                btn_discurso.BackColor = Color.YellowGreen;
                comboBox1_SelectedIndexChanged(sender, e);

                LeyoDiscurso.Text = "Leido";
            }
            else
            {
                sesion.getTopicoActivo().discursosLeidos().Remove(delegacion_seleccionada);
                btn_discurso.Text = "Marcar Discurso";
                btn_discurso.BackColor = DefaultBackColor;
                comboBox1_SelectedIndexChanged(sender, e);

                LeyoDiscurso.Text = "Sin leer";
            }
        }
        // Fin sección info delegación
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarControlesInfoDelegacion(false);
            AbrirFormHija3(new asistencia(sesion.getDiccionarioPaises()));
        }

        private void terminarPrograma(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void interpelacion_Click(object sender, EventArgs e)
        {
            Interpelacion pregunta = new Interpelacion(delegacion_seleccionada, sesion);
            pregunta.Show();
        }
        private void cargar_ItemView(Delegacion delegacion, int cont)// delegacion y posicion a añadir a listView
        {   
            string simb = "";
            ListViewItem listViewItem = new ListViewItem(delegacion.getNombre(), cont);
            if (sesion.getTopicoActivo().leyoDiscurso(delegacion) == true) { simb = "✓"; }
            listViewItem.SubItems.Add(simb);
            listViewItem.SubItems.Add((delegacion.getPregResp()).ToString());
            listViewItem.SubItems.Add((delegacion.getPregResp()).ToString());
            listViewItem.SubItems.Add((delegacion.getValoracion().getPuntajeTotal()).ToString());

            control.Items.Add(listViewItem);
        }
    


        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
            control.Items.Clear();
            //Carga ListView de delegaciones

            ImageList iconos = new ImageList();
            iconos.ImageSize = new Size(30, 30);
           
            int cont = 0;
            if (filtro.Text == "Presentes")
            {
                foreach (Delegacion delegacion in sesion.getListaPaises())
                {
                    if (delegacion.getAsistencia())
                    {
                        iconos.Images.Add(delegacion.getBandera());
                        cargar_ItemView(delegacion, cont);
                        cont++;
                    }


                }
            }
            else if (filtro.Text == "Sin leer Discurso")
            {
                foreach (Delegacion delegacion in sesion.getListaPaises())
                {
                    if (sesion.getTopicoActivo().leyoDiscurso(delegacion) == false)
                    {
                        iconos.Images.Add(delegacion.getBandera());
                        cargar_ItemView(delegacion, cont);
                        cont++;
                    }


                }
            }
            else 
            {
                   foreach (Delegacion delegacion in sesion.getListaPaises())
                   {
                      iconos.Images.Add(delegacion.getBandera());
                      cargar_ItemView(delegacion, cont);
                      cont++;
                   }
            }
        
            control.SmallImageList = iconos;
        }

        private void control_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.control.ListViewItemSorter = new ListViewItemComparer(e.Column);

        }

        // implementar el sorting manualmente / personalizado 
        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {     
            control.Items.Clear();
            //Carga ListView de delegaciones

            ImageList iconos = new ImageList();
            iconos.ImageSize = new Size(30, 30);

            int cont = 0;
           foreach (Delegacion delegacion in sesion.getListaPaises())

            {  //quitamos acentos AL NOMBRE DE DELEGACION y espacion que  perjudiquen la busqueda
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                string nombre = delegacion.getNombre().ToLower().Trim();
                string nombreNormalizado = nombre.Normalize(NormalizationForm.FormD);
                string nombreSinAcento = reg.Replace(nombreNormalizado, "");
                //quitamos acentos AL TEXTO DE BUSQUEDA y espacion que  perjudiquen la busqueda
                Regex reg1 = new Regex("[^a-zA-Z0-9 ]");
                string texto = buscador.Text.ToLower().Trim();
                string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
                string textoSinAcento = reg1.Replace(textoNormalizado, "");



                if (nombreSinAcento.StartsWith(textoSinAcento))   
                {
                    iconos.Images.Add(delegacion.getBandera());
                    cargar_ItemView(delegacion, cont);
                   cont++;
                }
             

            }
           
            control.SmallImageList = iconos;
        }
    }
}
