
namespace LaVieDeBob.Classes
{
    public class Compte
    {
        // Déclarations des propriétés.
        public float Solde { get; private set; }
        
        // Déclaration de constructeur.
        public Compte(float soldeInitial = 0)
        {
            Solde = soldeInitial;
        }

        // Déclarations des méthodes.
        public void Consulter()
        {
            /// Affice les informations du compte.
            Console.WriteLine(
                $"+=====+=====+=====+=====+\n" +
                $"Information du compte" +
                $"Solde         = {Solde}$\n");
        }

        public void Deposer(float montant)
        {
            /// Fonction qui depose "montant" dans le solde de la classe.
            /// Param "montants": montant d'argent à déposé.
            /// Exception : ArgumentOutOfRangeException.
            if (montant > 0)
            {
                Solde += montant;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Le montant à " +
                    "déposer doit être positif.");
            }    
        }

        public void Retirer(float montant)
        {
            /// Fonction qui depose "montant" dans le solde de la classe.
            /// Param "montants": montant d'argent à déposé.
            /// Exception : ArgumentOutOfRangeException.
            if (montant > 0)
            {
                if (montant <= Solde)
                {
                    Solde -= montant;
                }
                else
                {
                    throw new InvalidOperationException("Solde insuffisant");
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Le montant à retirer doit" +
                "être positif.");
            }
        }

    }
}
