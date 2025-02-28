using Microsoft.Maui.Controls;
using System;

namespace URIBased_Maksimov
{
    [QueryProperty(nameof(Username), "username")]
    [QueryProperty(nameof(Email), "email")]
    public partial class ProfilePage : ContentPage
    {
        private string username = string.Empty;
        private string email = string.Empty;

        public string Username
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    username = Uri.UnescapeDataString(value);
                    UsernameLabel.Text = $"Username: {username}";
                }
            }
        }

        public string Email
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    email = Uri.UnescapeDataString(value);
                    EmailLabel.Text = $"Email: {email}";
                }
            }
        }

        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void OnSignOutClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(".."); // Navigate back to Signup Page
        }
    }
}
