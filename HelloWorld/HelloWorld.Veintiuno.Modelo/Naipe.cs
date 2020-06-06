using System;
using System.Security.Authentication.ExtendedProtection;

namespace HelloWorld.Veintiuno.Modelo
{
    public class Naipe
    {
        private int _contador = 0;
        public void Barajar ()
        {

        }

        public Carta DemeCartaDeEncima()
        {
            return elMaso[_contador++];
        }

        private void CrearCartasDelPalo (ref int contador, ref Carta[] elResultado, Palo elPalo)
        {
            elResultado[contador++] = new Carta("A", elPalo);
            for (int i = 2; i <= 10; i++)
            {
                elResultado[contador++] = new Carta(i, elPalo);
            }
            elResultado[contador++] = new Carta("J", elPalo);
            elResultado[contador++] = new Carta("Q", elPalo);
            elResultado[contador++] = new Carta("K", elPalo);
        }

        private Carta[] _elMaso = new Carta[52];

        public Carta[] elMaso
        {
            get { return _elMaso; }
            set {  }
        }
        public Naipe()
        {
            Carta[] elResultado = new Carta[52];
            int contador = 0;
            CrearCartasDelPalo(ref contador, ref elResultado, Palo.Corazones);
            CrearCartasDelPalo(ref contador, ref elResultado, Palo.Espadas);
            CrearCartasDelPalo(ref contador, ref elResultado, Palo.Diamantes);
            CrearCartasDelPalo(ref contador, ref elResultado, Palo.Treboles);
            /*
             elResultado[contador++] = new Carta("A", Palo.Corazones);
             for (int i = 2; i < 10; i++)
             {
                 elResultado[contador++] = new Carta(i, Palo.Corazones);
             }
             elResultado[contador++] = new Carta("J", Palo.Corazones);
             elResultado[contador++] = new Carta("Q", Palo.Corazones);
             elResultado[contador++] = new Carta("K", Palo.Corazones);

             elResultado[contador++] = new Carta("A", Palo.Espadas);
             for (int i = 2; i < 10; i++)
             {
                 elResultado[contador++] = new Carta(i, Palo.Espadas);
             }
             elResultado[contador++] = new Carta("J", Palo.Espadas);
             elResultado[contador++] = new Carta("Q", Palo.Espadas);
             elResultado[contador++] = new Carta("K", Palo.Espadas);

             elResultado[contador++] = new Carta("A", Palo.Treboles);
             for (int i = 2; i < 10; i++)
             {
                 elResultado[contador++] = new Carta(i, Palo.Treboles);
             }
             elResultado[contador++] = new Carta("J", Palo.Treboles);
             elResultado[contador++] = new Carta("Q", Palo.Treboles);
             elResultado[contador++] = new Carta("K", Palo.Treboles);

             elResultado[contador++] = new Carta("A", Palo.Diamantes);
             for (int i = 2; i < 10; i++)
             {
                 elResultado[contador++] = new Carta(i, Palo.Diamantes);
             }
             elResultado[contador++] = new Carta("J", Palo.Diamantes);
             elResultado[contador++] = new Carta("Q", Palo.Diamantes);
             elResultado[contador++] = new Carta("K", Palo.Diamantes);
             */
            elResultado.CopyTo(elMaso, 0);
            Barajar();
        }

    }
}
