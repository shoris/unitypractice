using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateEnemyChoice  {

	private EnemyAbilityChoice enemyAbilityChoiceScript = new EnemyAbilityChoice();

	public void EnemyCompleteTurn(){
		//choose ability 
		TurnBasedCombatStateMachine.enemyUsedAbility = enemyAbilityChoiceScript.ChooseEnemyAbility();
		Debug.Log ("Enemy choice " + TurnBasedCombatStateMachine.enemyUsedAbility.AbilityName);
		//calculate damage
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCDAMAGE;
		//end turn
	}


}
