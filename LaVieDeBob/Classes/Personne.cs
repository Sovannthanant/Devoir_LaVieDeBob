
namespace LaVieDeBob.Classes
{
    internal class Personne
    {
        // Déclarations des propriétés.
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Emploi Metier { get; set; }

        // Déclaration de constructeur.
        public Personne(string nom_donne, string prenom_done, Emploi metier_donne)
        {
            Nom = nom_donne;
            Prenom = prenom_done;
            Metier = metier_donne;
        }

        // Déclarations des méthodes.
        public float Travailler(int heures)
        {
            /// Retourne une paye avec le salaire du "Metier" et des "heures" données.
            float salaire = Metier.Salaire;
            float paye = salaire * heures;
            return paye;
        }

        public void Nourrir()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            /// Retourne un string spécifique quand "Console.Write()".
            if (Metier != null)
            {
                return $"Nom = {Nom}\nPrenom = {Prenom}\nEmploi = {Metier.Titre}";
            }
            else
            {
                return $"Nom = {Nom}\nPrenom = {Prenom}";
            }
        }

    }
}
