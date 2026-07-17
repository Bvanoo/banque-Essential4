namespace banque
{
    public class Epargne : Compte
    {
        public Epargne(double Solde) : base(Solde) { }

        public Epargne(string numero, Personne titulaire) : base(numero, titulaire) { }

        public Epargne(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde) { }

        public DateTime DateDernierRetrait { get; private set; }

        public override void Retrait(double montant)
        {
        }

        public override void Depot(double Montant)
        {
        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }
    }
}
