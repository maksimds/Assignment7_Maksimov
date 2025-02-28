using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace URIBased_Maksimov;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSignUpClicked(object sender, EventArgs e)
		{
			string username = UsernameEntry.Text?.Trim();
			string email = EmailEntry.Text?.Trim();
			string password = PasswordEntry.Text;
			string confirmPassword = ConfirmPasswordEntry.Text;

			// Validation logic
			if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
				string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
			{
				ErrorMessage.Text = "All fields are required.";
				ErrorMessage.IsVisible = true;
				return;
			}

			if (password != confirmPassword)
			{
				ErrorMessage.Text = "Passwords do not match.";
				ErrorMessage.IsVisible = true;
				return;
			}

			ErrorMessage.IsVisible = false;

			// Navigate to ProfilePage using the correct route
			await Shell.Current.GoToAsync($"profilepage?username={Uri.EscapeDataString(username)}&email={Uri.EscapeDataString(email)}");
		}

    }

