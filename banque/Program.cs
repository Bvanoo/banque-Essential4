using banque;

// Créer une personne
Personne titulaire = new Personne("Dupont", "Jean", new DateTime(1990, 5, 15));

// Créer un compte courant avec numéro et titulaire
Courant c1 = new Courant("001", titulaire);
c1.LigneDeCredit = 1000;

// Ou créer un compte courant avec ligne de crédit directement
Courant c2 = new Courant("002", titulaire, 500);

Console.WriteLine(c1.AppliquerInteret());

