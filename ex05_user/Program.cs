Console.Write("Как твоё имя? Назовись: ");
string username = Console.ReadLine();

if (username.ToLower() == "оля")
{
    Console.Write("Ты пупсик, ");
    Console.Write(username);
    Console.Write("!");
}
else
{
    Console.Write("Что это за имя такое дурацкое? ");
    Console.Write(username);
    Console.Write("...");
} 