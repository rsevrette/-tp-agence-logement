class ContratLocation
{
    private int numero;
    private Locataire locataire;
    private Logement logement;
    private int nombreJours;
    private double tarifJournalier;

    public ContratLocation(int numero, Locataire locataire, Logement logement, int nombreJours)
    {
        if (nombreJours <= 0)
        {
            Console.WriteLine("La durée du contrat doit être strictement positive.");
            return;
        }
        if (!logement.disponible)
        {
            Console.WriteLine("Le logement n'est pas disponible.");
            return;
        }

        this.numero = numero;
        this.locataire = locataire;
        this.logement = logement;
        this.nombreJours = nombreJours;
        this.tarifJournalier = logement.CalculerLoyer();
        logement.disponible = false;
    }

    public double CalculerMontantTotal()
    {
        return tarifJournalier * nombreJours;
    }

    public void Afficher()
    {
        Console.WriteLine($"Contrat n°{numero} | Locataire: {locataire.nom} | Logement: {logement.reference} | Durée: {nombreJours} jours | Tarif/jour: {tarifJournalier} | Total: {CalculerMontantTotal()}");
    }
}