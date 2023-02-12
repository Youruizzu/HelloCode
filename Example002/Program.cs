internal class Program
{
    private static void Main(string[] args)
    {
        while (true) {
            Console.Write("Введите свой никнейм: ");
            string? userInputErrorTest = Console.ReadLine();
            string username = userInputErrorTest ?? "NullErrorException";
            if (username == "NullErrorException") {
                Console.WriteLine("Error. Try again.");
            }
            else { Console.WriteLine("Привет, " + username); return;}
        }
    }
}