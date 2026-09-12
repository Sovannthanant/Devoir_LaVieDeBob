using LaVieDeBob.Classes;

namespace LaVieDeBobTests
{
    public class CompteTest
    {
        [InlineData(20.00)]
        [InlineData(40.00)]
        [InlineData(60.00)]
        [InlineData(80.00)]
        [Theory]
        public void DeposerTest(float montant)
        {
            // Arrange : Je prépare mes objets, données de tests, etc.
            Compte compte = new(00.00f);
            // Act: Appeler la méthode à tester.
            compte.Deposer(montant);
            // Assert: Faire les vérifications.
            Assert.Equal(compte.Solde += montant, compte.Solde);
        }

        [InlineData(20.00)]
        [InlineData(40.00)]
        [InlineData(60.00)]
        [InlineData(80.00)]
        [Theory]
        public void RetirerTest(float montant)
        {
            // Arrange : Je prépare mes objets, données de tests, etc.
            Compte compte = new(100.00f);
            // Act: Appeler la méthode à tester.
            compte.Retirer(montant);
            // Assert: Faire les vérifications.
            Assert.Equal(compte.Solde -= montant, compte.Solde);
        }
    }
}
