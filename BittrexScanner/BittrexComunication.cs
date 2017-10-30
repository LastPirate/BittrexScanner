using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BittrexScanner
{
    internal class BittrexCommunication
    {
        internal BittrexCommunication(string ApiKey, string ApiSecret)
        {
            this.ApiKey = ApiKey;
            this.ApiSecret = ApiSecret;

            Connect = new HttpClient();
            Connect.BaseAddress = new Uri("https://bittrex.com/api/");
            Connect.Timeout = TimeSpan.FromMilliseconds(60000);
            hmacsha512 = new HMACSHA512(Encoding.UTF8.GetBytes(ApiSecret));
        }
        internal readonly string ApiKey;
        internal readonly string ApiSecret;
        internal long Nonce
        {
            get { return new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds(); }
        }
        internal readonly Dictionary<string, string> Request = new Dictionary<string, string>()
        {
            ["getMarkets"] = "v1.1/public/getmarkets",
            ["getCurrencies"] = "v1.1/public/getcurrencies",
            ["getTicker"] = "v1.1/public/getticker?",
            ["getMarketSummaries"] = "v1.1/public/getmarketsummaries",
            ["getMarketSummary"] = "v1.1/public/getmarketsummary?",
            ["getOrderBook"] = "v1.1/public/getorderbook?",
            ["getMarketHistory"] = "v1.1/public/getmarkethistory?",
            ["buyLimit"] = "v1.1/market/buylimit?",
            ["sellLimit"] = "v1.1/market/selllimit?",
            ["cancel"] = "v1.1/market/cancel?",
            ["getOpenOrders"] = "v1.1/market/getopenorders?",
            ["getBalances"] = "v1.1/account/getbalances?",
            ["getBalance"] = "v1.1/account/getbalance?",
            ["getDepositAdress"] = "v1.1/account/getdepositaddress?",
            ["withdraw"] = "v1.1/account/withdraw?",
            ["getOrder"] = "v1.1/account/getorder?",
            ["getOrderHistory"] = "v1.1/account/getorderhistory?",
            ["getWithdrawalHistory"] = "v1.1/account/getwithdrawalhistory?",
            ["getDepositHistory"] = "v1.1/account/getwithdrawalhistory?"
        };
        internal Stopwatch Lag = new Stopwatch();
        internal List<Dictionary<string, object>> Data ;

        private HttpClient Connect;
        private HttpRequestMessage request;
        private HttpResponseMessage response;
        private HMACSHA512 hmacsha512;
        internal bool problem = false;
        internal async Task<List<Dictionary<string, object>>> ExecuteRequestAsync(string urlRequest)
        {
            try
            {
                Data = null;
                hmacsha512.ComputeHash(Encoding.UTF8.GetBytes("https://bittrex.com/api/" + urlRequest));

                request = new HttpRequestMessage(HttpMethod.Get, urlRequest);
                request.Version = new Version("1.1");
                request.Headers.Add("apisign", BitConverter.ToString(hmacsha512.Hash).Replace("-", ""));

                Lag.Restart();
                response = await Connect.SendAsync(request, HttpCompletionOption.ResponseContentRead);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responceData = JToken.Parse(await response.Content.ReadAsStringAsync());

                    if ((bool)responceData["success"] == false)
                    {
                        MessageBox.Show("Bittrex success: " + responceData["success"] + "; Reason: " + (string)responceData["message"]);
                    }
                    else
                    {
                        Data = new List<Dictionary<string, object>>();
                        if (responceData["result"].Type == JTokenType.Array)
                        {
                            foreach (Dictionary<string, object> buffer in responceData["result"].ToObject<Dictionary<string, object>[]>()) Data.Add(buffer);
                        }
                        else Data.Add(responceData["result"].ToObject<Dictionary<string, object>>());
                    }
                }
                Lag.Stop();
                problem = false;
                if (Connect.Timeout.TotalMilliseconds / (Lag.ElapsedMilliseconds * 5) > 2)
                {
                    Connect = new HttpClient();
                    Connect.BaseAddress = new Uri("https://bittrex.com/api/");
                    Connect.Timeout = TimeSpan.FromMilliseconds(Lag.ElapsedMilliseconds * 7);
                }
                return Data;
            }

            catch (Exception)
            {
                problem = true;
                Connect = new HttpClient();
                Connect.BaseAddress = new Uri("https://bittrex.com/api/");
                Connect.Timeout = TimeSpan.FromMilliseconds(Connect.Timeout.TotalMilliseconds*1.4);
                return await ExecuteRequestAsync(urlRequest);
            }
            finally
            {
                GC.Collect(GC.MaxGeneration);
            }
        }
    }
}
