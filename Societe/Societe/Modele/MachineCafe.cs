namespace Societe.Modele
{
    public class MachineCafe : IEmploye
    {
        public double Salaire { get ; set; }

        public string Name { get; }

        public string Travaille()
        {
            return "Miam le café";
        }
    }
}
