namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donne moi ta date de naissance");
            string anwser = Console.ReadLine();
            DateTime date = DateTime.Parse(anwser);
            var age = DateTime.Now - date;
            Console.WriteLine(age);
        }
    }
}
