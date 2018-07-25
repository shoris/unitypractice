using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDwarfRace : BaseCharacterRace {

	public BaseDwarfRace(){
		new BaseCharacterRace ();
		RaceName = "Dwarf";
		RaceDescription = "Is a dwarf.";
		HasIntellectBonus = true;
		HasStrengthBonus = true;
		HasMasteryBonus = true;

	}
}
