using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazineClass
{
    public class Magazine
    {
        private DateTime date;
        public DateTime EstablishmentDate
        {
            get { return date; }
            set
            {
                try
                {
                    if (value.Date > DateTime.UtcNow) throw new Exception("Incorrect establishment date.");
                    date = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int ContactPhoneNumber { get; set; }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                try
                {
                    if (!(value.Substring(value.IndexOf('@')).Contains("mail.") && value.IndexOf('@')!=0)) throw new Exception("Wrong email");
                    email = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Environment.Exit(2);
                }
            }
        }
    }
}
