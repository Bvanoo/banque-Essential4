namespace banque
{
    public abstract class Compte
    {
        public Compte(double Solde)
        {
            this.Solde=Solde;
        }
        public string Numero { get; set; } = null!;
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; } = null!;
        public virtual void Retrait(double Montant) { }
        public virtual void Depot(double Montant) { }
        protected abstract double CalculInteret();
        public double AppliquerInteret()
        {
            Solde += CalculInteret();
            return Solde;
        }
    }
}
