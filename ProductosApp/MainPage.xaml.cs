namespace ProductosApp
{
    public partial class MainPage : ContentPage
    {
        int count = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count *= 2;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            await Navigation.PushModalAsync(new ProductoPage());
        }
    }
}