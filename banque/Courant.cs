namespace banque
{
    public class Courant : Compte
    {
        public Courant(double Solde) : base(Solde)
        {
        }

        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
            LigneDeCredit = 0;
        }

        public Courant(string numero, Personne titulaire, double ligneDeCredit) : base(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
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
            if (Montant <= 0)
            {
                Console.WriteLine("Le montant du retrait doit être positif.");
                return;
            }

            double disponible = Solde + LigneDeCredit;

            if (Montant > disponible)
            {
                Console.WriteLine($"Solde insuffisant. Disponible : {disponible}");
                return;
            }

            ModifierSolde(Solde - Montant);
            Console.WriteLine($"Retrait de {Montant}€ effectué. Nouveau solde : {Solde}");
        }

        public override void Depot(double Montant)
        {
            if (Montant <= 0)
            {
                Console.WriteLine("Le montant du dépôt doit être positif.");
                return;
            }

            ModifierSolde(Solde + Montant);
            Console.WriteLine($"Dépôt de {Montant}€ effectué. Nouveau solde : {Solde}");
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
