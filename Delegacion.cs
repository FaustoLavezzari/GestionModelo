using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Resources;

namespace GestiónModelo
{
    public class Delegacion
    {
        private String nombre;
        Image bandera;
        private int interpelaciones;
        private int pregResp;
        private bool asistencia;
        Valoracion valoracion;

        public Delegacion(String nombre, Image bandera)
        {
            if (bandera == null)
                this.bandera = Banderas.Default;
            else
                this.bandera = bandera;
            this.nombre = nombre;
            interpelaciones = 0;
            pregResp = 0;
            asistencia = false;
            valoracion = new Valoracion();
        }
        
        public void incrementarInterpelaciones() { interpelaciones++; }
        public void incrementarRespuestas() { pregResp++; }

        //seters

        public void setAsistencia(bool a) { asistencia =a; }
   

        //getters
        public Image getBandera() { return bandera; }
        public String getNombre() { return nombre; }
        public int getInterpelaciones() { return interpelaciones; }
        public int getPregResp() { return pregResp; }
        public bool getAsistencia() { return asistencia; }
        public Valoracion getValoracion() { return valoracion; }

    }
}
