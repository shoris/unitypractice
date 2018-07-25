using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCalculations  {

	private StatCalculations statCalcScript = new StatCalculations();

	private BaseAbility playerUsedAbility;

	private float abilityPower;
	private float statusEffectDamage;
	private float totalAbilityPowerDamage;
	private float totalUsedAbilityDamage;
	private float totalPlayerDamage;
	private float totalCritStrikeDamage;

	//private float damageVarianceModifier = 0.025f; //2.5%

	public void CalculateTotalPlayerDamage(BaseAbility usedAbility){
		playerUsedAbility = usedAbility;
		totalUsedAbilityDamage = (int)CalculateAbilityDamage(usedAbility);
		totalCritStrikeDamage = CalculateCriticalStrikeDamage ();
		statusEffectDamage = CalculateStatusEffectDamage ();
		totalPlayerDamage = totalUsedAbilityDamage + totalCritStrikeDamage + statusEffectDamage;
		//totalPlayerDamage += (int)(Random.Range(-(totalPlayerDamage*damageVarianceModifier), totalPlayerDamage*damageVarianceModifier));
		Debug.Log (totalPlayerDamage);
		GameInformation.EnemyHealth = GameInformation.EnemyHealth - totalPlayerDamage;
		TurnBasedCombatStateMachine.playerDidCompleteTurn = true;
		//TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;

	}

	public void CalculateTotalEnemyDamage(BaseAbility usedAbility){
		playerUsedAbility = usedAbility;
		totalUsedAbilityDamage = (int)CalculateAbilityDamage(usedAbility);
		totalCritStrikeDamage = CalculateCriticalStrikeDamage ();
		statusEffectDamage = CalculateStatusEffectDamage ();
		totalPlayerDamage = totalUsedAbilityDamage + totalCritStrikeDamage + statusEffectDamage;
		//totalPlayerDamage += (int)(Random.Range(-(totalPlayerDamage*damageVarianceModifier), totalPlayerDamage*damageVarianceModifier));
		Debug.Log (totalPlayerDamage);

		GameInformation.PlayerHealth = GameInformation.PlayerHealth - totalPlayerDamage;
		TurnBasedCombatStateMachine.enemyDidCompleteTurn = true;
		//TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;

	}

	private float CalculateAbilityDamage(BaseAbility usedAbility){
		abilityPower = usedAbility.AbilityPower; 	//retrieves power of move
		totalAbilityPowerDamage = abilityPower * statCalcScript.FindPlayerMainStatAndCalculateMainStatModifier ();		//find main stat and use as modifier for damage
		return totalAbilityPowerDamage;
	}

	private float CalculateStatusEffectDamage(){
		return statusEffectDamage = TurnBasedCombatStateMachine.statusEffectBaseDamage * GameInformation.PlayerLevel;

	}

	private float CalculateCriticalStrikeDamage(){
		if (DecideIfAbilityCriticallyHit ()) {
			totalCritStrikeDamage = 0;
			return totalCritStrikeDamage = (int)(playerUsedAbility.AbilityCritModifier * totalAbilityPowerDamage);
		} else {
			return totalCritStrikeDamage = 0;
		}
	}

	private bool DecideIfAbilityCriticallyHit(){
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= playerUsedAbility.AbilityCritChance) {
			Debug.Log ("CRIT!");
			return true;		//did critically hit
		} else {
			return false;		//did not critically hit
		}
	}

}
