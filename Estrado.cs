using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónModelo
{
    class Estrado
    {
        private Delegacion en_estrado;
        private int tiempo_estrado;
        private double sumaTiempos = 0;
        private int contador_del = 0;

        public Estrado(/*Delegacion en_estrado*/){
            //this.en_estrado = en_estrado;
        }
        public void addTime(int tiempo) {
           sumaTiempos += tiempo;
        }
        public void aumentarContador_del() 
        {
            contador_del++;
        }
        public double getSumaTiempos()
        {
            return sumaTiempos;
        }
        public int getContador_del() 
        {
            return contador_del;
        }
    }
}
