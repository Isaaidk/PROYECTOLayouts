namespace PROYECTO1
{
    public partial class NewPage4 : ContentPage
    {
        public NewPage4()
        {
            InitializeComponent();
        }

        // Maneja la navegaci�n al hacer clic en el bot�n "Ir a GridLayout"
        private async void OnNavigateToGridLayout(object sender, EventArgs e)
        {
            // Redirecciona a la p�gina de GridLayout
            await Navigation.PushAsync(new NewPage1());
        }

        // Maneja el bot�n de regreso
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
