Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "марго")
{
    Console.WriteLine("Ура, это же Марго!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}