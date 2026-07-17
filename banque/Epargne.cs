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
            if (montant <= 0)
            {
                Console.WriteLine("Le montant du retrait doit être positif.");
                return;
            }

            if (montant > Solde)
            {
                Console.WriteLine($"Solde insuffisant. Solde actuel : {Solde}");
                return;
            }

            ModifierSolde(Solde - montant);
            DateDernierRetrait = DateTime.Now;
            Console.WriteLine($"Retrait de {montant}€ effectué. Nouveau solde : {Solde}");
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

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }
    }
}
