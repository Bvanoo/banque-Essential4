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

        }
        public void Supprimer(string numero)
        {

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










//Classe animal avec 2 champs, Nom, une methode Cri() en virtuelle
//Classe enfant (par exemple chien) qui va avoir une methode qui ecrase le cri pour mettre le cri de l'animal en question
//Faite 3 classe enfant et afficher le cri dans la console 
















