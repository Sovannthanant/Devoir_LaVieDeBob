
// +=====+=====+===== Devoir: La vie de Bob =====+=====+=====+
using LaVieDeBob;
using LaVieDeBob.Classes;

// Déclaration de variables / Création des classes.
TimeSpan pauseMitaine = new(10, 0, 0);
TimeSpan pauseRoboto = new(8, 0, 0);

Personne Bob = new("Bob", "", "Programmeur", 10.50f);
Personne Bobinette = new("Bobinettte", "", "Technicien en laboratoire", 28.00f);
Chat Mitaine = new("Mitaine", 5.0f, pauseMitaine);
Chien Roboto = new("Roboto", 8.0f, pauseRoboto);

DateTime heureActuelle = DateTime.Now;
DateTime dernierRepasMitaine = DateTime.Now;
DateTime dernierRepasRoboto = DateTime.Now;

// Programme principal.
string choix;
do
{
    Console.WriteLine("-----------------------------------------------------------------");
    Console.WriteLine($"Il est présentement {heureActuelle:f}. Choisir une option:");
    Console.WriteLine("1. Voir le solde du compte");
    Console.WriteLine("2. Travailler (8h)");
    Console.WriteLine("3. Dormir (8h)");
    Console.WriteLine("4. Passer le temps (2h)");
    Console.WriteLine("5. Nourrir Mitaine");
    Console.WriteLine("6. Nourrir Roboto");
    Console.WriteLine("q. Quitter");
    Console.WriteLine("-----------------------------------------------------------------");

    // Calcule du temps afin de voir si les animaux ont faim.
    /// ".Subtract" soustrait deux objet "DateTime" et donne un objet "TimeSpan".
    /// "DateTime(0,0,0, 0,0,0) (Date et Heure)" et "TimeSpan(0,0,0) (Période Temps)".
    if (heureActuelle.Subtract(dernierRepasMitaine) >= Mitaine.Pause)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Mitaine à faim et dit: {Mitaine.Exprimer()}");
        Console.ResetColor();
    }
    if (heureActuelle.Subtract(dernierRepasRoboto) >= Roboto.Pause)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Roboto à faim et dit: {Roboto.Exprimer()}");
        Console.ResetColor();
    }

    choix = Console.ReadLine() ?? "";

    switch (choix)
    {
        case "1":
            Console.WriteLine($"Le solde du compte est {Bob.Compte.Solde}$");
            break;
        case "2":
            heureActuelle = Utilitaires.PasserLeTemps(heureActuelle, 8);
            Console.WriteLine($"Vous avez travaillé 8h et gagné {Bob.Travailler(8)}$. Il" +
                $"est maintenant {heureActuelle:f}");
            break;
        case "3":
            heureActuelle = Utilitaires.PasserLeTemps(heureActuelle, 8);
            Console.WriteLine($"Vous avez dormi 8h. Il est maintenant {heureActuelle:f}");
            break;
        case "4":
            heureActuelle = Utilitaires.PasserLeTemps(heureActuelle, 2);
            Console.WriteLine($"Vous avez passé le temps de 2h. Il est maintenant {heureActuelle:f}");
            break;
        case "5":
            if (Bob.Compte.Solde - Mitaine.Cout >= 0)
            {
                Bob.Compte.Solde -= Mitaine.Cout;
                dernierRepasMitaine = heureActuelle;
            }
            else
            { Console.WriteLine($"Vous avez {Bob.Compte.Solde} et ne pouvez pas nourrir Mitaine."); }
            break;
        case "6":
            if (Bob.Compte.Solde - Roboto.Cout >= 0)
            {
                Bob.Compte.Solde -= Roboto.Cout;
                dernierRepasRoboto = heureActuelle;
            }
            else
            { Console.WriteLine($"Vous avez {Bob.Compte.Solde} et ne pouvez pas nourrir Roboto."); }
            break;
    }

} while (choix != "q");

Console.WriteLine("Au revoir!");