using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClass;
using MagazineClass;

namespace _07._02._2023lb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            Web web = new Web();
            web.Uri = "https://learn.microsoft.com/en-us/dotnet/api/system.uri?view=net-7.0";
            Console.WriteLine(web.Uri);
            web.Ip = "192.168.0.255";
            Console.WriteLine(web.Ip) ;

            #endregion

            #region task 2

            Magazine magazine = new Magazine();
            magazine.Email = "2@gmail.com";
            Console.WriteLine(magazine.Email);

            #endregion

            #region task 3



            #endregion

            Console.ReadKey();
        }
    }
}
