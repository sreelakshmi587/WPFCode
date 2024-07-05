using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using WpfApp1.Models;


namespace WpfApp1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;
        private ICommand _loginCommand;
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
            var loginRequest = new UserModel { Username = Username, Password = Password };
            var json = JsonConvert.SerializeObject(loginRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                try
                {
                    string url = $"http://localhost:5143/api/Login/login?userName={Username}&password={Password}";
                    var response = await client.PostAsync(url,content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseContent);
                        // Process successful response
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
                //    if (response.IsSuccessStatusCode)
                //    {
                //        var responseContent = await response.Content.ReadAsStringAsync();
                //        var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseContent);
                //        MessageBox.Show("Login successful!");

                //        // You can store the token and use it for authenticated requests
                //        // Example: client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenResponse.Token);
                //    }
                //    else
                //    {
                //        MessageBox.Show("Login failed. Invalid username or password.");
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"An error occurred: {ex.Message}");
                //}
            }
        }
    }

    public class TokenResponse
    {
        public string Token { get; set; }
    }
}


