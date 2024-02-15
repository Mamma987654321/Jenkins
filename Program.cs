// See https://aka.ms/new-console-template for more information
using WelcomeApp;
Console.WriteLine("Welcome to autehnticate app");
SignIn obj = new SignIn();
Console.WriteLine(obj.Authenticate("admin", "admin@123"));