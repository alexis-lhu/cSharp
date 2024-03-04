namespace Societe.Modele
{
    public class Personne
    {
        public string Name { get; private set; }
        public string HobbyHonteux { get; set; }
        public Personne(string name, string HobbyHonteux) { this.Name = name; this.HobbyHonteux = HobbyHonteux; }

        public override string ToString() { return $"Je m'appelle {this.Name}"; }
    }
}
