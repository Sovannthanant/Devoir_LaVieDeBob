
namespace LaVieDeBob.Classes
{
    public abstract class Animal
    {
        // Déclarations des propriétés.
        public string Nom { get; set; }
        public float Cout { get; set; }

        // Déclaration de constructeur.
        public Animal(string nom_donne, float cout_donne)
        {
            Nom = nom_donne;
            Cout = cout_donne;
        }

        // Déclarations des méthodes.
        public void Manger()
        {
            throw new System.NotImplementedException();
        }

        public void Exprimer()
        {
            Console.WriteLine($"*Son d'animal*");
        }

    }
}
