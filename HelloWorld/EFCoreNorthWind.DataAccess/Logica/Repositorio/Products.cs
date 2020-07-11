using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreNorthWind.DataAccess.Repositorio
{
    internal class Products
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
                        (p => p.ProductName.Contains(elProductName)).Include(p => p.Category).OrderBy(p => p.ReorderLevel).OrderByDescending(p => p.ProductName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }
        public IList<Model.Models.Products> GetProductsByPriceRange(decimal? elLimiteInferior, decimal? elLimiteSuperior)
        {
            var laConsulta = _miContexto.Products.Where
                        (p => elLimiteInferior <= p.UnitPrice && p.UnitPrice <= elLimiteSuperior);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

    }
}
