namespace banque
{
    public class Personne
    {
        public string Nom { get; private set; } = null!;
        public string Prenom { get; private set; } = null!;
        public DateTime DateNaiss { get; private set; }

        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }
    }
}
