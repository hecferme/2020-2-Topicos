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
        public override bool IsValid(object value)
        {
            if (value.GetType() == typeof(int))
            {
                var elNumero = 0;
                if (int.TryParse(value.ToString(), out elNumero))
                {
                    return elNumero % 2 == 0;
                }
            }
                
            return base.IsValid(value);
        }
    }
}
