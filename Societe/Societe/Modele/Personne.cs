namespace Societe.Modele
{
    public class Personne
    {
        public string Name { get; private set; }
        public Personne(string name) {  this.Name = name; }

        public override string ToString() { return $"Je m'appelle {this.Name}"; }
    }
}
