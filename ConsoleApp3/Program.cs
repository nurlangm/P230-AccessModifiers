using ConsoleApp3;


Console.WriteLine("Username:");
string userName = Console.ReadLine();

Console.WriteLine("Password:") ;
string password = Console.ReadLine();

Admin admin = new(userName,password, true, "Slider Section");


admin.Info();