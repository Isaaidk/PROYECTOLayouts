namespace PROYECTO1;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {


        Navigation.PushAsync(new NewPage3());

    }
}