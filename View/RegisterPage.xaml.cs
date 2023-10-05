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
    private void SignIn_Tapped(object sender, EventArgs e)
    {
        Shell.Current.SendBackButtonPressed();
    }
}