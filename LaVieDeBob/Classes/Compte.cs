
namespace LaVieDeBob.Classes
{
    internal class Compte
    {
        // Déclarations des propriétés.
        public int solde { get; set; }

        // Déclaration de constructeur.
        public Compte(float solde_donne)
        {
            float solde = solde_donne;
        }

        // Déclarations des méthodes.
        public void Consulter()
        {
            throw new System.NotImplementedException();
        }

        public void Deposer()
        {
            throw new System.NotImplementedException();
        }

        public void Retirer()
        {
            throw new System.NotImplementedException();
        }
    }
}
