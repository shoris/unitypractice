using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	private bool hasAddedXP = false;
	private BattleStateStart battleStateStartScript = new BattleStateStart();
	private BattleCalculations battleCalcScript = new BattleCalculations();
	private BattleStateAddStatusEffects battleStateAddStatusEffectsScript = new BattleStateAddStatusEffects();
	private BattleStateEnemyChoice battleStateEnemyChoiceScript = new BattleStateEnemyChoice ();
	public static BaseAbility playerUsedAbility;
	public static BaseAbility enemyUsedAbility;
	public static int statusEffectBaseDamage;
	public static int totalTurnCount;
	public static bool playerDidCompleteTurn;
	public static bool enemyDidCompleteTurn;

	// win/loss condition variables
	public static bool playerWon;
	public static bool playerLost;

	public static BattleStates currentUser;	//enemy choice or player choice
	public static BattleStates firstTurn; //keep track of who went first so that you can loop?

	//private bool didPlayerWin = false;

	public enum BattleStates{
		START,
		PLAYERCHOICE,
		CALCDAMAGE,
		ADDSTATUSEFFECTS,
		ENEMYCHOICE,
		ENDTURN,
		LOSE,
		WIN
	}
		
	public static BattleStates currentState;

	// Use this for initialization
	void Start () {
		hasAddedXP = false;
		totalTurnCount = 1;
		currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (currentState);
		switch (currentState) {
		case (BattleStates.START):
			//set up battle function??
			//create enemy
			battleStateStartScript.PrepareBattle();
			//choose who goes first based on luck
			break;
		case (BattleStates.PLAYERCHOICE):	//player chooses ability they wanna use
			currentUser = BattleStates.PLAYERCHOICE;
			break;
		case (BattleStates.ENEMYCHOICE): 
			//Coded AI goes here.
			currentUser = BattleStates.ENEMYCHOICE;
			battleStateEnemyChoiceScript.EnemyCompleteTurn();
			//enemyDidCompleteTurn = true;
			//CheckWhoGoesNext();
			break;
		case (BattleStates.CALCDAMAGE):		// we calc damage done by player, look for existing status effects and add that damage
			if (currentUser == BattleStates.PLAYERCHOICE) {
				battleCalcScript.CalculateTotalPlayerDamage (playerUsedAbility);

			
			}

			if (currentUser == BattleStates.ENEMYCHOICE) {
				battleCalcScript.CalculateTotalEnemyDamage (enemyUsedAbility);
			
			}
			//Debug.Log ("CALCULATING DAMAGE");
			CheckWhoGoesNext();
			break;
		case (BattleStates.ADDSTATUSEFFECTS):		// we try to add a status effect, if it exists.
			battleStateAddStatusEffectsScript.CheckAbilityForStatusEffects(playerUsedAbility);
			break;
		case (BattleStates.ENDTURN):
			totalTurnCount += 1;
			playerDidCompleteTurn = false;
			enemyDidCompleteTurn = false;
		
			Debug.Log (totalTurnCount);

			currentState = firstTurn; //switch back to whoever went first.
			break;
		case (BattleStates.LOSE):
			break;
		case (BattleStates.WIN):
			Debug.Log ("WON!!!!");
			if (!hasAddedXP) {
				IncreaseExperience.AddExperience ();
				hasAddedXP = true;
			
			}
			GameInformation.BattleWon = true;
			SceneManager.LoadScene (GameInformation.PreviousScene);
			SaveInformation.SaveAllInformation ();
			break;

		}
	}


//	//this is just a button and has nothing to do with gameplay.
//	void OnGUI(){
//		if(GUILayout.Button("NEXT STATE")){
//			if (currentState == BattleStates.START) {
//				currentState = BattleStates.PLAYERCHOICE;
//			} else if (currentState == BattleStates.PLAYERCHOICE) {
//				currentState = BattleStates.ENEMYCHOICE;
//			} else if (currentState == BattleStates.ENEMYCHOICE) {
//				currentState = BattleStates.LOSE;
//			} else if (currentState == BattleStates.LOSE) {
//				currentState = BattleStates.WIN;
//			} else if (currentState == BattleStates.WIN) {
//				currentState = BattleStates.START;
//
//			}
//		}
//
//	}

	private void CheckWhoGoesNext(){
		//check to see if player won
		DidPlayerWinOrLose ();

		//check first to see if WIN/LOSS condition met before seeing who goes next
		if (currentState != BattleStates.WIN && currentState != BattleStates.LOSE) {
			if (playerDidCompleteTurn && !enemyDidCompleteTurn) {
				//enemy's turn
				currentState = BattleStates.ENEMYCHOICE;
			}
			if (!playerDidCompleteTurn && enemyDidCompleteTurn) {
				//player's turn
				currentState = BattleStates.PLAYERCHOICE;
			}
			if (playerDidCompleteTurn && enemyDidCompleteTurn) {
				//endturn state
				currentState = BattleStates.ENDTURN;

			}
		}
	}

	private void DidPlayerWinOrLose(){
		Debug.Log ("Checking to see if player won....");
		if (GameInformation.EnemyHealth <= 0) {
			Debug.Log ("Player won!!");
			currentState = BattleStates.WIN;
			Debug.Log (currentState);
		} 
		if (GameInformation.PlayerHealth <= 0) {
			Debug.Log ("Player lost!!");
			currentState = BattleStates.LOSE;
			Debug.Log (currentState);
		}
	}

}
