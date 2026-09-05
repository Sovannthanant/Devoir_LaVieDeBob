
namespace LaVieDeBob.Classes
{
    public class Chat : Animal
    {
        // Déclarations des propriétés parent.
        public Chat(string nom, float cout, TimeSpan pause) :
            base(nom, cout, pause) { }

        // Déclaration de constructeur.
        // Le constructeur à déjà été fait dans la classe parent.

        // Déclarations des méthodes.
        // La plupart ont déjà été fait dans la classe parent.
        public string Exprimer()
        {
            /// Retourne le son de l'animal en Console.Write().
            return $"*Meow*";
        }

    }
}
