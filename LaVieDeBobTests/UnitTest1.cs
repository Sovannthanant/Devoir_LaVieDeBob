using LaVieDeBob.Classes;

namespace LaVieDeBobTests
{
    // Note de référence :
    // Clique droit sur "LaVieDeBobTests", puis ajouter une "référence de projet".
    // Cochez le bon projet et comfirmer.
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Ce test est réusssi.
            // Arrange : Je prépare mes objets, données de tests, etc.
            Personne personne = new ("Vann","Sovannthanant","programmeur",100.00f);

            // Act : Appeler la méthode à t4ester.
            personne.Travailler(5);

            // Assert : Faire les vérifications.
            Assert.Equal(500, personne.Compte.Solde);
        }

        [InlineData(10)]
        [InlineData(20)]
        [Theory]
        public void Test2(int heuresTravailles) 
        {
            // Arrange : Je prépare mes objets, données de tests, etc.
            Personne personne2 = new ("Vann", "Sovannthanant", "programmeur", 100.00f);

            // Act : Appeler la méthode à t4ester.
            personne2.Travailler(heuresTravailles);

            // Assert : Faire les vérifications.
            Assert.Equal(personne2.Emploi.Salaire * heuresTravailles, personne2.Compte.Solde);
        }

    }
}
