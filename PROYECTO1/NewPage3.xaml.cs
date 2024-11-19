namespace PROYECTO1;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage4());
    }


    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); 
    }


}