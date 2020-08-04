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
    public partial class InfoDelegacion : Form
    {
        
        private Delegacion delegacion;
        private Delegacion delegacion_en_estrado;
        private Topico topico_activo;
        private Panel panel_Est;
        private Sesion sesion;
       
        public InfoDelegacion(Delegacion delegacion, Delegacion delegacion_en_estrado)
        {
            InitializeComponent();
            panel_Est = (Panel)PantallaPrincipal.ActiveForm.Controls.Find("panel_del_Estrado", true)[0];
            this.delegacion = delegacion;
            this.delegacion_en_estrado = delegacion_en_estrado;
            this.sesion = ((PantallaPrincipal)ActiveForm).getSesion();
            this.topico_activo = sesion.getTopicoActivo();
        }

        public void InfoDelegacion_Load(object sender, EventArgs e)
        {
            Bandera.Image =(Image) GestiónModelo.BanderasGrandes.ResourceManager.GetObject(delegacion.getNombre() + "G");
            Nombre.Text = delegacion.getNombre();
            
            if (delegacion.getAsistencia())
                Asistencia.Text = "Presente";
            else
                Asistencia.Text = "Ausente";

            if (topico_activo.leyoDiscurso(delegacion))
                Discurso.Text = "Leido";
            else
                Discurso.Text = "Sin leer";
           
            InterpelacionesRealizadas.Text =  delegacion.getInterpelaciones().ToString();
            InterpelacionesRespondidas.Text = delegacion.getPregResp().ToString();
        }
        private void AbrirFormHija(object form_hija)
        {
            if (this.panel_Est.Controls.Count > 0)
                this.panel_Est.Controls.RemoveAt(0);
            Form del_est = form_hija as Form;
            del_est.TopLevel = false;
            del_est.Dock = DockStyle.Fill;
            this.panel_Est.Controls.Add(del_est);
            this.panel_Est.Tag = del_est;
            del_est.Show();
        }
        private void subir_est_Click(object sender, EventArgs e)
        {
            delegacion_en_estrado = delegacion.copiarDelegacion();
            Del_Estrado del_est = new Del_Estrado();
            del_est.CargarDelegacion(delegacion);            
            AbrirFormHija(del_est);
            ((Button)ActiveForm.Controls.Find("btn_interp", true)[0]).Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_discurso.Text == "Marcar Discurso")
            {
                sesion.getTopicoActivo().discursosLeidos().Add(delegacion);
                btn_discurso.Text = "Desmarcar Discurso";
                btn_discurso.BackColor = Color.YellowGreen;
                ((PantallaPrincipal)PantallaPrincipal.ActiveForm).comboBox1_SelectedIndexChanged(sender, e);
            }
            else {
                sesion.getTopicoActivo().discursosLeidos().Remove(delegacion);
                btn_discurso.Text = "Marcar Discurso";
                btn_discurso.BackColor = DefaultBackColor;
                ((PantallaPrincipal)PantallaPrincipal.ActiveForm).comboBox1_SelectedIndexChanged(sender, e);
            }
        }

        public Delegacion getDelEstrado()
        {
            return delegacion_en_estrado;
        }

        /*public Label getLabelRespondidas()
        {
            return InterpelacionesRespondidas;
        }*/

        public void refreshRespondidas()
        {
            InterpelacionesRespondidas.Refresh();
        }
    }
}
