namespace banque
{
    public class Banque
    {
        private List<Compte> comptes = new List<Compte>();
        public Compte? this[string numero]
        {
            get
            {
                //comptes.FirstOrDefault(c => c.Numero == numero); //LinQ, ca fait la même chose que ↓↓↓

                foreach (Compte c in comptes)
                {
                    if (c.Numero == numero)
                    {
                        return c;
                    }
                }
                return null;
            }
        }

        public string Nom { get; set; } = null!;

        public void Ajouter(Compte compte)
        {
            if (compte == null)
            {
                Console.WriteLine("Le compte ne peut pas être null.");
                return;
            }

            if (this[compte.Numero] != null)
            {
                Console.WriteLine($"Le compte {compte.Numero} existe déjà.");
                return;
            }

            comptes.Add(compte);
            Console.WriteLine($"Compte {compte.Numero} ajouté avec succès.");
        }

        public void Supprimer(string numero)
        {
            Compte? compte = this[numero];

            if (compte == null)
            {
                Console.WriteLine($"Le compte {numero} n'existe pas.");
                return;
            }

            comptes.Remove(compte);
            Console.WriteLine($"Compte {numero} supprimé avec succès.");
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double total = 0;
            foreach (Compte c in comptes)
            {
                if (c.Titulaire == titulaire)
                {
                    total += c.Solde;
                }
            }
            return total;
        }
    }
}
