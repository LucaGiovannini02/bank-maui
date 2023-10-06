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
    private void Animate(object sender, EventArgs e)
    {
        Lottie.IsAnimationPlaying = true;
    }

    public class UserCredentials
    {
        public UserCredentials(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public string Email { get; set; }
        public string Password { get; set; }

    }

    public static List<UserCredentials> userCredentialsList = new List<UserCredentials>
    {
        new UserCredentials("luca.giovannini@gmail.com", "Tailwind1234"),
        new UserCredentials("niccolo.bano@gmail.com", "Quarantacinque45"),
        new UserCredentials("filiberto.toniolo@gmail.com", "Sinistro5678"),
        new UserCredentials("chiara.negrini@gmail.com", "ITS_2023")
    };

    public bool CheckCredentials(string givenEmail, string givenPassword)
    {
        foreach (var userCredentials in userCredentialsList)
        {
            if (userCredentials.Email.Equals(givenEmail) && userCredentials.Password.Equals(givenPassword))
            {
                return true;
            }
        }
        return false;
    }

    private async void Login_Clicked(object sender, EventArgs e)
    {
        string givenEmail = EmailEntry.Text;
        string givenPassword = PasswordEntry.Text;

        bool isMatch = CheckCredentials(givenEmail, givenPassword);

            if (isMatch)
            {
                await DisplayAlert("SUCCESS", "Successfully logged in", "OK");
                EmailEntry.Text = "";
                PasswordEntry.Text = "";
                await Shell.Current.GoToAsync($"{nameof(HomePage)}");
            }
            else
            {
                await DisplayAlert("FAILED", "Failed Login Attempt. Check your credentials and try again", "OK");
                PasswordEntry.Text = "";
            }
    }
    private async void Registration_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(RegisterPage)}");
    }
}

