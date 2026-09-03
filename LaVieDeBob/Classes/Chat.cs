
namespace LaVieDeBob.Classes
{
    public class Chat : Animal
    {
        // Déclarations des propriétés parent.
        public Chat(string nom, float cout) : base(nom, cout) { }

        // Déclaration de constructeur.
        // Le constructeur à déjà été fait dans la classe parent.

        // Déclarations des méthodes.
        // La plupart ont déjà été fait dans la classe parent.
        public void Exprimer()
        {
            /// Retourne le son de l'animal en Console.Write().
            Console.WriteLine($"Meow");
        }

    }
}
