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

        public InfoDelegacion(Delegacion delegacion, Topico topico_activo)
        {
            InitializeComponent();
            this.delegacion = delegacion;
            this.topico_activo = topico_activo;
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
    }
}
