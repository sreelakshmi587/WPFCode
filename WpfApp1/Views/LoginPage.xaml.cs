using System.Windows.Controls;
using WpfApp1.ViewModels;
namespace WpfApp1.Views
{
    
    public partial class LoginPage:System.Windows.Controls.UserControl
    {
        //public LoginPage()
        //{
        //    InitializeComponent();
        //    DataContext = new LoginViewModel();
        //}
        public LoginPage(LoginViewModel loginViewModel)
        {
            InitializeComponent();
            DataContext = loginViewModel;
        }
    }
}
