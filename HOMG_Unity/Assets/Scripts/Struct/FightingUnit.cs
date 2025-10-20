
public class FightingUnit : Unit
{ // 修改继承
    public bool DEFingRetreat;
    public bool ATKingRetreat;

    public FightingUnit(Unit unit)
    {
		this = unit;
        DEFingRetreat = false;
        ATKingRetreat = false;
    }
}
