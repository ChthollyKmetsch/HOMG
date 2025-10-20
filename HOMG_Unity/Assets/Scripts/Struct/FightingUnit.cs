
public class FightingUnit : Unit
{
    public bool DEFingRetreat;
    public bool ATKingRetreat;

    public FightingUnit(Unit unit)
    {
		this = unit;
        DEFingRetreat = false;
        ATKingRetreat = false;
    }
}
