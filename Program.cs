namespace _9._5._bibliotheek;
class Program
{
    static void Main(string[] args)
    {
        BibBoek boek1 = new BibBoek();
        boek1.NaamOntlener = Input.AskString("Geef je naam op: ");
        Console.WriteLine($"Naam ontlener: {boek1.NaamOntlener}, Uitleendatum {boek1.Vandaag}");
        Console.WriteLine($"Tijdstip inlevering: {boek1.Inleverdag}");

    }

    // Classes
    public class BibBoek
    {
        public string NaamOntlener { get; set; }
        public DateTime Vandaag { get; private set; } = DateTime.Now;
        public DateTime Inleverdag { get; } = DateTime.Now.AddDays(14);

    }

    public static class Input
    {
        public static string AskString(string question)
        {
            Console.Write($"{question}");
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
