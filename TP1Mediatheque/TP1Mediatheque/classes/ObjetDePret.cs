using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP1Mediatheque.classes
{
    public class ObjetDePret
    {
        public string Titre { get; set; }
        public DateOnly DateCreation { get; private set; }

        public ObjetDePret(string Titre)
        {
            this.Titre = Titre;
            DateCreation = DateOnly.FromDateTime(DateTime.Now);
        }
        public override string ToString()
        {
            return $"Titre : {Titre}, Date de Création : {DateCreation}";
        }
    }

}
