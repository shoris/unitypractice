using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHumanRace : BaseCharacterRace {

	public BaseHumanRace(){
		new BaseCharacterRace ();
		RaceName = "Human";
		RaceDescription = "Is a human.";
		HasStaminaBonus = true;
		HasStrengthBonus = true;
		HasCharismaBonus = true;

	}
}
