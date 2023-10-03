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

    private async void Login_Clicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;

        if (Authenticate(email, password))
        {
            await DisplayAlert("SUCCESS!", "Successfully logged in!", "OK");
            EmailEntry.Text = "";
            PasswordEntry.Text = "";
            await Shell.Current.GoToAsync($"{nameof(HomePage)}");
        }
        else
        {
            await DisplayAlert("LOGIN FAILED", "Login failed. Check your credentials and try again", "OK");
            EmailEntry.Text = "";
            PasswordEntry.Text = "";
        };
    }
    static bool Authenticate(string email, string password)
    {
        if (email == "luca.giovannini@gmail.com"  && password == "Tailwind1234")
        {
            return true;
        } else
        {
            return false;
        }
    }
    private async void Registration_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(RegisterPage)}");
    }
}

