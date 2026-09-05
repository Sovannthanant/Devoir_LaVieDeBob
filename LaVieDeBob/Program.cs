
// +=====+=====+===== Devoir: La vie de Bob =====+=====+=====+
using LaVieDeBob;
using LaVieDeBob.Classes;

// Création des classes.
Personne Bob = new("Bob", "", "Programmeur", 10.50f);
Personne Bobinette = new("Bobinettte", "", "Technicien en laboratoire", 28.00f);
Chat Mitaine = new("Mitaine", 5.0f);
Chien Roboto = new("Roboto", 8.0f);
DateTime heure_actuelle = DateTime.Now;

// Programme principal.
string choix;
do
{
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine($"Il est présentement {heure_actuelle:f}. Choisir une option:");
    Console.WriteLine("1. Voir le solde du compte");
    Console.WriteLine("2. Travailler (8h)");
    Console.WriteLine("3. Dormir (8h)");
    Console.WriteLine("4. Passer le temps (2h)");
    Console.WriteLine("5. Nourrir Mitaine");
    Console.WriteLine("6. Nourrir Roboto");
    Console.WriteLine("q. Quitter");
    Console.WriteLine("-----------------------------------------------------------------");
    choix = Console.ReadLine() ?? "";

    switch (choix)
    {
        case "1":
            Console.WriteLine($"Le solde du compte est {Bob.Compte.Solde}$");
            break;
        case "2":
            Utilitaires.PasserLeTemps(heure_actuelle, 8);
            Console.WriteLine($"Vous avez travaillé 8h et gagné {Bob.Travailler(8)}$. Il" +
                $"est maintenant {heure_actuelle:f}");
            break;
        case "3":
            // TODO : Passer le temps
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Vous avez dormi 8h. Il est maintenant {heure_actuelle:f}");
            Console.ResetColor();
            break;
        case "4":
            Utilitaires.PasserLeTemps(heure_actuelle, 2);
            Console.WriteLine($"Vous avez passé le temps de 2h. Il est maintenant {heure_actuelle:f}");
            break;
        case "5":
            // TODO: Nourrir Mitaine.
            break;
        case "6":
            // TODO: Nourrir Roboto.
            break;
    }

} while (choix != "q");

Console.WriteLine("Au revoir!");