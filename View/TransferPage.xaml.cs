namespace FinecoBankMobile.View;

public partial class TransferPage : ContentPage
{
	public TransferPage()
	{
		InitializeComponent();
	}

	private async void Transfer_Clicked(object sender, EventArgs e)
	{
		await DisplayAlert("Success!", "Money have been transfered correctly", "OK");
		await Shell.Current.GoToAsync(nameof(HomePage));
	}
}