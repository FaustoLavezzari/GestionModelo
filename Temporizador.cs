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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = true;

            int minutos = int.Parse(minbox.Text);
            int segundos = int.Parse(segbox.Text);

            totalSegundos = (minutos * 60) + segundos;

            this.timer1.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            this.button1.Enabled = true;
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
                this.button2.Enabled = false;
                this.button1.Enabled = true;
                this.timer1.Stop();
                MessageBox.Show("Se acabó el tiempo!");
            }
        }
    }
}
