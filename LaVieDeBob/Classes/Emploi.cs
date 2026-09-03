
namespace LaVieDeBob.Classes
{
    internal class Emploi
    {
        // Déclarations des propriétés.
        public string Titre { get; set; }
        public float Salaire { get; set; }

        // Déclaration de constructeur.
        public Emploi(string titre_donne, float salaire_donne)
        {
            Titre = titre_donne;
            Salaire = salaire_donne;
        }

        // Déclarations des méthodes.
        public override string ToString()
        {
            /// Retourne un string spécifique quand "Console.Write()".
            return $"Titre = {Titre}\nSalaire = {Salaire}$/h";
        }

    }
}
