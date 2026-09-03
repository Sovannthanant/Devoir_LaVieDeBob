
// +=====+=====+===== Devoir: La vie de Bob =====+=====+=====+
using LaVieDeBob.Classes;

// +-----+-----+----- Création des classes.
Emploi programmeur = new Emploi("Programmeur", 22.50f);
Emploi technicienLaboratoire = new Emploi("Technicien en laboratoire", 28.00f);
Console.WriteLine(programmeur);

Personne Bob = new Personne("Bob", "", metier_donne: programmeur);
Personne Bobinette = new Personne("Bobinette", "", metier_donne: null);
Console.WriteLine(Bob);
Console.WriteLine(Bobinette);