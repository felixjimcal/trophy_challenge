
using Newtonsoft.Json;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloWorld
{
    public class Answer
    {
        public static void GetPrefix(string country, long phoneNumber)
        {
            if (string.IsNullOrEmpty(country))
            {
                NoCountry();
                return;
            }

            string url = "https://jsonmock.hackerrank.com/api/countries?name=" + country;
            string jsonResult = CallRestMethod(url);
            CountryModel countryObject = JsonConvert.DeserializeObject<CountryModel>(jsonResult);

            if (countryObject.Data.Count() == 0)
            {
                NoCountry();
                return;
            }

            string prefix = countryObject.Data.First().CallingCodes.FirstOrDefault();
            if (!String.IsNullOrEmpty(prefix))
            {
                Console.WriteLine("+" + prefix + " " + phoneNumber);
            }
        }

        static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        private static void NoCountry() 
        {
            Console.WriteLine("-1");
        }
    }
    class ConsoleApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter country, Example Spain:");
            string country = Console.ReadLine();

            Console.WriteLine("Enter phone number, Example 656445445:");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Answer.GetPrefix(country, phoneNumber);
        }
    }
}