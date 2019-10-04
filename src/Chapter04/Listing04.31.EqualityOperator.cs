namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_31
{
#pragma warning disable CA1820 // Explictly using equality operator here as an example

    public class Program
    {
        public static void Main()
        {
            if(input == "" || input == "quit")
            {
                System.Console.WriteLine($"Player {currentPlayer} quit!!");
            }
        }

        public static string input { get; set; }
        public static string currentPlayer { get; set; }
    }

#pragma warning restore CA1820 // Explictly using equality operator here as an example
}
