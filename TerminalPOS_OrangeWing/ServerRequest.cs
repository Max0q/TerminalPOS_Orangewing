using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace TerminalPOS_Orangewing
{
    public class ServerRequest
    {
        string _url = "http://localhost:8080/index.php/apis";

        public async Task<string> ConnectRequest(string host, string port, string delay)
        {
            var obj = new Dictionary<string, string>
            {
                ["host"] = host,
                ["port"] = port,
                ["delay"] = delay
            };

            string responseMessage = await SendPostRequestAsync(_url, obj);
            return responseMessage;
        }

        string paymentResponse;
        public async Task<string> PaymentRequest(string device,string host, string port, string amount, string delay)
        {
            switch (device)
            {
                case "Verifone":
                    // private implementation
                    break;

                case "Injenico":
                    // private implementation
                    break;

                case "Pax930":
                    var obj = new Dictionary<string, string>
                    {
                        ["host"] = host,
                        ["port"] = port,
                        ["amount"] = amount,
                        ["delay"] = delay
                    };

                    paymentResponse = await SendPostRequestAsync(_url, obj);
                    break;

                case "TapXphone":
                    // private implementation
                    break;
            }
            return paymentResponse;
        }
 
        private  async Task<string> SendPostRequestAsync(string url, Dictionary<string,string> obj)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var content = new FormUrlEncodedContent(obj);

                    var res = await client.PostAsync(url, content);
                    string responseContent = await res.Content.ReadAsStringAsync();

                    Match match = Regex.Match(responseContent, @"\{.*\}");
                    if (match.Success)
                    {
                        return match.Value;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

