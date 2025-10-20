
using System.Collections.Generic;

public class Division
{
    private Player _owner;
    private List<FightingUnit> _units;

    public int ATK;
    public int DEF;

    public Cost ATKCost;

    public Division(Player _owner, List<Unit> _units)
    {
        this._owner = _owner;
        this._units = new List<FightingUnit>();
        foreach (Unit unit in _units)
        {
            this._units.Add(new FightingUnit(unit));
        }
        CalcUnits();
    }

    private void CalcUnits()
    {
        int atk = 0;
        int def = 0;
        Cost _ATKCost = new Cost(0, 0);

        foreach (FightingUnit fightUnit in _units) // 计算总攻击力、防御力和消耗
        {
            _ATKCost += fightUnit.getUnitData().GetATKCost();
            atk += fightUnit.getUnitData().GetATK();
            def += fightUnit.getUnitData().GetDEF();
        }

        ATK = atk;
        DEF = def;

        ATKCost = _ATKCost;
    }

    public List<FightingUnit> GetFightingUnits() => _units;

    public Player GetOwner() => _owner;

}
