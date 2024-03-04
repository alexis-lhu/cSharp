using Societe.Modele;

namespace Societe{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new Personne("Thierry","coudre");

            IEmploye employe1 = new Employe("Teo","jouer au casino", 12);
            IEmploye employe2 = new Employe("Alexis","tricoter", 15);
            Chef chef1 = new Chef("Etienne","coudre", 20000);

            Console.WriteLine(employe2);
            Console.WriteLine($"{employe2.Name} : {employe2.Salaire}");

            Console.WriteLine(employe2.Travaille());
            Console.WriteLine(chef1.Travaille());

            chef1.Augmente(employe2);
            Console.WriteLine($"Voici le nouveau Salaire de {employe2.Name} : {employe2.Salaire}");

            Societ zeuchan = new Societ()
            {
                Name = "Auchan",
                Employes = new IEmploye[] {employe1, employe2, chef1,new MachineCafe()}
            };
            Console.WriteLine(zeuchan.Travaille());
            Console.WriteLine(zeuchan.GetChef());
            //Console.WriteLine(zeuchan.Stalker());

            
        }
    }
}