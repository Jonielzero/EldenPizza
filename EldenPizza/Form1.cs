using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intersoft.Crosslight;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Google.Apis.Auth.OAuth2.Responses;

namespace EldenPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usuariotxt.Text;
            string password = Clavetxt.Text;

            var token = AuthenticateUser(username, password);
            if (token != null)
            {
                MessageBox.Show("Ingreso Exitoso. Bienvenido!" + token);
                
                ApplicationState.Token = Convert.ToString(token);

                EldenPizzeria eldenPizzeria = new EldenPizzeria();
                eldenPizzeria.Show();
            }
            else
            {
                MessageBox.Show("Ingreso fallido, las credenciales no coinciden!");
            }

        }
        private async Task<string> AuthenticateUser(string username, string password)
        {
            try
            {
                using (var client = new HttpClient())
            {
                var request = new LoginRequest
                {
                    Username = username,
                    Password = password
                };

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost:5271/api/auth/login", content);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseContent);
                    return tokenResponse.AccessToken; 
                }

                return null;
            }
            }
            catch (HttpRequestException ex)
            {
                // Manejo de la excepción
                MessageBox.Show($"Error al realizar la solicitud HTTP: {ex.Message}");
                return null;
            }
        }
        
    }
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public static class ApplicationState
    {
        public static string Token { get; set; }
    }
}
