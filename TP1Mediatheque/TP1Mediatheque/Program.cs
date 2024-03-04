using TP1Mediatheque.classes;
namespace TP1Mediatheque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que voulez-vous créer ? CD ou Livre ?");
            string rep = Console.ReadLine();
            if (rep == "Livre")
            {
                Console.WriteLine("Titre ?");
                string titre = Console.ReadLine();

                Console.WriteLine("Auteur ?");
                string aut = Console.ReadLine();

                Livre livre1 = new Livre(titre, aut);
                Console.WriteLine($"Voici le pret crée {livre1}");
            } else if (rep == "CD")
            {
                Console.WriteLine("Titre ?");
                string titre = Console.ReadLine();

                Console.WriteLine("Groupe ?");
                string grp = Console.ReadLine();

                CD cd1 = new CD(titre, grp);
                Console.WriteLine($"Voici le pret crée {cd1}");
            } else
            {
                Console.WriteLine("Veuillez entrer une valeur correcte !");
            }
            
        }
    }
}
