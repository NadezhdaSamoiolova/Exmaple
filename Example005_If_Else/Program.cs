Console.WriteLine("Введите имя пользователя");
string unsername = Console.ReadLine();

if(unsername.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(unsername);
}