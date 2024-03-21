namespace RPG_CI;

public class Personnage
{
    public uint PointsDeVie { get; private set; } = 100;
    public bool EstMort { get; private set; }

    public void Tuer()
    {
        PointsDeVie = 0;
        EstMort = true;
    }

    public void RecevoirDégâts()
    {
        PointsDeVie--;
    }
}