namespace Classe_age
{
    public class EtreVivant
    {
        public DateTime DateDeNaissance { get; set; }
        public EtreVivant(DateTime dateDeNaissance)
        {
            this.DateDeNaissance = dateDeNaissance;
        }
        public EtreVivant()
        {
            this.DateDeNaissance = DateTime.Now;

        }
        public int CalculAge() { 
            var ageAbs = DateTime.Now - this.DateDeNaissance;
            var ageFloat = ageAbs.TotalDays/365.2422;
            return (int)Math.Floor(ageFloat);
            
        }
    }
}
