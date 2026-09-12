using LaVieDeBob.Classes;

namespace LaVieDeBobTests
{
    // Note de référence :
    // Clique droit sur "LaVieDeBobTests", puis ajouter une "référence de projet".
    // Cochez le bon projet et comfirmer.
    public class PersonneTest
    {
        // Déclaration de plusieur valaurs à tester.
        // Remplacer [Theory] par [Fact] s'il y'a seulement un test.
        [InlineData(10)]
        [InlineData(20)]
        [Theory]
        public void TravaillerTest(int heuresTravailles) 
        {
            // Arrange : Je prépare mes objets, données de tests, etc.
            Personne personne = new ("Vann", "Sovannthanant", "programmeur", 100.00f);

            // Act : Appeler la méthode à tester.
            personne.Travailler(heuresTravailles);

            // Assert : Faire les vérifications.
            Assert.Equal(personne.Emploi.Salaire * heuresTravailles, personne.Compte.Solde);
        }

    }
}
