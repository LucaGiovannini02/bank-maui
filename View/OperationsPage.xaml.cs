namespace FinecoBankMobile.View;

public partial class OperationsPage : ContentPage
{
	public OperationsPage()
	{
		InitializeComponent();
	}

	private async void Operation_Tapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(DetailPage));
	}

    private void TextCell_Tapped(object sender, EventArgs e)
    {

    }
}