using CS.UI.Common.FormFactory;
using MYOB.CSSInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CS.UI.Maintenance.PortalIntegrationForm
{
    public partial class frmPortalIntegration : Form, ICSSDisplayMainArea
    {
        private HttpClient _client;
        private CookieContainer _cookies;

        public frmPortalIntegration(PortalIntegration factory)
        {
            InitializeComponent();

            _cookies = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = _cookies;
            handler.UseCookies = true;
            _client = new HttpClient(handler);
            _client.DefaultRequestHeaders.ExpectContinue = false;
            _cookies.Add(new Uri("https://cchcs01.clientspace.co.uk"), new Cookie("cookieNotificationName", "portalCookie"));
            _cookies.Add(new Uri("https://cchcs01.clientspace.co.uk"), new Cookie("__RequestVerificationToken_L3YyMDE1LTM1", "_gbEXTZsUx7sTDmCf8JmlRvgIxjISQgvJ5KWp0zgeX1gcEA446bf-Hgkx3F9uWyiI7vCqwsHqov51eIwIgzGTgt5xtY1"));
        }

        public int CollectionID { get; set; }
        
        public void CloseForm(object sender, CSSCancelEventArgs e)
        {
            this.Close();
        }

        public SideBarGroups Register()
        {
            this.Show();
            return new SideBarGroups("");
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            var response = _client.GetAsync("https://cchcs01.clientspace.co.uk/online/clients").Result;

            response.EnsureSuccessStatusCode();

            var text = response.Content.ReadAsStringAsync().Result;

            txtResponse.Text = text;

            if(text.Contains("Clientspace - Login"))
            {
                MessageBox.Show("Logged out");
            }
            else
            {
                MessageBox.Show("Logged in");
            }

            

            ////// login
            //CookieContainer cookies = new CookieContainer();
            //HttpClientHandler handler = new HttpClientHandler();
            //handler.CookieContainer = cookies;
            //handler.UseCookies = true;
            //var hc = new HttpClient(handler);

            //string BaseUrl = "http://localhost:5879";

            //string password = "P@ssword1";

            //string LoginUrl = BaseUrl + "/Account/Login";

            //string r = hc.GetStringAsync(LoginUrl).Result;

            //var regex = new System.Text.RegularExpressions.Regex("<input name=\"__RequestVerificationToken\" type=\"hidden\" value=\"[a-zA-Z0-9-_]*\" />");
            //var match = regex.Match(r);
            //var tokenElement = XElement.Parse(match.Value);
            //string token = tokenElement.Attribute("value").Value;

            //HttpContent content = new FormUrlEncodedContent(new[]
            //{
            //    new KeyValuePair<string, string>("__RequestVerificationToken", token),
            //    new KeyValuePair<string, string>("Email", "name@mail.com"),
            //    new KeyValuePair<string, string>("Password", password)
            //});
            //HttpResponseMessage response = hc.PostAsync(LoginUrl, content).Result;

            //response.EnsureSuccessStatusCode();

            //string loginResult = response.Content.ReadAsStringAsync().Result;

            //if (loginResult.Contains("Invalid login attempt"))
            //{
            //    throw new Exception("Access denied");
            //}

            //// get values
            //response = hc.GetAsync(BaseUrl + "/api/values").Result;

            //response.EnsureSuccessStatusCode();

        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            string loginUrl = "https://cchcs01.clientspace.co.uk/v2015-3";
            
            string r = _client.GetStringAsync(loginUrl).Result;

            var regex = new System.Text.RegularExpressions.Regex("<input name=\"__RequestVerificationToken\" type=\"hidden\" value=\"[a-zA-Z0-9-_]*\" />");
            var match = regex.Match(r);
            var tokenElement = XElement.Parse(match.Value);
            string token = tokenElement.Attribute("value").Value;

            HttpContent content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("__RequestVerificationToken", token),
                new KeyValuePair<string, string>("PracticeGuid", "e5e86e6c-15e0-4e47-85fd-deb7180c1c2d"),
                new KeyValuePair<string, string>("UserName", "jon.coello@wolterskluwer.co.uk"),
                new KeyValuePair<string, string>("Password", "1"),
                new KeyValuePair<string, string>("RememberMe", "false"),
            });
            
            var request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(loginUrl);
            request.Content = content;
            request.Headers.Add("Host", "cchcs01.clientspace.co.uk");
            request.Headers.Add("Connection", "keep-alive");
            request.Headers.Add("Cache-Control", "max-age=0");
            request.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
            request.Headers.Add("Origin", "https://cchcs01.clientspace.co.uk");
            request.Headers.Add("Upgrade-Insecure-Requests", "1");
            request.Headers.Add("Referer", "https://cchcs01.clientspace.co.uk/v2015-3/Account/Login");
            request.Headers.Add("Accept-Encoding", "gzip, deflate");
            request.Headers.Add("Accept-Language", "en-GB,en-US;q=0.8,en;q=0.6");
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.80 Safari/537.36");
            
            //_cookies.Add(new Uri("http://practice05.clientspace.co.uk"), new Cookie("cookieNotificationName", "portalCookie"));

            var response = _client.SendAsync(request).Result;

            response.EnsureSuccessStatusCode();

            txtResponse.Text = response.Content.ReadAsStringAsync().Result;
           
            var response2 = _client.GetAsync("https://cchcs01.clientspace.co.uk/online/clients").Result;

            response2.EnsureSuccessStatusCode();

            var text = response2.Content.ReadAsStringAsync().Result;

            txtResponse.Text = text;

            MessageBox.Show("OK");

        }

        private void cmdLogOut_Click(object sender, EventArgs e)
        {
            string url = "https://cchcs01.clientspace.co.uk/online/portalUsers/me/logout";
            var response = _client.PostAsync(url, null).Result;
            response.EnsureSuccessStatusCode();
            MessageBox.Show("OK");
        }
    }
}
