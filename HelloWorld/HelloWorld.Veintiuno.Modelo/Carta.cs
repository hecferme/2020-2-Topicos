using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HelloWorld.Veintiuno.Modelo
{
    public class Carta
    {
        public Carta(int elNumero, Palo elPalo)
        {
            ElPalo = elPalo;
            Valor = elNumero;
            if (2 <= elNumero && elNumero <= 9)
                Numero = elNumero.ToString();
        }

        public Carta(string elNumero, Palo elPalo)
        {
            this.Numero = elNumero;
            this.ElPalo = elPalo;
            if (elNumero == "J" || elNumero == "Q" || elNumero == "K")
                this.Valor = 10;
            if ('2' <= elNumero[0] && elNumero[0] <= '9')
                this.Valor = (int)elNumero[0];
            if (elNumero == "A")
                this.Valor = 11;
        }
        public string Numero { get; set; }
        public Palo ElPalo { get; set; }
        public int Valor { get; set; }
    }
}
