namespace PROYECTO1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {


        Navigation.PushAsync(new NewPage2());

    }

}