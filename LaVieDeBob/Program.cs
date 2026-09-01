
/*
Bob à un compte bancaire à son nom.
22,50$/h.
2 animaux.
les animaux laisse un Console.WriteLine "Miaou" et "Wouff" quands il sont faim.
5$ pour le chat et 8$ pour le chien.
lorsque nourrit, une date est marquée.
    À chaque 10h pour le chat
    À chaque 8h pour le chien

Modéliser et créer toutes les classes, propriétés et méthodes nécessaires pour
représenter la situation. S'assurer que :

Bob puisse travailler, manipuler son argent et nourrir ses animaux. Les animaux
puissent s'exprimer et manger selon les restrictions imposées.D'ajouter une
fonction qui permet d'avancer le temps.


Création d'un diagramme.
Clique-droit sur le projet "LaVieDeBob", glissez la sourie sur "ajouter", puis
"nouvel élément" et choisissez "diagramme de classse".
*/

namespace DevoirLaVieDeBob
{
    class Program
    {
        public class compteBancaire
        {
            public string Nom {  get; }
            public float Argent {  get; }

            // Constructeur
            public compteBancaire()
            {
                Nom = "";
                Argent = 0.0f;
            }

            // Remplace Console.Writeline
            public override string ToString()
            {
                return $"nom = {Nom}\nArgent = {Argent}";
            }

        }
    }
}