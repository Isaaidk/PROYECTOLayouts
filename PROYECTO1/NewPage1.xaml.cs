namespace PROYECTO1
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();
        }

        // Método para el primer botón
        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage2());
        }

        // Método para el segundo botón de regreso
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Regresa a la página anterior
        }
    }
}
