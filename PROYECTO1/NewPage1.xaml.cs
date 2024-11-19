namespace PROYECTO1
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1()
        {
            InitializeComponent();
        }

        // M�todo para el primer bot�n
        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewPage2());
        }

        // M�todo para el segundo bot�n de regreso
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Regresa a la p�gina anterior
        }
    }
}
