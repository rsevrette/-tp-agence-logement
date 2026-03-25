class Logement
{
    public string reference;
    protected string adresse;
    protected int surface;
    protected double loyerBase;
    public bool disponible;

    public Logement(string reference, string adresse, int surface, double loyerBase, bool disponible)
    {
        if (surface < 0) Console.WriteLine("la surface doit etre positive");
        else this.surface = surface;
        if (loyerBase < 0) Console.WriteLine("le loyer doit etre positif");
        else this.loyerBase = loyerBase;
        this.reference = reference;
        this.adresse = adresse;
        this.disponible = disponible;
    }
    public virtual void Afficher()
    {
        Console.WriteLine($"{reference} | {adresse} | surface: {surface} | loyer: {loyerBase} | disponible: {disponible}");
    }
    public virtual double CalculerLoyer()
    {
        Console.WriteLine($"Loyer calculé: {loyerBase} €");
        return loyerBase;
    }
}