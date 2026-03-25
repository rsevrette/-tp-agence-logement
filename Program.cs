namespace TP3_POO_heritage;

class Program
{
    static void Main(string[] args)
    {
        //Partie 1
        Console.WriteLine("\n______________Partie 1______________");
        Logement logement1 = new Logement("maison1", "rue", 100, 500, true);
        logement1.Afficher();
        Logement logement2 = new Logement("appart1", "rue", -100, -500, false);
        logement2.Afficher();

        //Partie2
        Console.WriteLine("\n______________Partie 2______________");
        Studio studio1 = new Studio("studio1", "8 rue", 90, 600, true, true);
        studio1.Afficher();
        Appartement appartement1 = new Appartement("appartement1", "rue", 90, 550, false, 2);
        appartement1.Afficher();
        Maison maison1 = new Maison("maison2", "rue", 400, 3000, true, 300);
        maison1.Afficher();
        Console.WriteLine();

        //Partie4
        Console.WriteLine("\n______________Partie 4______________");
        logement1.Afficher();
        logement1.CalculerLoyer();
        logement2.Afficher();
        logement2.CalculerLoyer();
        studio1.Afficher();
        studio1.CalculerLoyer();
        appartement1.Afficher();
        appartement1.CalculerLoyer();
        maison1.Afficher();
        maison1.CalculerLoyer();

        //Partie5
        Console.WriteLine("\n______________Partie 5______________");
        List<Logement> logements = new List<Logement>();
        logements.Add(studio1);
        logements.Add(appartement1);
        logements.Add(maison1);
        foreach (Logement l in logements)
        {
            if (l is Studio studio)
            {
                studio.Afficher();
                studio.CalculerLoyer();
            }
            else if (l is Appartement appartement)
            {
                appartement.Afficher();
                appartement.CalculerLoyer();
            }
            else if (l is Maison maison)
            {
                maison.Afficher();
                maison.CalculerLoyer();
            }
        }
    }
}
