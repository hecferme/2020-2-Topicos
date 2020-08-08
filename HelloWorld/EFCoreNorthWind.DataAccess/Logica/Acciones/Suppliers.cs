using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreNorthWind.DataAccess.Logica.Acciones
{
    public class Suppliers
    {
        public IList<Model.Models.Suppliers> ListAll()
        {
            var elRepositorio = new Repositorio.Suppliers();
            var elResultado = elRepositorio.ListAll();
            return elResultado;
        }
        public IList<Model.Models.Suppliers> GetSuppliersByName(string elSupplierName)
        {
            var elRepositorio = new Repositorio.Suppliers();
            var elResultado = elRepositorio.GetSuppliersByName(elSupplierName);
            return elResultado;
        }
        public IList<Model.Models.Products> GetProductsBySupplierId(int elSupplierId)
        {
            var elRepositorio = new Repositorio.Suppliers();
            var elResultado = elRepositorio.GetProductsBySupplierId(elSupplierId);
            return elResultado;
        }

    }
}
