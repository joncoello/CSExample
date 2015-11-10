using CS.DomainModel.Models.Portal;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS.PortaIntegration
{
    public class PortalProxy
    {
        private readonly string _baseUrl;
        private HttpClient _client;
        private readonly string _emailAddress;
        private  bool _loggedIn;
        private readonly string _password;
        private readonly Guid _practiceGuid;

        public PortalProxy(string baseUrl, Guid practiceGuid, string emailAddress, string password)
        {
            // store login credentials
            _baseUrl = baseUrl;
            _practiceGuid = practiceGuid;
            _emailAddress = emailAddress;
            _password = password;

            // initial state is logged off - possible state machine
            _loggedIn = false;

            // setup http client to store cookies and block redirects
            var cookies = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = cookies;
            handler.UseCookies = true;
            handler.AllowAutoRedirect = false;
            _client = new HttpClient(handler);
        }

        /// <summary>
        /// get clients
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Client> GetClients()
        {
            if (!_loggedIn)
            {
                Login();
            }

            // normal request on secure resource
            var response2 = _client.GetAsync(_baseUrl + "/online/clients").Result;

            response2.EnsureSuccessStatusCode();

            var text = response2.Content.ReadAsStringAsync().Result;

            JArray clientsJson = JArray.Parse(text);

            var clients = clientsJson.Select(c => new Client() {
                ClientGuid = Guid.Parse((string)c["clientGuid"]),
                Name = (string)c["lastName"]
            }).ToList();

            return clients;
        }

        private void Login()
        {
            string loginUrl = _baseUrl + "/v2015-3/Account/Login";

            // construct login request

            // body
            HttpContent content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("PracticeGuid", _practiceGuid.ToString()),
                new KeyValuePair<string, string>("UserName", _emailAddress),
                new KeyValuePair<string, string>("Password", _password),
            });

            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(loginUrl);
            request.Content = content;

            // POST login
            var response = _client.SendAsync(request).Result;

            _loggedIn = true;
        }
    }
}
