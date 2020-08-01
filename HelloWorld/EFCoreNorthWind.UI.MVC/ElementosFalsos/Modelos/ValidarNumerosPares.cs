using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreNorthWind.UI.MVC.ElementosFalsos.Modelos
{
    public class ValidarNumeroParAttribute :ValidationAttribute
    {
        private bool _permitirPares = true;
        /// <summary>
        /// Permite validar si un número es par.
        /// </summary>
        public ValidarNumeroParAttribute()
        {

        }
        /// <summary>
        /// Permite valida si un número debe ser par o no.
        /// </summary>
        /// <param name="permitirNumerosPares">false:  No permita números pares
        /// true:  No permita números impares</param>
        public ValidarNumeroParAttribute(bool permitirNumerosPares)
        {
            _permitirPares = permitirNumerosPares;
        }
        public override bool IsValid(object value)
        {
            if (value.GetType() == typeof(int))
            {
                var elNumero = 0;
                if (int.TryParse(value.ToString(), out elNumero))
                {
                    if (_permitirPares)
                        return elNumero % 2 == 0;
                    else
                        return elNumero % 2 != 0;
                }
            }
                
            return base.IsValid(value);
        }
    }
}
