using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections.Generic;

namespace GestiónModelo
{
    public class Delegacion
    {
        private String nombre;
        private int interpelaciones;
        private int pregResp;
        private bool asistencia;
        private Valoracion valoracion;

        public Delegacion(String nombre) {
            this.nombre = nombre;
            interpelaciones = 0;
            pregResp = 0;
            asistencia = false;
            valoracion = new Valoracion(); 
        }

        public void incrementarInterpelaciones(){  interpelaciones++;  }
        public void incrementarRespuestas(){  pregResp++;  }
        
        //seters

        public void setAsistencia() { asistencia = true;  }
        // si se va usar un boton o algo para cambiar la asistencia para evitar errores podriamos negarla,
        //asistemcia=!asistencia; o ponerle como parametro true o false por si se quivoca el usuario
        //lo mismo para discurso 
        
        //getters

        public String getNombre() { return nombre; }
        public int getInterpelaciones() { return interpelaciones; }
        public int getPregResp() { return pregResp; }
        public bool getAsistencia() { return asistencia; }
    }
}
