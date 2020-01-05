using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace USMarketAssistant
{
    public class DataLoader
    {
        //private string _strSymbol = "";
        public DataLoader()
        {
            
        }

        public Stock Load(string Symbol, Dictionary<string,string> ApiServices)
        {
            //_strSymbol = Symbol;
            Stock stk;
            if ((stk = LoadFromAlphaVantage(Symbol,ApiServices)) != null)
                return stk;
            else
                return null;
        }

        private Stock LoadFromAlphaVantage(string Symbol, Dictionary<string, string> ApiServices)
        {
            string strUrl = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=" + Symbol + "&outputsize=full&apikey="+ApiServices["Alpha Vantage"];
            Stock stock = new Stock();
            using (WebClient wc = new WebClient())
            {
                var strResultJson = wc.DownloadString(strUrl);
                JObject jsonObj = JObject.Parse(strResultJson);
                
                stock.Name = Symbol;
                // get JSON result objects into a list
                //List<JToken> results = googleSearch["Time Series (Daily)"].Children().ToList();
                List<JToken> tokens = jsonObj["Time Series (Daily)"].Children<JToken>().ToList();
                foreach (JProperty obj in tokens)
                {
                    Tick tick = new Tick();
                    tick.Date = DateTime.Parse(obj.Name);
                    List<JToken> subTokens = obj.Value.Children<JToken>().ToList();

                    tick.Open = Double.Parse(((JProperty)subTokens[0]).Value.ToString());
                    tick.High = Double.Parse(((JProperty)subTokens[1]).Value.ToString());
                    tick.Low = Double.Parse(((JProperty)subTokens[2]).Value.ToString());
                    tick.Close = Double.Parse(((JProperty)subTokens[3]).Value.ToString());
                    tick.Volume = Double.Parse(((JProperty)subTokens[4]).Value.ToString());
                    
                    stock.Ticks.Add(tick);
                }
            }


            return stock;
        }
    }
}
