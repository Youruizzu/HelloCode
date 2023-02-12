internal class Program
{
    private static void Main(string[] args)
    {
        while (true) {
            Console.Write("Введите имя пользователя: ");
            string? userInputErrorTest = Console.ReadLine();
            string username = userInputErrorTest ?? "NullErrorException";
            if (username == "NullErrorException") {
                Console.WriteLine("Error. Try again.");
            }
            else {
                if(username.ToLower() == "маша") {
                    Console.WriteLine("Ура, это Маша!");
                } 
                else { 
                    Console.WriteLine("Привет, " + username);
                }
                return;
            }
        }
    }
}