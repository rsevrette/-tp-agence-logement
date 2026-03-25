class Maison : Logement
{
    private int surfaceJardin;
    public Maison (string reference, string adresse, int surface, double loyerBase, bool disponible, int surfaceJardin): base(reference,  adresse, surface, loyerBase, disponible)
    {
        if (surfaceJardin < 0) Console.WriteLine("ERREUR: la surface du jardin doit etre positive ou nulle");
        this.surfaceJardin = surfaceJardin;
    }
    public override void Afficher()
    {
        Console.WriteLine($"{reference} | {adresse} | surface: {surface} | loyer: {loyerBase} | disponible: {disponible} | surface jardin: {surfaceJardin}");
    }
}