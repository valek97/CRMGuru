using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMGuru
{
  public  class WebRequest
    {
        public List<Country> WebResponse(string name)
        {
            var client = new WebClient();
            string json;
            object nameCountry;
            try
            {
                
                json = Encoding.UTF8.GetString(client.DownloadData("https://restcountries.eu/rest/v2/name/" + $"{name}"));
                nameCountry = JsonConvert.DeserializeObject<List<Country>>(json);
                return (List<Country>)nameCountry;
            }
            catch (WebException wex)
            {
                if (((HttpWebResponse)wex.Response).StatusCode == HttpStatusCode.NotFound)
                {
                    DialogResult resultErrors = MessageBox.Show($"Введеная страна <{name}> не найдена ",
                     "Ошибка",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information,
                      MessageBoxDefaultButton.Button1);
                }
                if (((HttpWebResponse)wex.Response).StatusCode == HttpStatusCode.BadGateway)
                {
                    DialogResult resultErrors = MessageBox.Show("Cервис недоступен",
                     "Ошибка",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information,
                      MessageBoxDefaultButton.Button1);
                }
                return null;
            }

        }
    }
}
