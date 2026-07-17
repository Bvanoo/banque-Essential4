namespace banque
{
    public class Courant : Compte
    {
        public Courant(double Solde) : base(Solde)
        {

        }
        private double _ligneDeCredit;

        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set
            {
                if (value >= 0)
                    _ligneDeCredit = value;
                else
                    Console.WriteLine("La valeur doit être supérieure ou égale à 0.");
            }
        }
        public override void Retrait(double Montant)
        {

        }
        public override void Depot(double Montant)
        {

        }

        public static double operator +(Courant c1, Courant c2)
        {
            double s1 = c1.Solde > 0 ? c1.Solde : 0;
            double s2 = c2.Solde > 0 ? c2.Solde : 0;
            return s1 + s2;
        }
        protected override double CalculInteret()
        {
            return Solde >= 0 ? Solde * 0.03 : Solde * 0.0975;
        }
    }
}
