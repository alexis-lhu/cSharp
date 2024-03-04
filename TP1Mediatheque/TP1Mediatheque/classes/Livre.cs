namespace TP1Mediatheque.classes
{
    public class Livre : ObjetDePret {
        public Livre(string Titre, string Auteur) : base(Titre) { this.Auteur = Auteur; }
    
        public string Auteur { get; set; }  

        public override string ToString()
        {
            return $"Titre : {Titre}, Date de Création : {DateCreation}, Auteur : {Auteur}";
        }    
    }

}
