using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace NetworkProgramingProject
{
    class WebClient
    {
        static void Main(string[] args)
        {

            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead("http://www.contoso.com/index.htm");
            // The stream data is used here.  
            response.Close();
        }

        private Stream OpenRead(string v)
        {
            throw new NotImplementedException();
        }
    }
}