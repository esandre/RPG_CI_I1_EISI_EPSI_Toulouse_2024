namespace RPG_CI;

public class Personnage
{
    public uint PointsDeVie { get; private set; } = 100;
    public bool EstMort { get; } = true;

    public void Tuer()
    {
        PointsDeVie = 0;
    }
}