using System;
using System.Net;
using System.Net.Http;
using WMLib.Utils;

namespace WMLib.Networking
{
    public class WMApiClient
    {
        #region Singleton implementation
        private static WMApiClient _singleInstance;

        public static WMApiClient GetInstance()
        {
            if (_singleInstance == null)
            {
                _singleInstance = new WMApiClient();
            }

            return _singleInstance;
        }
        #endregion

        #region Constants and runtime variables
        // API base URL
        private const string ApiBase = "https://api.warframe.market/v1";

        // API User-Agent
        private static string UserAgent = $"WMLib/{App.GetAppVersion()} (Github.com/xyx0826/Platframe)";

        // Reusable client for HTTP API
        private HttpClient _client;

        // Cookie container for the client
        private readonly CookieContainer _cookies = new CookieContainer();

        // Rate limiter for general API endpoints
        private readonly WMThrottler _apiThrottler = new WMThrottler(3, TimeSpan.FromSeconds(1));

        // Rate limiter for authentication API endpoints
        private readonly WMThrottler _authThrottler = new WMThrottler(2, TimeSpan.FromMinutes(1));
        #endregion

        public WMApiClient()
        {
            InitializeHttpClient();
        }

        /// <summary>
        /// Initializes the persistent <see cref="HttpClient"/> with headers and cookie support.
        /// </summary>
        private void InitializeHttpClient()
        {
            var handler = new HttpClientHandler()
            {
                CookieContainer = _cookies
            };
            _client = new HttpClient(handler);
            _client.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);
        }
    }
}
