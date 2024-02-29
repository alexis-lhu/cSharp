namespace Societe.Modele
{
    public class Employe : Personne
    {
        public Employe(string name, double salaire) : base(name) { this.Salaire = Salaire; }

        public double Salaire { get; set; }

        public virtual string Travaille() { return $"{this.Name} travaille"; }
        public override string ToString() { return $"{base.ToString()} et mon salaire est de {this.Salaire}"; }

    }
}
