using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRogueClass : BaseCharacterClass {

	public BaseRogueClass(){
		CharacterClassName = "Rogue";
		CharacterClassDescription = "A silent, deadly assassin.";
		MainStat = MainStatBonuses.INTELLECT;
		SecondMainStat = SecondStatBonuses.STRENGTH;
		BonusStat = BonusStatBonuses.MASTERY;
	}
}
