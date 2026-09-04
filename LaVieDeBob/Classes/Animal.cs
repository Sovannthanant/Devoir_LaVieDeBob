
namespace LaVieDeBob.Classes
{
    public abstract class Animal
    {
        // Déclarations des propriétés.
        public string Nom { get; set; }
        public float Cout { get; set; }
        public bool Faim { get; set; }

        // Déclaration de constructeur.
        protected Animal(string nom_donne, float cout_donne)
        {
            Nom = nom_donne;
            Cout = cout_donne;
            Faim = false;
        }

        // Déclarations des méthodes.
        public void Manger()
        {
            /// Change le statue de faim positif en négatif.
            if (Faim == true)
            {
                Faim = false;
            }
        }

        /* public asbstract ___() }{}, doit être mis dans les classes
         enfants. */

        public string Exprimer()
        {
            /// Retourne le son de l'animal en Console.Write().
            return$"*Son d'animal*";
        }

    }
}
