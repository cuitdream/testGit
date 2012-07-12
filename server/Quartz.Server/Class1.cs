using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Quartz.Server
{
    class Class1  : IJob
    {

        public void Execute(IJobExecutionContext context)
        {
            string url = "http://localhost:4374/UpdateChannelPVHandler.ashx";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebProxy proxy = new WebProxy("ctu2-tmg-01", 8080);
            proxy.Credentials = new NetworkCredential("luyanga", "Aa19871212");
            request.Proxy = proxy;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(DateTime.Now) ;
        }
    }
}
