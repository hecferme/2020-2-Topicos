using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Trabajo
    {
        public void Realicelo()
        {
            var laClase = new Veintiuno.Naipe.Acciones.Barajar();
            var elMaso = laClase.DemeNuevoMaso();
            var laCarta = elMaso.DemeCartaDeEncima();
            Console.WriteLine(string.Format("La carta es {0} de {1}", laCarta.Numero, laCarta.ElPalo.ToString()));
            Console.ReadLine();
        }
    }
}
