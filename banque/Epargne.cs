namespace banque
{
    public class Epargne : Compte
    {
        public Epargne(double Solde) : base(Solde) { }
        DateTime DateDernierRetrait { get; set; }
        public override void Retrait(double montant )
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
