using Microsoft.Extensions.DependencyInjection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ViewModels;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();

            //// Cast the current application to your App class to access the Services property
            //var app = (App)System.Windows.Application.Current;
            //var loginPage = app.Services.GetRequiredService<LoginPage>();

            //// Set the LoginPage as the content of MainWindow
            //this.Content = loginPage;


            //2.
            //InitializeComponent();

            //// Attempt to get the current application instance
            //var app = (App)System.Windows.Application.Current;

            //if (app != null && app.Services != null)
            //{
            //    // Assuming LoginPage is the UserControl or Window you want to show
            //    var loginPage = app.Services.GetService<LoginPage>();

            //    if (loginPage != null)
            //    {
            //        // Set the LoginPage as the content of MainWindow
            //        this.Content = loginPage;
            //    }
            //    else
            //    {
            //        System.Windows.MessageBox.Show("LoginPage service not registered or could not be resolved.");
            //    }
            //}
            //else
            //{
            //    System.Windows.MessageBox.Show("Application services not properly initialized.");
            //}
            InitializeComponent();

            // Get required services from DI container
            var app = (App)System.Windows.Application.Current;
            var loginViewModel = app.Services.GetRequiredService<LoginViewModel>();

            // Initialize LoginPage with required dependencies
            var loginPage = new LoginPage(loginViewModel);

            // Set LoginPage as the content of MainWindow
            this.Content = loginPage;
        }
    }
}