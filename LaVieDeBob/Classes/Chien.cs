
namespace LaVieDeBob.Classes
{
    public class Chien : Animal
    {
        // Déclarations des propriétés parent.
        public Chien(string nom, float cout) : base(nom, cout) { }

        // Déclaration de constructeur.
        // Le constructeur à déjà été fait dans la classe parent.

        // Déclarations des méthodes.
        // Plupart des méthodes ont déjà été fait dans la classe parent.

        /* public asbstract ___() }{}, doit être mis dans les classes
         enfants. */

        public void Exprimer()
        {
            /// Retourne le son de l'animal en Console.Write().
            Console.WriteLine($"Wouff");
        }

    }
}
