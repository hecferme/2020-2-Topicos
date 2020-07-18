using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreNorthWind.UI.MVC.ModelosFalsos
{
    public class Mensaje
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public DateTime FechaDeEnvio { get; set; }
        public Boolean EsPrivado { get; set; }
        public string MensajeCodificado { 
            get
            { 
                var elResultado = new string('*', Body.Length);
                return elResultado;
            } 
            set { } 
        }

        public string MensajeParaDesplegar
        {
            get
            {
                var elResultado = Body;
                if (this.EsPrivado)
                    elResultado = MensajeCodificado;                    
                return elResultado;
            }
            set { }
        }
    }
}
