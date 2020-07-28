using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiónModelo
{
    public class Sesion
    {
        private Dictionary<string, Delegacion> paises;
        private Dictionary<string, Topico> topicos;
        private Topico topico_activo;

        public Sesion(List<string> paises, List<string> topicos)
        {
            this.paises = new Dictionary<string, Delegacion>();
            this.topicos = new Dictionary<string, Topico>();

            foreach (string pais in paises)
            {
                Delegacion nueva_delegacion = new Delegacion(pais);
                this.paises.Add(pais, nueva_delegacion);
            }

            foreach (string topico in topicos)
            {
                Topico nuevo_topico = new Topico(topico);
                this.topicos.Add(topico, nuevo_topico);
            }

            topico_activo = this.topicos[topicos[0]]; 
        }

        public void setTopicoActivo(Topico topico)
        {
            if (topicos.ContainsValue(topico))
            {
                topico_activo = topico;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public List<Topico> getListaTopicos()
        {
            return topicos.Values.ToList();
        }

        public Topico getTopico(string titulo)
        {
            try
            {
                return topicos[titulo];
            }
            catch (Exception e)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public Topico getTopicoActivo()
        {
            return topico_activo;
        }

        public List<Delegacion> getListaPaises()
        {
            return paises.Values.ToList();
        }

        public Dictionary<string, Delegacion> getDiccionarioPaises()
        {
            return paises;
        }

        public Delegacion getDelegacion(string nombre)
        {
            try
            {
                return paises[nombre];
            }
            catch(Exception e)
            {
                throw new ArgumentOutOfRangeException();
            }
        }


    }
}
