using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreNorthWind.Model.Models
{
    public partial class Products
    {
        [NotMapped]
        public short? UnderstockUnits { 
            get {
                short? elResultado = 0;
                if (! this.Discontinued)
                {
                    if (this.UnitsInStock + this.UnitsOnOrder < this.ReorderLevel)
                        elResultado = (short?)(this.UnitsInStock + 
                            this.UnitsOnOrder - this.ReorderLevel);
                }
                return elResultado;
            } 
            set { } }
        [NotMapped]
        public string CategoryName { 
            get {
                var elResultado = string.Empty;
                if (this.Category != null)
                    elResultado = this.Category.CategoryName;
                return elResultado;
            } 
            set { } }
    }
}
