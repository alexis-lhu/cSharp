namespace TP1Mediatheque.classes
{
    public class CD : ObjetDePret
    {
        public CD(string Titre, string Groupe) : base(Titre)
        {
            this.Groupe = Groupe ;
        }
        public string Groupe { get; set;}

        public override string ToString()
        {
            return $"Titre : {Titre}, Date de Création: {DateCreation}, Groupe : {Groupe}";
        }
    }

}
