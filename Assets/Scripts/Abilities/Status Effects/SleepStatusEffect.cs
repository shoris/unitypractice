[System.Serializable]		//serialize them and save them later in a different file.
public class SleepStatusEffect : BaseStatusEffect {

	public SleepStatusEffect(){
		StatusEffectName = "Sleep";
		StatusEffectDescription = "Puts enemy to sleep for a number of turn.";
		StatusEffectID = 2;
		StatusEffectPower = 0;
		StatusEffectApplyPercentage = 100; //this effect has a 75% chance of being applied.
		StatusEffectStayAppliedPercentage = 25;
		StatusEffectMinTurnApplied = 1;
		StatusEffectMaxTurnApplied = 3;

	}

}
