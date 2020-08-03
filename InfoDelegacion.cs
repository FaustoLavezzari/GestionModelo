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
        private Topico topico_activo;
        private Panel panel_Est;
        private Sesion sesion;
        private PantallaPrincipal pant_p;
        public InfoDelegacion(Delegacion delegacion, Topico topico_activo, Panel panel_estrado, Sesion sesion, PantallaPrincipal pp )
        {
            InitializeComponent();
            panel_Est = panel_estrado;
            this.delegacion = delegacion;
            this.topico_activo = topico_activo;
            this.sesion = sesion;
            pant_p = pp;
        }

        private void InfoDelegacion_Load(object sender, EventArgs e)
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
            Del_Estrado del_est = new Del_Estrado();
            del_est.CargarDelegacion(delegacion);
            AbrirFormHija(del_est);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_discurso.Text == "Marcar Discurso")
            {
                sesion.getTopicoActivo().discursosLeidos().Add(delegacion);
                btn_discurso.Text = "Desmarcar Discurso";
                btn_discurso.BackColor = Color.YellowGreen;
                pant_p.comboBox1_SelectedIndexChanged(sender, e);
            }
            else {
                sesion.getTopicoActivo().discursosLeidos().Remove(delegacion);
                btn_discurso.Text = "Marcar Discurso";
                btn_discurso.BackColor = DefaultBackColor;
                pant_p.comboBox1_SelectedIndexChanged(sender, e);
            }
        }
    }
}
