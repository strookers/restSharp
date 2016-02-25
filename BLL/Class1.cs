using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace BLL
{
    public class Class1
    {
        RestClient client = new RestClient();

        public void RestSharp()
        {
            client.BaseUrl = new Uri("");
        }
        
    }
}
