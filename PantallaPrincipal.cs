﻿using System;
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
        private Delegacion del_selec;
        private InfoDelegacion info_delegacion;
            
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
            List<Form> abiertos = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form is InfoDelegacion || form is asistencia)
                {
                    abiertos.Add(form);
                }
            }
            foreach (Form form1 in abiertos)
            {
                form1.Close();
            }
            panel_principal.Controls.Clear();
            Form asist = form_hija as Form; //se crea un formulario asist
            asist.TopLevel = false;// es un formulario secundario
            asist.Dock = DockStyle.Fill;//se acopla al panel
            this.panel_principal.Controls.Add(asist);//se agrega al panel
            this.panel_principal.Tag = asist;            
            asist.Show();

            
        }        

        private void Delegaciones_MouseClick(object sender, MouseEventArgs e)
        {            
            Delegacion delegacion_seleccionada = sesion.getDelegacion(Delegaciones.SelectedItems[0].Text);
            del_selec = delegacion_seleccionada;
            InfoDelegacion info_del = new InfoDelegacion(delegacion_seleccionada, sesion.getTopicoActivo(), panel_del_Estrado);
            AbrirFormHija3(info_del);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija3(new asistencia(sesion.getDiccionarioPaises()));
        }

        private void terminarPrograma(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void interpelacion_Click(object sender, EventArgs e)
        {
            Interpelacion pregunta = new Interpelacion(del_selec, sesion);
            pregunta.Show();            
        }
    }
}
