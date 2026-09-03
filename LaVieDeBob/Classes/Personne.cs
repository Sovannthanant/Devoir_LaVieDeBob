
namespace LaVieDeBob.Classes
{
    internal class Personne
    {
        // Déclarations des propriétés.
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public float Argent { get; set; }
        public Emploi Metier { get; set; }

        // Déclaration de constructeur.
        public Personne(string nom_donne, string prenom_donne, float argent_donne ,
            Emploi metier_donne)
        {
            Nom = nom_donne;
            Prenom = prenom_donne;
            Argent = argent_donne;
            Metier = metier_donne;
        }

        // Déclarations des méthodes.
        public void Travailler(int heures)
        {
            /// Retourne une paye avec le salaire du "Metier" et des "heures" données.
            float salaire = Metier.Salaire;
            Argent += salaire * heures;
        }

        public void Nourrir()
        {
            /// TODO: Fonction qui nourrit un animal.
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            /// Retourne un string spécifique quand "Console.Write()".
            if (Metier != null)
            {
                return $"+-----+-----+-----+-----+\n" +
                    $"Information de la personne.\n" +
                    $"Nom/Prenom = {Nom} {Prenom}\nEmploi = {Metier.Titre}";
            }
            /// Si la personne est non employé.
            else
            {
                return $"+-----+-----+-----+-----+\n" +
                    $"Information de la personne.\n" +
                    $"Nom = {Nom} {Prenom}";
            }
        }

    }
}
