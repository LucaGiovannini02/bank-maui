namespace FinecoBankMobile.View;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }
    
    private async void Submit_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Registered!", "Registrazione effettuata con successo!", "OK");
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
    private async void SignIn_tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}