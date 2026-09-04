
// +=====+=====+===== Devoir: La vie de Bob =====+=====+=====+
using LaVieDeBob.Classes;

// +-----+-----+----- Déclaration de variables.
var programmeContinue = true;

// +-----+-----+----- Création des classes.
Personne Bob = new Personne("Bob", "", "Programmeur", 10.50f);
Personne Bobinette = new("Bobinettte", "", "Technicien en laboratoire", 28.00f);

Chat Mitaine = new Chat("Mitaine", 5.0f);
Chien Roboto = new Chien("Roboto", 8.0f);

Mitaine.Exprimer();
Mitaine.Faim = true;

Console.WriteLine(Bob);
Console.WriteLine(Bobinette);

DateTime dateTest = DateTime.Now;
Console.WriteLine(dateTest);

// +-----+-----+----- Programme principal.
while (programmeContinue == true) ;
{
    Console.WriteLine("Choissisez un choix");
    string reponse = Console.ReadLine();
}

