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
    }
}
