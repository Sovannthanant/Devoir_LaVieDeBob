
// +=====+=====+===== Devoir: La vie de Bob =====+=====+=====+
using LaVieDeBob.Classes;

// +-----+-----+----- Création des classes.
Emploi Programmeur = new Emploi("Programmeur", 22.50f);
Emploi TechnicienLaboratoire = new Emploi("Technicien en laboratoire", 28.00f);

Personne Bob = new Personne("Bob", "", 0.0f, metier_donne: Programmeur);
Personne Bobinette = new Personne("Bobinette", "", 0.0f, metier_donne: null);

Compte CompteDeBob = new Compte(Bob, 100.00f);

Chat Mitaine = new Chat("UnAnimal", 10.0f);

Console.WriteLine(CompteDeBob);
CompteDeBob.Consulter();
Mitaine.Exprimer();