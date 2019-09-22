using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace WMLib.Account
{
    public class WMAccount
    {
        public HttpClient Client;
        public CookieContainer ClientCookies = new CookieContainer();
        
        public string Email { get; private set; }
        public string JwtToken { get; private set; }

        public WMAccount(string email, string password, string jwtToken = null)
        {
            Email = email;
            JwtToken = jwtToken;
            InitializeHttpClient();
        }

        private void InitializeHttpClient()
        {
            var handler = new HttpClientHandler()
            {
                CookieContainer = ClientCookies
            };
            Client = new HttpClient(handler);

        }

        public async void LoginWithCredentialsAsync(string password)
        {
            var payload = JsonConvert.SerializeObject(new { Email, password });
            throw new NotImplementedException();
        }

        public async void LoginWithJwtTokenAsync()
        {
            throw new NotImplementedException();
        }

        private async void LoginAsync(string payload)
        {
            // TODO: implement HttpRequestMessage composition in WMApiClient
            //HttpResponseMessage response;
            //using (var loginRequest = new HttpRequestMessage(HttpMethod.Post, $"{Globals.ApiBase}/auth/signin"))
            //{
            //    loginRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            //    loginRequest.Headers.Authorization = new AuthenticationHeaderValue("JWT", String.Empty);
            //    response = await Client.SendAsync(loginRequest);
            //}

            //if (response.StatusCode != HttpStatusCode.OK)
            //{
            //    throw new WebException($"Received unexpected status code {response.StatusCode} from the API.");
            //}
            throw new NotImplementedException();
        }
    }
}
