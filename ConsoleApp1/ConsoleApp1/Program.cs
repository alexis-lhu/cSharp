namespace Roulette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                string[] name = File.ReadAllLines("sn2.txt");
                Random cRandom = new Random();
                int aleatoire = cRandom.Next(name.Length);
                Console.WriteLine("Voici la personne tiré au sort :" + name[aleatoire]);
                
            } else {
                File.AppendAllText("sn2.txt", args[0] + Environment.NewLine);
            }
        }
    }
}

