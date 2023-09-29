namespace FinecoBankMobile.View;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void ViewAllButton_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(OperationsPage)}");
    }

    private async void SIMRechargeButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(RechargePage)}");
    }

    private async void TransferButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TransferPage));
    }
}