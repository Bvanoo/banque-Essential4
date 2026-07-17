namespace banque
{
    public abstract class Compte : IBanker
    {
        public Compte(double Solde)
        {
            this.Solde = Solde;
        }

        public Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
            Solde = 0;
        }

        public Compte(string numero, Personne titulaire, double solde)
        {
            Numero = numero;
            Titulaire = titulaire;
            Solde = solde;
        }

        public string Numero { get; private set; } = null!;
        public double Solde { get; private set; }
        public Personne Titulaire { get; private set; } = null!;

        public virtual void Retrait(double Montant) { }
        public virtual void Depot(double Montant) { }
        protected abstract double CalculInteret();

        public double AppliquerInteret()
        {
            Solde += CalculInteret();
            return Solde;
        }

        protected void ModifierSolde(double montant)
        {
            Solde = montant;
        }
    }
}
