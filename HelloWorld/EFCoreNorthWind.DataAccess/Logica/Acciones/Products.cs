using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreNorthWind.DataAccess.Logica.Acciones
{
    public class Products
    {
        // wrap
        public Model.Models.Products GetProductById(int elProductId)
        {
            var elRepositorio = new DataAccess.Repositorio.Products ();
            var elResultado = elRepositorio.GetProductById(elProductId);
            return elResultado;
        }
        public IList<Model.Models.Products> GetProductsByName(string elProductName)
        {
            var elRepositorio = new DataAccess.Repositorio.Products();
            var elResultado = elRepositorio.GetProductsByName(elProductName);
            return elResultado;
        }
        public IList<Model.Models.Products> GetProductsByPriceRange(decimal? elLimiteInferior, decimal? elLimiteSuperior)
        {
            var elRepositorio = new DataAccess.Repositorio.Products();
            var elResultado = elRepositorio.GetProductsByPriceRange(elLimiteInferior, elLimiteSuperior);
            return elResultado;
        }

    }
}
