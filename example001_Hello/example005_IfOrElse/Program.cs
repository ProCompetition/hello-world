Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "alina")
{
    Console.WriteLine ("Ура, это же Alina!!!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}