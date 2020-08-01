using EFCoreNorthWind.UI.MVC.ElementosFalsos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreNorthWind.UI.MVC.ModelosFalsos
{
    //[MetadataType (typeof (MensajeMetadata))]
    public partial class Mensaje
    {
        [Required]
        [Range(0, 100)]
        [ValidarNumeroPar(true, ErrorMessage ="El número debe ser par.")]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        [DataType(DataType.Password)]
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
