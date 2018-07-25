using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterRace {

	private string raceName = "Needs a name"; 
	private string raceDescription = "Needs a Description";


	public string RaceName {
		get{ return raceName; }
		set{ raceName = value; }
	}

	public string RaceDescription {
		get{ return raceDescription; }
		set{ raceDescription = value; }
	}
		
	public bool HasStrengthBonus { get; set; }
	public bool HasIntellectBonus { get; set; }
	public bool HasStaminaBonus { get; set; }
	public bool HasEnduranceBonus { get; set; }
	public bool HasOverpowerBonus { get; set; }
	public bool HasLuckBonus { get; set; }
	public bool HasMasteryBonus { get; set; }
	public bool HasCharismaBonus { get; set; }


}
