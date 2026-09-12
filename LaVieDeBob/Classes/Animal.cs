
namespace LaVieDeBob.Classes
{
    public abstract class Animal
    {
        // Déclarations des propriétés.
        public string Nom { get; set; }
        public float Cout { get; set; }
        public bool Faim { get; private set; }
        public TimeSpan Pause { get; private set; }

        // Déclaration de constructeur.
        protected Animal(string nom, float cout, TimeSpan pause)
        {
            Nom = nom;
            Cout = cout;
            Faim = false;
            Pause = pause;
        }

        public string Exprimer()
        {
            /// Retourne le son de l'animal en Console.Write().
            return$"*Son d'animal*";
        }

    }
}
