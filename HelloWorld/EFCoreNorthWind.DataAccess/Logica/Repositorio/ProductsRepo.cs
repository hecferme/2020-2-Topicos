using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreNorthWind.DataAccess
{
    internal class ProductsRepo
    {
        static Model.Models.NorthWindContext _miContexto = new Model.Models.NorthWindContext();
        public Model.Models.Products GetProductById (int elProductId)
        {
            var elResultado = _miContexto.Products.Find(elProductId);
            return elResultado;
        }
        public IList<Model.Models.Products> GetProductsByName(string elProductName)
        {    
            var laConsulta = _miContexto.Products.Where
                        (p => p.ProductName.Contains(elProductName));
            laConsulta = _miContexto.Products.OrderBy(p => p.ReorderLevel);
            laConsulta = _miContexto.Products.OrderByDescending(p => p.ProductName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }
    }
}
