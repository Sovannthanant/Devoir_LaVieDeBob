
namespace LaVieDeBob.Classes
{
    public class Personne
    {
        // Déclarations des propriétés.
        // Toujours get; et private set; pour ne pas changer.
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public Emploi Emploi { get; }
        public Compte Compte { get; }
        
        // Déclaration du constructeur.
        public Personne(string prenom, string nom, string titreEmploi, float salaire)
        {
            Prenom = prenom;
            Nom = nom;
            Emploi = new Emploi(titreEmploi, salaire);
            Compte = new Compte();
        }

        // Déclarations des méthodes.
        public float Travailler(int heures)
        {
            /// Retourne une paye après que la personne ait travailler des heures.
            /// Param "heures": Nombres d'heures travaillées.
            /// Return : Le salaire gagné.
            /// Exception : ArgumentOutOfRangeException.
            if (heures < 0)
                throw new ArgumentOutOfRangeException("ERREUR: Heures doit être positif.");

            float salaireGagne = heures * Emploi.Salaire;
            Compte.Deposer(salaireGagne);
            return salaireGagne;
        }

        public void Nourrir(DateTime heureRepas)
        {
            /// TODO: Nourrir l'animal et retirer le montant du repas du compte bancaire.
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            /// Retourne un string spécifique quand "Console.Write()".
            /// Si la personne est employé.
            if (Emploi != null)
            {
                return $"+-----+-----+-----+-----+\n" +
                    $"Information de la personne.\n" +
                    $"Prenom/Nom = {Prenom} {Nom} | Emploi = {Emploi.Titre}";
            }
            /// Si la personne est non employé.
            else
            {
                return $"+-----+-----+-----+-----+\n" +
                    $"Information de la personne.\n" +
                    $"Prenom/Nom = {Prenom} {Nom}";
            }
        }

    }
}
