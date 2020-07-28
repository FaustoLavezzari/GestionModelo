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
    public partial class Temporizador : Form
    {
        private int totalSegundos;
        public Temporizador()
        {
            InitializeComponent();
        }

        private void Start_Click_1(object sender, EventArgs e)
        {
            this.btn_start.Enabled = false;
            this.btn_stop.Enabled = true;
            int minutos = 0;
            int segundos = 0;
            if (Int32.TryParse(minbox.Text,out minutos) && Int32.TryParse(segbox.Text, out segundos))
            {
                totalSegundos = (minutos * 60) + segundos;
                this.timer1.Enabled = true;
            }
            else
            {                
                MessageBox.Show("Por favor ingrese algún valor válido");
                this.btn_stop.Enabled = false;
                this.btn_start.Enabled = true;
            }            
        }

        private void Stop_Click_1(object sender, EventArgs e)
        {
            this.btn_stop.Enabled = false;
            this.btn_start.Enabled = true;
            this.timer1.Stop();
            this.reloj.Text = "00:00";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (totalSegundos > 0)
            {
                totalSegundos--;
                int minutos = totalSegundos / 60;
                int segundos = totalSegundos - (minutos * 60);

                this.reloj.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
            }
            else
            { 
                this.btn_stop.Enabled = false;
                this.btn_start.Enabled = true;
                this.timer1.Stop();
                MessageBox.Show("Se acabó el tiempo!");
            }
        }
    }
}
