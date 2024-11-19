namespace PROYECTO1
{
    public partial class NewPage4 : ContentPage
    {
        public NewPage4()
        {
            InitializeComponent();
        }

        // Maneja la navegación al hacer clic en el botón "Ir a GridLayout"
        private async void OnNavigateToGridLayout(object sender, EventArgs e)
        {
            // Redirecciona a la página de GridLayout
            await Navigation.PushAsync(new NewPage1());
        }

        // Maneja el botón de regreso
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
