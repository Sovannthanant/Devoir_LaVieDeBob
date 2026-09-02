
namespace LaVieDeBob.Classes
{
    internal class Personne
    {
        // Déclarations des propriétés.
        public string nom { get; set; }
        public string prenom { get; set; }
        
        // Déclaration de constructeur.
        public Personne(string nom_donne, string prenom_donee)
        {
            string nom = nom_donne;
            string prenom = prenom_donee;
        }

        // Déclarations des méthodes.
        public void Travailler()
        {
            throw new System.NotImplementedException();
        }

        public void Nourrir()
        {
            throw new System.NotImplementedException();
        }
    }
}
