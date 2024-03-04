namespace Societe.Modele
{
    public interface IEmploye
    {
        string Name { get; }
        double Salaire { get; set; }

        string Travaille();
    }
    }

