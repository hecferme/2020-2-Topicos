using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreNorthWind.DataAccess.Repositorio
{
    internal class Suppliers
    {
        static Model.Models.NorthWindContext _miContexto = new Model.Models.NorthWindContext();

        public IList<Model.Models.Suppliers> ListAll ()
        {
            var laLista = _miContexto.Suppliers.ToList();
            return laLista;
        }

        public IList<Model.Models.Suppliers> GetSuppliersByName(string elSupplierName)
        {
            var laLista = _miContexto.Suppliers.Where(s => s.CompanyName.Contains(elSupplierName)).ToList();
            return laLista;
        }

        public IList<Model.Models.Products> GetProductsBySupplierId(int elSupplierId)
        {
            var elSupplier = _miContexto.Suppliers.Where
                (s => s.SupplierId == elSupplierId).Include(s=> s.Products).ThenInclude(p => p.Category).FirstOrDefault();
            var laLista = CopiarLista(elSupplier.Products);
            return laLista;
        }

        private List<Model.Models.Products> CopiarLista(ICollection<Model.Models.Products> losProductos)
        {
            var elResultado = new List<Model.Models.Products>();
            foreach (var item in losProductos)
            {
                elResultado.Add(item);
            }
            return elResultado;
        }
    }
}
