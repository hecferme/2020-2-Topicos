using EFCoreNorthWind.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Trabajo
    {
        public void RealiceConsultasNorthWind()
        {
            var laOpcionSeleccionada = string.Empty;
            while (laOpcionSeleccionada != "X")
            {
                DesplegarMenu();
                laOpcionSeleccionada = Console.ReadLine();
                switch (laOpcionSeleccionada)
                {
                    case "1":
                        ConsultarArticuloPorId();
                        break;
                    default:
                        break;
                }
            }
        }

        private void ConsultarArticuloPorId()
        {
            Console.Write("Digite el código de artículo: ");
            var elCodigoDeArticuloString = Console.ReadLine();
            int elCodigoDeArticulo;
            if (int.TryParse(elCodigoDeArticuloString, out elCodigoDeArticulo))
            {
                var elCliente = new EFCoreNorthWind.DataAccess.Logica.Acciones.Products();
                var elArticulo = elCliente.GetProductById(elCodigoDeArticulo);
                if (elArticulo != null)
                    ImprimaCaracteristicasDelArticulo(elArticulo);
                else
                    Console.WriteLine(string.Format("El artículo con código [{0}] no se encontró en la tabla..", elCodigoDeArticuloString));
            }
            else
                Console.WriteLine("Error al convertir a número.");
        }

        private void ImprimaCaracteristicasDelArticulo(Products elArticulo)
        {
            Console.WriteLine("Datos del artículo");
            Console.WriteLine(string.Format("{0}: [{1}]; {2}: [{3}]; {4}: [{5}];", 
                "Nombre", elArticulo.ProductName, 
                "Precio unitario", elArticulo.UnitPrice, 
                "Descontinuado", elArticulo.Discontinued.ToString() ));
            Console.WriteLine("Presione Enter para continuar...");
        }

        private void DesplegarMenu()
        {
            Console.WriteLine("Menú Principal");
            Console.WriteLine("1. Buscar producto por Id.");
            Console.WriteLine("2. Buscar productos por nombre.");
            Console.WriteLine("3. Buscar productos por rango de precio.");
            Console.WriteLine("X. Salir");
            Console.WriteLine("Digite su opción: ");
        }

        public void Realicelo()
        {
            var laClase = new Veintiuno.Naipe.Acciones.Barajar();
            var elMaso = laClase.DemeNuevoMaso();
            var laCarta = elMaso.DemeCartaDeEncima();
            Console.WriteLine(string.Format("La carta es {0} de {1}", laCarta.Numero, laCarta.ElPalo.ToString()));
            Console.ReadLine();
        }
    }
}
