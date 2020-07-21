using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GestiónModelo
{
    public class Valoracion
    {
        private Dictionary<string, float> valoraciones;
        private static float rango = 5f;
        private float total;
    
        public Valoracion()
        {
            valoraciones = new Dictionary<string, float>();
            total = 0f;
        }

        public void valorar(string motivo, float puntaje)
        {
            if (puntaje >= -rango && puntaje <= rango) 
            {
                valoraciones.Add(motivo, puntaje);
                total += puntaje;
            }            
        }

        public Dictionary<string, float> getValoraciones()
        {
            return valoraciones;
        }

        public float getPuntajeTotal()
        {
            return total;
        }

    }
}
