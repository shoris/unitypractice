using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacterClass {

	public BaseWarriorClass(){
		CharacterClassName = "Warrior";
		CharacterClassDescription = "A strong and powerful hero";
		MainStat = MainStatBonuses.INTELLECT;
		SecondMainStat = SecondStatBonuses.STRENGTH;
		BonusStat = BonusStatBonuses.MASTERY;
		playersAbilities.Add (new AttackAbility ());
		playersAbilities.Add (new SwordSlash ());

	
	
	}

}
