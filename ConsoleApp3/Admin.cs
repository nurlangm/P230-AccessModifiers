using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Admin:Login
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(string user,string password,bool isSuperAdmin, string section):base(user,password)
        {
            Username = user;
            Password=password;
            IsSuperAdmin = isSuperAdmin;
            Section = section;  
        }

        public void Info()
        {
            Console.WriteLine($"Username:{Username}  Password:{Password}  IsSuperAdmin:{IsSuperAdmin}   Section:{Section}");
        }
    }
}
