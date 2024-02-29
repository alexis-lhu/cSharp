namespace Societe.Modele
{
    public class Chef : Employe
    {
        public Chef(string name, double salaire) : base(name, salaire)
        { }
        public override string Travaille() { return $"{this.Name} zzz"; }

        //Faire la methode augmente qui augmente le salaire dun employé.
    }
}
