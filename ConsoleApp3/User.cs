

namespace ConsoleApp3
{
    internal class User:Login
    {
        public User(string username,string password):base(username, password)
        {
            Username= username;
            Password= password;
        }
    }
}
