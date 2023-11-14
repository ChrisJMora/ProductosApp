using ProductosApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosApp.Utils
{
    class Productos : ObservableCollection<Producto>
    {
        public Productos() : base() 
            {
                Add(new Producto
                {
                    IdProducto = 1,
                    Nombre = "Producto 1",
                    Descripcion = "Descripcion 1",
                    Cantidad = 1
                });
                Add(new Producto
                {
                    IdProducto = 2,
                    Nombre = "Producto 2",
                    Descripcion = "Descripcion 2",
                    Cantidad = 2
                });
            }
    }
}
