
// +=====+=====+===== Devoir: La vie de Bob =====+=====+=====+
using LaVieDeBob.Classes;

// +-----+-----+----- Déclaration de variables.
var programmeContinue = true;

// +-----+-----+----- Création des classes.
Emploi Programmeur = new Emploi("Programmeur", 22.50f);
Emploi TechnicienLaboratoire = new Emploi("Technicien en laboratoire", 28.00f);

Personne Bob = new Personne("Bob", "", 0.0f, metier_donne: Programmeur);
Personne Bobinette = new Personne("Bobinette", "", 0.0f, metier_donne: null);

Compte CompteDeBob = new Compte(Bob, 100.00f);

Chat Mitaine = new Chat("Mitaine", 5.0f);
Chien Roboto = new Chien("Roboto", 8.0f);
CompteDeBob.Consulter();

Mitaine.Exprimer();
Mitaine.Faim = true;

Console.WriteLine(Programmeur);
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