
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
                $"Solde         = {Solde}$\n" +
                $"Date depot    : \n" +
                $"Date retirer  :"
                );
        }

        public void Deposer(float somme)
        {
            
        }

        public void Retirer(float somme)
        {
            /// Ajoute "Solde" ddu compte dans l'argent de l'utilisateur'.
           
        }

        
    }
}
