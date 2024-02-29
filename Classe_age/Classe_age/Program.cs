namespace Classe_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entier1 = 12;
            int entier2 = entier1;
            entier1++;
            Console.WriteLine($"Voici le nombre entier 1 {entier1} et voici le second {entier2}");

            EtreVivant personne1 = new EtreVivant();
            //Console.WriteLine($"Personne1 {personne1.DateDeNaissance} age : {personne1.CalculAge()}");

            EtreVivant personne2 = new EtreVivant(new DateTime(2020, 11, 30));
            Console.WriteLine($"Personne2 {personne2.DateDeNaissance} age : {personne2.CalculAge()}");

            EtreVivant personne3 = personne2;
            personne2.DateDeNaissance = personne2.DateDeNaissance.AddYears(1);
            Console.WriteLine($"Personne3 {personne3.DateDeNaissance} age : {personne3.CalculAge()}");

            int integerNew = 10;
            EtreVivant personneNew = new EtreVivant();
            Console.WriteLine($"PersonneNew {personneNew.DateDeNaissance} age : {personneNew.CalculAge()}");
            ModifBirth(personneNew,integerNew);
            Console.WriteLine($"modif de son age {personneNew.CalculAge()}");

        }
        public static void ModifBirth(EtreVivant pVivante,int entier)
        {
            pVivante.DateDeNaissance = pVivante.DateDeNaissance.AddYears(10);
            entier += 10;
        }
    }
}
