namespace RPG_CI.Test
{
    public class PersonnageTest
    {
        [Fact]
        public void HpInitiaux()
        {
            var personnage = new Personnage();

            Assert.Equal(100U, personnage.PointsDeVie);
        }

        [Fact]
        public void InitialementVivant()
        {
            var personnage = new Personnage();

            Assert.False(personnage.EstMort);
        }

        [Fact]
        public void Mort()
        {
            var personnage = new Personnage();
            personnage.Tuer();

            Assert.Equal(0U, personnage.PointsDeVie);
            Assert.True(personnage.EstMort);
        }

        [Fact]
        public void Dégâts()
        {
            var personnage = new Personnage();
            personnage.RecevoirDégâts();

            Assert.Equal(99U, personnage.PointsDeVie);
        }
    }
}