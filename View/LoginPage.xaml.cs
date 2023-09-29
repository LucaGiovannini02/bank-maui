using Microsoft.Maui;
using Microsoft.Maui.Animations;
using Microsoft.Maui.Controls;

namespace FinecoBankMobile.View;

public partial class LoginPage : ContentPage
{

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void Registration_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(RegisterPage)}");
    }
    private async void Login_Clicked(object sender, EventArgs e)  // Aggiungere controllo utente che restituisca in caso un messaggio di errore
    {
        await Shell.Current.GoToAsync($"{nameof(HomePage)}");
    }
}

