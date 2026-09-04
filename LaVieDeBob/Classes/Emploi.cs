
namespace LaVieDeBob.Classes
{
    public class Emploi
    {
        // Déclarations des propriétés.
        public string Titre { get; set; }
        public float Salaire { get; set; }


        // Déclaration du constructeur.
        public Emploi(string titre, float salaire)
        {
            Titre = titre;
            Salaire = salaire;
        }


        // Déclarations des méthodes.
        public override string ToString()
        {
            /// Retourne un string spécifique quand "Console.Write()".
            return $"+-----+-----+-----+-----+\n" +
                $"Information de l'emploi\n" +
                $"Titre = {Titre} | Salaire = {Salaire}$/h";
        }

    }
}
