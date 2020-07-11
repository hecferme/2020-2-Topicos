using System;

namespace EFCoreNorthWind.Model.Models
{
    public partial class Suppliers
    {
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string CompanyNameUppercase { get {
                return CompanyName.ToUpper();
            } set { } }
    }
}
