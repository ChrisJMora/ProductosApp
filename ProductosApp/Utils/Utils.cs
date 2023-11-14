using ProductosApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosApp.Utils
{
    internal class Utils
    {
        public static ObservableCollection<Producto> listaProductos = new Productos();
    }
}
