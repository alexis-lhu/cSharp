namespace Societe.Modele
{
    public class Chef : Employe
    {
        public Chef(string name,string HobbyHonteux, double salaire) : base(name,HobbyHonteux, salaire)
        { }
        public override string Travaille() { return $"{this.Name} zzz $$$ zzz"; }

        //Faire la methode augmente qui augmente le salaire dun employé.
        public double Augmente(IEmploye empAugm)
        {
            double mutliplicateur = 1.35;
            empAugm.Salaire = empAugm.Salaire * mutliplicateur;
            empAugm.Salaire = Math.Round(empAugm.Salaire, 2);
            return empAugm.Salaire;
        }

    }
}
