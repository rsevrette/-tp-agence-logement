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
}