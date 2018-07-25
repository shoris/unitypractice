using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateAddStatusEffects {
	
	public void CheckAbilityForStatusEffects(BaseAbility usedAbility){
			switch (usedAbility.AbilityStatusEffect.StatusEffectName) {
			case("Burn"):
			if(TryToApplyStatusEffect(usedAbility)) {
				Debug.Log ("RETURNED TRUE, APPLIED EFFECT");
				TurnBasedCombatStateMachine.statusEffectBaseDamage = usedAbility.AbilityStatusEffect.StatusEffectPower;
				Debug.Log ("Status effect base damage is " + TurnBasedCombatStateMachine.statusEffectBaseDamage);

			} else {
				TurnBasedCombatStateMachine.statusEffectBaseDamage = 0;
			    }
				
				TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCDAMAGE;
				break;
			default:
				Debug.LogError ("ERROR IN STATUS EFFECT");
				break;
			}

	}

	private bool TryToApplyStatusEffect(BaseAbility usedAbility){
		//look at percent chance of status effect applying
		//using percent chance apply effect
		int randomTemp = Random.Range(1,101);	//random number between 1-100 (percent roll)
		Debug.Log("Random number is " + randomTemp);
		if (randomTemp <= usedAbility.AbilityStatusEffect.StatusEffectApplyPercentage) {	//apply status effect
			return true;
		} 
		return false;
	}



}
