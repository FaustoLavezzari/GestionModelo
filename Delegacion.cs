using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GestiónModelo
{
    public class Delegacion
    {
        private String nombre;
        private int interpelaciones;
        private int pregResp;
        private Image bandera;
        private bool discurso;
        private bool asistencia;

        public Delegacion(String nombre, Image bandera) {
            this.nombre = nombre;
            interpelaciones = 0;
            pregResp = 0;
            this.bandera = bandera;
            discurso = false;
            asistencia = false;
        }

        public void incrementarInterpelaciones(){  interpelaciones++;  }
        public void incrementarRespuestas(){  pregResp++;  }
        
        //seters

        public void setDiscurso() { discurso = true;  }
        public void setAsistencia() { asistencia = true;  }
        
        //getters

        public String getNombre() { return nombre; }
        public int getInterpelaciones() { return interpelaciones; }
        public int getPregResp() { return pregResp; }
        public bool getDiscurso() { return discurso; }
        public bool getAsistencia() { return asistencia; }
        

    }
}
