using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleGUI : MonoBehaviour {

	//private BattleStateStart battleStateStartScript = new BattleStateStart();

	private Text playerName;
	private Text playerHealth;
	private Image playerHealthImage;

	private Text enemyName;
	private Text enemyHealth;
	private Image enemyHealthImage;

	private Text abilityOneName;

	//private string playerName;
	private int playerLevel;
	//private int playerHealth;
	private int playerEnergy;


	// Use this for initialization
	void Start () {
		//FindChild is deprecated
		playerName = transform.Find ("PlayerInfoContainer").Find ("PlayerPortrait").Find("PlayerName").GetComponent<Text>();
		playerName.text = GameInformation.PlayerName;
		playerHealth = transform.Find ("PlayerInfoContainer").Find ("PlayerHealthBar").Find("PlayerHealthValue").GetComponent<Text>();
		playerHealthImage = transform.Find ("PlayerInfoContainer").Find ("PlayerHealthBar").GetComponent<Image>();

		enemyName = transform.Find ("EnemyInfoContainer").Find ("EnemyPortrait").Find ("EnemyName").GetComponent<Text> ();
		//enemyName.text = battleStateStartScript.newEnemy.PlayerName;
		enemyName.text = "Evil Enemy";
		enemyHealth = transform.Find ("EnemyInfoContainer").Find ("EnemyHealthBar").Find ("EnemyHealthValue").GetComponent<Text> ();
		enemyHealthImage = transform.Find ("EnemyInfoContainer").Find ("EnemyHealthBar").GetComponent<Image> ();



		//playerName = GameInformation.PlayerName;
		playerLevel = GameInformation.PlayerLevel;
		//Debug.Log (GameInformation.playerMoveTwo.AbilityStatusEffect.StatusEffectName);
	}
	
	// Update is called once per frame
	void Update () {
		playerName.text = GameInformation.PlayerName;
		if (GameInformation.PlayerHealth <= 0) {
			playerHealth.text = "0";
			playerHealthImage.fillAmount = 0;
		} else if (GameInformation.PlayerHealth > 0) {
			playerHealth.text = GameInformation.PlayerHealth.ToString ();
			playerHealthImage.fillAmount = GameInformation.PlayerHealth / 1200;
		}
	

		enemyName.text = "Evil Enemy";
		if (GameInformation.EnemyHealth <= 0) {
			enemyHealth.text = "0";
			enemyHealthImage.fillAmount = 0;
		} else if (GameInformation.EnemyHealth > 0) {
			enemyHealth.text = GameInformation.EnemyHealth.ToString ();
			enemyHealthImage.fillAmount = GameInformation.EnemyHealth / 1000;
		}
	

		//enemyName.text = battleStateStartScript.newEnemy.PlayerName;
		//enemyHealth.text = 

	}

	void OnGUI(){
		if (TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE) {
			DisplayPlayersChoice ();
		}

	}

	public void AbilityOne(){
		TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveTwo;
		TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ADDSTATUSEFFECTS;
	}

	private void DisplayPlayersChoice(){
		//use this for loop to display several abilities (if your game has lots of moves)
		//this creates an action type bar (as many buttons as there are abilities)
		//for (int i = 0; i < GameInformation.playersAbilities.Count; i++){
		//if (GUI.Button (new Rect (0, 0, 0, 0), GameInformation.playersAbilities [i].AbilityName)) {
		//}
		//}

		//show enemy health and other info
		//show player info
		//buttons for players moves
		if(GUI.Button(new Rect(Screen.width - 250,Screen.height - 50,100,30), GameInformation.playerMoveOne.AbilityName)){
			//calculate player's damage to enemy
			TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveOne;
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ADDSTATUSEFFECTS;
		}
		if (GUI.Button (new Rect (Screen.width - 150, Screen.height - 50, 100, 30), GameInformation.playerMoveTwo.AbilityName)) {
			//calculate player's damage to enemy
			TurnBasedCombatStateMachine.playerUsedAbility = GameInformation.playerMoveTwo;
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ADDSTATUSEFFECTS;

		}

	}

	public void FindAbilityOneInfo(){
		abilityOneName = transform.Find ("MeleeAbilitiesContainer").Find ("AbilityOne").Find("Text").GetComponent<Text>();
		abilityOneName.text = GameInformation.playerMoveTwo.AbilityName;

	}
}
