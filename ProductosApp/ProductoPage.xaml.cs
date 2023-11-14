using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace ProductosApp;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
		InitializeComponent();
        ListaProductos.ItemsSource = Utils.Utils.listaProductos;
	}

    private async void onClicNuevoProducto(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NuevoProductoPage());   

        var toast = Toast.Make("On clic botón Nuevo Producto", ToastDuration.Short, 14);
        await toast.Show();
    }
}