using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGnomeRace : BaseCharacterRace {

	public BaseGnomeRace(){
		new BaseCharacterRace ();
		RaceName = "Gnome";
		RaceDescription = "Is a gnome.";
		HasIntellectBonus = true;
		HasEnduranceBonus = true;
		HasLuckBonus = true;

	}
}
