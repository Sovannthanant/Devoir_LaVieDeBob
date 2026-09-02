
namespace LaVieDeBob.Classes
{
    internal class Animal
    {
        // Déclarations des propriétés.
        public int nom { get; set; }
        public int cout { get; set; }

        // Déclaration de constructeur.
        public Animal(string nom_donne, float cout_donne)
        {
            string nom = nom_donne;
            float cout = cout_donne;
        }

        // Déclarations des méthodes.
        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public void Exprimer()
        {
            throw new System.NotImplementedException();
        }
    }
}
