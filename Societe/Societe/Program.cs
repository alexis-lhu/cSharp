using Societe.Modele;

namespace Societe{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne personne1 = new Personne("Thierry");

            Employe employe1 = new Employe("Teo", 12);
            Employe employe2 = new Employe("Alexis", 15);
            Chef chef1 = new Chef("Etienne", 20000);

            Console.WriteLine(employe2);
            Console.WriteLine($"{employe2.Name} : {employe2.Salaire}");

            Console.WriteLine(employe2.Travaille());
            Console.WriteLine(chef1.Travaille() );
        }
    }
}