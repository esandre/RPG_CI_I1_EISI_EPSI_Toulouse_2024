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
    }
}