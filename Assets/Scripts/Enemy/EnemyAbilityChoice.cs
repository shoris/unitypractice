using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAbilityChoice {

	private float totalPlayerHealth;
	private float playerHealthPercentage;
	private BaseAbility chosenAbility;


	public BaseAbility ChooseEnemyAbility(){
		totalPlayerHealth = GameInformation.PlayerHealth;
		playerHealthPercentage = (totalPlayerHealth / 100) * 100;

		if (playerHealthPercentage >= 75) {
			ChooseAbilityAtSeventyFivePercent();
		} else if (playerHealthPercentage < 75 && playerHealthPercentage >= 25) {
			return chosenAbility = new SwordSlash();
		} else if (playerHealthPercentage < 25) {
			return chosenAbility = new SwordSlash();
		}
		return chosenAbility = new AttackAbility();
	}

	private BaseAbility ChooseAbilityAtSeventyFivePercent(){
		return chosenAbility = new SwordSlash();

	}

}
