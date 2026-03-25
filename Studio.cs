class Studio : Logement
{
    private bool meuble;

    public Studio(string reference, string adresse, int surface, double loyerBase, bool disponible, bool meuble): base(reference,  adresse, surface, loyerBase, disponible)
    {
        this.meuble = meuble;
    }
    public override void Afficher()
    {
        Console.WriteLine($"{reference} | {adresse} | surface: {surface} | loyer: {loyerBase} | disponible: {disponible} | meublé: {meuble}");
    }
    public override void CalculerLoyer()
    {
        double loyerCalculer;
        if (meuble) 
        {
            loyerCalculer = loyerBase + 50;
            Console.WriteLine($"loyer calculer: {loyerCalculer} €");
        }
        else Console.WriteLine($"loyer calculer: {loyerBase} €");
    }
}