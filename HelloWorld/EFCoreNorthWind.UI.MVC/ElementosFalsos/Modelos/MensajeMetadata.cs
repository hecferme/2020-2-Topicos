using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreNorthWind.UI.MVC.ModelosFalsos
{
    public class MensajeMetadata
    {
        [Required]
        [Range(0,100)]
        public int Id { get; set; }
        [Required]
        public string From { get; set; }
        public string To { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Body { get; set; }
        public object FechaDeEnvio { get; set; }
        public object EsPrivado { get; set; }
        public object MensajeCodificado { get; set; }
        public object MensajeParaDesplegar { get; set; }
    }
}