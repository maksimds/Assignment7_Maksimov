using Microsoft.Maui.Controls;

namespace URIBased_Maksimov;

    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            // Register the route for ProfilePage
            Routing.RegisterRoute("profilepage", typeof(ProfilePage));
        }
    }

