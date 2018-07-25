using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseElfRace : BaseCharacterRace {

	public BaseElfRace(){
		new BaseCharacterRace ();
		RaceName = "Elf";
		RaceDescription = "Is an elf.";
		HasStaminaBonus = true;
		HasEnduranceBonus = true;
		HasOverpowerBonus = true;

	}
}
