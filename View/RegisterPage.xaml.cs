using FinecoBankMobile.View;
using System.Security.Cryptography.X509Certificates;

namespace FinecoBankMobile.View;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }
    
    private async void Submit_Clicked(object sender, EventArgs e)
    {
        try
        {
            LoginPage.UserCredentials item = new LoginPage.UserCredentials(emailAddress.ToString(), secretPassword.ToString());
            LoginPage.userCredentialsList.Add(item);
            await DisplayAlert("Registered!", "Registrazione effettuata con successo!", "OK");
            await Shell.Current.GoToAsync(nameof(LoginPage));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Errore", ex.ToString(), "OK");
        }
    }
    private void SignIn_Tapped(object sender, EventArgs e)
    {
        Shell.Current.SendBackButtonPressed();
    }
}