class Appartement : Logement
{
    private int nombrePieces;
    public Appartement (string reference, string adresse, int surface, double loyerBase, bool disponible, int nombrePieces) : base(reference,  adresse, surface, loyerBase, disponible)
    {
        if (nombrePieces <= 0) Console.WriteLine("ERREUR: l'appartement doit possezder au moins une piece");
        this.nombrePieces = nombrePieces;
    }
    public override void Afficher()
    {
        Console.WriteLine($"{reference} | {adresse} | surface: {surface} | loyer: {loyerBase} | disponible: {disponible} | nb piece: {nombrePieces}");
    }
    public override double CalculerLoyer()
    {
        double loyerCalcule = loyerBase + (100 * nombrePieces);
        Console.WriteLine($"Loyer calculé: {loyerCalcule} €");
        return loyerCalcule;
    }
}