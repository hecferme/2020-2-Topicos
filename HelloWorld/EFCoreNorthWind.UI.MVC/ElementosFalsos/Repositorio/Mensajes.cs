using EFCoreNorthWind.UI.MVC.ModelosFalsos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreNorthWind.UI.MVC.ElementosFalsos.Repositorio
{
    public class Mensajes
    {
        private static IList<Mensaje> _laLista = new List<Mensaje>();

        public void GrabarMensaje (Mensaje losDatos)
        {
            losDatos.FechaDeEnvio = DateTime.Now;
            _laLista.Add(losDatos);
        }

        public IList<Mensaje> ObtenerTodos()
        {
            var elResultado = _laLista;
            return elResultado;
        }

        public Mensaje Obtener(int id)
        {
            var elResultado = _laLista.Where(l => l.Id == id).FirstOrDefault();
            return elResultado;
        }
    }
}
