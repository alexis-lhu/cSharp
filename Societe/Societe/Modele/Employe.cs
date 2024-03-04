namespace Societe.Modele
{
    public class Employe : Personne, IEmploye
        {
            public double Salaire { get; set; }

            public Employe(string name,string HobbyHonteux, double salaire) : base(name, HobbyHonteux)
            {
                this.Salaire = salaire;
            }

            public virtual string Travaille()
            {
                return $"{this.Name} travaille...";
            }

            public override string ToString()
            {
                return $"{base.ToString()} Je gagne {this.Salaire} € / mois !";
            }
        }
    }

