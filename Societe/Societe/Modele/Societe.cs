using System.Text;

namespace Societe.Modele
{
    public class Societ
    {
        public string Name { get; set; }
        public IEmploye[] Employes { get; set; }

        public string Travaille()
        {
            StringBuilder sb = new StringBuilder();
            this.Employes.ToList().ForEach(emp => sb.Append(emp.Travaille() + Environment.NewLine));
            return sb.ToString();
        }

        public Chef? GetChef()
        {
            //return (Chef)this.Employes.ToList().Single(empl => empl is Chef);  //one line

            foreach (IEmploye emp in this.Employes)
            {
                if (emp is  Chef)
                {
                    return (Chef)emp;
                }
            } return null;
        }
        /*public string Stalker()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IEmploye employe in this.Employes)
            {
                sb.Append(employe.Name + ":" + employe.HobbyHonteux + Environment.NewLine);
            }
            return sb.ToString();
        }*/
    }
}
