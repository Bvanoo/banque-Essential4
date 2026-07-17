namespace banque
{
    public interface IBanker : ICustomer
    {
        string Numero { get; }
        Personne Titulaire { get; }
        double AppliquerInteret();

    }
}