using ProductosApp.Models;

namespace ProductosApp;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
	}

    private async void onClic_GuardarProducto(object sender, EventArgs e)
    {
        string nombre = Nombre.Text;
        string descripcion = Descripcion.Text;
        int cantidad = Int32.Parse(Cantidad.Text);

        Producto nuevoProducto = new Producto()
        {
            IdProducto = Utils.Utils.listaProductos.Count + 1,
            Nombre = nombre,
            Descripcion = descripcion,
            Cantidad = cantidad
        };

        Utils.Utils.listaProductos.Add(nuevoProducto);

        await Navigation.PopModalAsync();
        
    }
}