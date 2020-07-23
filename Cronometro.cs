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
    public partial class Cronometro : Form
    {
        T_prom prom;
        int totalSegundos;
        int minutos;
        int segundos;
        Estrado estrado;
        public Cronometro()
        {
            InitializeComponent();
        }
      
        private void Form5_Load(object sender, EventArgs e)
        {
            totalSegundos = 0;
            estrado = new Estrado();
            prom = new T_prom();
            prom.Show();
            pausar.Enabled = false;
            comenzar.Enabled = true;
            resetear.Enabled = false;
        }
        private void comenzar_Click(object sender, EventArgs e)
        {
            comenzar.Enabled = false;
            pausar.Enabled = true;
            resetear.Enabled = true;
            this.timer1.Enabled = true;
        }

        private void pausar_Click(object sender, EventArgs e)
        {
            pausar.Enabled = false;
            comenzar.Enabled = true;
            resetear.Enabled = true;
        }
        private void resetear_Click(object sender, EventArgs e)
        {
            comenzar.Enabled = true;
            pausar.Enabled = false;
            resetear.Enabled = false;
            this.timer1.Enabled = false;
            this.reloj.Text = "00" + ":" + "00";
            estrado.addTime(totalSegundos);
            totalSegundos = 0;
            estrado.aumentarContador_del();
            minutos = (int)getTiempoProm() / 60;
            segundos = (int)(getTiempoProm() / 60 + getTiempoProm());
            prom.reloj.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
            prom.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int minutos = totalSegundos / 60;
            int segundos = totalSegundos - minutos * 60;
            if (comenzar.Enabled == false)
            {
                totalSegundos++;                
                this.reloj.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
                if ((minutos == 59 && segundos == 59))
                {
                    comenzar.Enabled = true;
                    pausar.Enabled = false;
                    resetear.Enabled = false;
                    totalSegundos = 0;
                    this.timer1.Enabled = false;
                    this.reloj.Text = "00" + ":" + "00";
                    MessageBox.Show("ERROR: Se excedió la capacidad del cronómetro!");
                }
            }
            else
            {
                this.reloj.Text = minutos.ToString("00") + ":" + segundos.ToString("00");
            }
        }

        public double getTiempoProm() 
        {
            return Math.Round(estrado.getSumaTiempos()/estrado.getContador_del());
        }
        
    }
}
