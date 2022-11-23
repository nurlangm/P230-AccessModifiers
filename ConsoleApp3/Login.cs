using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Login
    {
        private string _username;
        private string _password;


        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                while (value.Length <7)
                {
                    Console.WriteLine("Adi duzgun daxil edin");
                    value = Console.ReadLine();
                }
                _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                while (value == value.ToLower()&& value == value.Trim(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }))
                {
                    Console.WriteLine("Password Sertleri odenmir,Yeniden daxil edin");
                    value = Console.ReadLine();
                }
                _password = value;
            }
        }

        public Login(string username, string password)
        {
            Username = username;
            Password = password;    
        }
    }
}
