
namespace LaVieDeBob.Classes
{
    internal class Compte
    {
        // Déclarations des propriétés.
        public Personne Utilisateur { get; set; }
        public float Solde { get; set; }
        
        // Déclaration de constructeur.
        public Compte(Personne utilisateur, float solde_donne)
        {
            Utilisateur = utilisateur;
            Solde = solde_donne;
        }

        // Déclarations des méthodes.
        public void Consulter()
        {
            /// Affice les informations du compte.
            Console.WriteLine(
                $"+=====+=====+=====+=====+\n" +
                $"Utilisateur   = {Utilisateur.Nom} {Utilisateur.Prenom}\n" +
                $"Solde         = {Solde}$\n" +
                $"Date depot    : \n" +
                $"Date retirer  :"
                );
        }

        public void Deposer(float somme)
        {
            /// Ajoute "Argent" de l'utilisateur dans le solde du compte.
            if (somme > Utilisateur.Argent || somme < 0)
            {
                Console.WriteLine("La somme du depot est trop haute ou est" +
                    "négatif.");
            }
            else
            {
                Utilisateur.Argent -= somme;
                Solde += somme;
            }
        }

        public void Retirer(float somme)
        {
            /// Ajoute "Solde" ddu compte dans l'argent de l'utilisateur'.
            if (somme > Solde || somme < 0)
            {
                Console.WriteLine("La somme du solde est trop haute ou est" +
                    "négatif.");
            }
            else
            {
                Utilisateur.Argent += somme;
                Solde -= somme;
            }
        }

        
    }
}
