﻿[System.Serializable]
public class AttackAbility : BaseAbility {
	
	public AttackAbility(){
		AbilityName = "Normal Attack";
		AbilityDescription = "A normal attack";
		AbilityID = 1;
		AbilityPower = 10;
		AbilityCost = 5;
		AbilityCritChance = 5; //% chance
		AbilityStatusEffects.Add (new BurnStatusEffect ());
		AbilityStatusEffect = new BurnStatusEffect ();
	}
}
