using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClass
{
    public class Web
    {
        public string Name { get; set; }


        private string uri;
        public string Uri
        {
            get => uri;
            set
            {
                try
                {
                    if (!System.Uri.TryCreate(value, UriKind.Absolute, out var uri))
                    {
                        throw new Exception("Wrong uri");
                    }
                    this.uri = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
        }

        private string ip;
        public string Ip
        {
            get => ip;
            set
            {
                try
                {
                    IPAddress.Parse(value);
                    ip = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(2);
                }
            }
        }

        public string Description { set; get; }
       
    }
}
