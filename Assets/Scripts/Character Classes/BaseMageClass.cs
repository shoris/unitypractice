using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageClass : BaseCharacterClass{

	public BaseMageClass(){
		CharacterClassName = "Mage";
		CharacterClassDescription = "A wise wizard, can case spells.";
		MainStat = MainStatBonuses.INTELLECT;
		SecondMainStat = SecondStatBonuses.ENDURANCE;
		BonusStat = BonusStatBonuses.MASTERY;
	}

}
