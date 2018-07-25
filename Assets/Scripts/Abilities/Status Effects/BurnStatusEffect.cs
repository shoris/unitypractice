
[System.Serializable]
public class BurnStatusEffect : BaseStatusEffect {
	
	public BurnStatusEffect(){
		StatusEffectName = "Burn";
		StatusEffectDescription = "Burns enemy for a number of turns.";
		StatusEffectID = 1;
		StatusEffectPower = 10;
		StatusEffectApplyPercentage = 75; //this effect has a 75% chance of being applied.
		StatusEffectStayAppliedPercentage = 75;
		StatusEffectMinTurnApplied = 2;
		StatusEffectMaxTurnApplied = 6;
	
	}

}
