using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreNorthWind.Model.Models
{
    public partial class Products
    {
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
    }
}
