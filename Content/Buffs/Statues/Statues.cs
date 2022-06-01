using UnityEngine;
 
[CreateAssetMenu(fileName = "HealthStatusData", menuName = "StatusObjects/Health", order = 1)]
public class CharacterStatus : ScriptableObject
{
    public string charName = "name";
    public int basemaxhp  = 7;
	public int basemaxmp  = 200;
	public int basemaxshield  = 10;
    public int baseCritChance = 0.1;
	public int baseAttackSpeed = 1.0;
	public int baseBulletSpeed = 1.0;
	public int baseMovementSpeed = 1.0;
	public int baseElementalResistence = 0.0;
	public int baseShieldRegenCooldown = 5.0;
	public int baseShieldRegen = 1.0;
}

public class statsChange(int statType, int statModifier)
{
	switch (statType)
	{
	   case basemaxhp:
		  basemaxhp  = basemaxhp + statModifier;
	   break;
	   case basemaxmp:
		  basemaxmp  = basemaxmp + statModifier;
	   break;
	   case basemaxshield:
		  basemaxshield  = basemaxshield + statModifier;
	   break;
	   case baseCritChance:
		  baseCritChance  = baseCritChance + statModifier;
	   break;
	   case baseAttackSpeed:
		  baseAttackSpeed  = baseAttackSpeed + statModifier;
	   break;
	   case baseBulletSpeed:
		  baseBulletSpeed  = baseBulletSpeed + statModifier;
	   break;
	   case baseMovementSpeed:
		  baseMovementSpeed  = baseMovementSpeed + statModifier;
	   break;
	   case baseElementalResistence:
		  baseElementalResistence  = baseElementalResistence + statModifier;
	   break;
	   case baseShieldRegenCooldown:
		  baseShieldRegenCooldown  = baseShieldRegenCooldown + statModifier;
	   break;
	   case baseShieldRegen:
		  baseShieldRegen  = baseShieldRegen + statModifier;
	   break;
	   default:
		  Statement
	   break;
	}
}

/*
1. Passive Crit chance increase + 20%
2. Max health increase + 1
3. Passive Attack speed increase + 10%
4. Passive Bullet speed increase + 10%
5. Passive dmg increase + 1
6. Max shield increase + 1
7. Passive shield regen - 10% time
8. Max mana increase + 20
9. Passive player speed increase + 10%
10. Passive elemental resistance - 20% dmg taken
*/