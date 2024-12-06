using SampleHealthApp.ViewModels;

namespace SampleHealthApp.Pages;

public partial class AccountPage : ContentPage
{
        public AccountPage(AccountViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
}

