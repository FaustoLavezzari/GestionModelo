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
using System.Security.Policy;

namespace GestiónModelo
{
    public class Delegacion
    {
        private String nombre;
        Image bandera;
        private int interpelaciones;
        private int pregResp;
        private bool asistencia;
        List <Valoracion> valoraciones;

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
            valoraciones = new List<Valoracion>();
        }
        
        public void incrementarInterpelaciones() { interpelaciones++; }
        public void incrementarRespuestas() { pregResp++; }

        //seters

        public void setAsistencia(bool a) { asistencia =a; }
        public void Valorar(string motivo, float puntaje)
        {
            Valoracion valoracion = new Valoracion(motivo, puntaje);
            valoraciones.Add(valoracion);
        }
   

        //getters
        public Image getBandera() { return bandera; }
        public String getNombre() { return nombre; }
        public int getInterpelaciones() { return interpelaciones; }
        public int getPregResp() { return pregResp; }
        public bool getAsistencia() { return asistencia; }
        public List<Valoracion> getValoraciones() { return valoraciones; }

        public float getPuntajeTotal()
        {
            float total = 0;
            foreach(Valoracion valoracion in valoraciones)
            {
                total += valoracion.getPuntos();
            }

            return total;
        }

        public Delegacion copiarDelegacion() 
        {
            Delegacion aux = new Delegacion(this.getNombre(), this.getBandera());
            return aux;
        }

    }

    public class Valoracion
    {
        private string motivo;
        private float puntos;

        public Valoracion(string motivo,float puntos)
        {
            this.motivo = motivo;
            this.puntos = puntos;
        }

        public string getMotivo()
        {
            return motivo;
        }

        public float getPuntos()
        {
            return puntos;
        }
        
    }

}
