using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using WpfApp1.common.constants;
using WpfApp1.Models;
using WpfApp1.Services;


namespace WpfApp1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;
        private ICommand _loginCommand;
        private readonly IApiClient _apiClient;

        public LoginViewModel(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public ICommand LoginCommand
        {
            get
            {
                return _loginCommand ?? (_loginCommand = new RelayCommand(async () => await LoginAsync()));
            }
        }
        private async Task LoginAsync()
        {
            try
            {
                var loginRequest = new UserModel { Username = Username, Password = Password };
                var endpoint = APIEndpoints.LoginAsync;
                var response = await _apiClient.PostAsync(endpoint, loginRequest);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseContent);
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    // Handle unsuccessful response
                    MessageBox.Show("Login failed. Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }

    public class TokenResponse
    {
        public string Token { get; set; }
    }
}


