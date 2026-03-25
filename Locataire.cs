class Locataire
{
    static int id;
    private string nom;
    private string telephone;
    public Locataire(string nom, string telephone)
    {
        this.nom = nom;
        this.telephone = telephone;
        id++;
    }
    public void Afficher()
    {
        Console.WriteLine($"nom du locataire: {nom} | telephone: {telephone}");
    }
}