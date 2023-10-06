namespace FinecoBankMobile.View;

public partial class RechargePage : ContentPage
{
	public RechargePage()
	{
		InitializeComponent();
	}

	private async void Recharge_Clicked(object sender, EventArgs e)
	{
		await DisplayAlert("Success!", "Operation completed!", "OK");
		Shell.Current.SendBackButtonPressed();
	}
}