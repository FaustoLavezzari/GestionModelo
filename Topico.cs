using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónModelo
{
    public class Topico
    {
        private List<Delegacion> discursos_leidos;
        private string titulo;

        public Topico(string titulo)
        {
            discursos_leidos = new List<Delegacion>();
            this.titulo = titulo;
        }

        public List<Delegacion> discursosLeidos()
        {
            return discursos_leidos;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public bool leyoDiscurso(Delegacion delegacion)
        {
            return discursos_leidos.Contains(delegacion);
        }
    }
}
