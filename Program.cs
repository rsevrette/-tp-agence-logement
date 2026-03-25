namespace TP3_POO_heritage;

class Program
{
    static void Main(string[] args)
    {
        //Partie 1
        Logement logement1 = new Logement("maison1", "rue", 100, 500, true);
        logement1.Afficher();
        Logement logement2 = new Logement("appart1", "rue", -100, -500, false);
        logement2.Afficher();

        //Partie2
        Studio studio1 = new Studio("studio1", "8 rue", 90, 600, true, true);
        studio1.Afficher();
        Appartement appartement1 = new Appartement("appartement1", "rue", 90, 550, false, 2);
        appartement1.Afficher();
        Maison maison1 = new Maison("maison2", "rue", 400, 3000, true, 300);
        maison1.Afficher();
        Console.WriteLine();

        //Partie4
        Console.WriteLine("______________Partie 4______________");
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
    }
}
