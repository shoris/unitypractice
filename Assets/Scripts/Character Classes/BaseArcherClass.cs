using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArcherClass : BaseCharacterClass {

	public BaseArcherClass(){
		CharacterClassName = "Archer";
		CharacterClassDescription = "Sharpshooter.";
		MainStat = MainStatBonuses.INTELLECT;
		SecondMainStat = SecondStatBonuses.STRENGTH;
		BonusStat = BonusStatBonuses.MASTERY;
		//CharacterClass = CharacterClasses.ARCHER;
	}

}
