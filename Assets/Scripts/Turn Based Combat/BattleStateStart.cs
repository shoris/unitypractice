using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart {

	public BasePlayer newEnemy = new BasePlayer();
	private StatCalculations statCalculationsScript = new StatCalculations();
	private BaseCharacterClass[] classTypes = new BaseCharacterClass[]{new BaseMageClass(), new BaseWarriorClass(), new BaseArcherClass(), new BaseRogueClass()};
	//create random enemies
	//if you don't want random enemies, then make a database like the item one for named enemies-- blank enemy
	private string[] enemyNames = new string[]{"Deadly Enemy", "Fierce Enemy", "Subtle Enemy", "Powerful Enemy"};
	//private float staminaModifier = 0.15f; //15%
	//private float enduranceModifier = 0.15f;
	//private float intellectModifier = 0.1f; //10%
	//private float strengthModifier = 0.1f;

	private int playerStamina;
	private int playerEndurance;
	private int playerHealth;
	private int playerEnergy;

	private int enemyHealth;
	private int enemyEnergy;




	public void PrepareBattle(){
		//create enemy
		CreateNewEnemy();
		Debug.Log ("New enemy created!");
		Debug.Log (newEnemy.PlayerName);
		Debug.Log (newEnemy.Endurance);
		Debug.Log (newEnemy.Stamina);
		Debug.Log (newEnemy.PlayerLevel);
		Debug.Log (newEnemy.PlayerClass);

		DetermineEnemyVitals ();
		//find our vitals (stat calculations)
		DeterminePlayerVitals ();

		//choose who goes first based on luck
		ChooseWhoGoesFirst();
		//does the scene have status effect? if so, apply effect throughout fight.s
	}

	private void CreateNewEnemy(){
		newEnemy.PlayerName = enemyNames [Random.Range (0, enemyNames.Length)];	
		newEnemy.PlayerLevel = 1;
		//randomly chooses class out of array above
		newEnemy.PlayerClass = classTypes [Random.Range (0, classTypes.Length)]; 

		newEnemy.Stamina = 12;
		newEnemy.Endurance = 9;
		newEnemy.Intellect = 5;
		newEnemy.Strength = 7;
		newEnemy.Overpower = 8;
		newEnemy.Mastery = 9;
		newEnemy.Luck = -1;
		newEnemy.Charisma = 9;

		enemyHealth = 1000;
		enemyEnergy = 500;


	}

	private void ChooseWhoGoesFirst(){
		if (GameInformation.Luck >= newEnemy.Luck) {
			//whoever has more luck goes first
			//player goes first
			TurnBasedCombatStateMachine.firstTurn = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE;
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE;

		}
		if (GameInformation.Luck < newEnemy.Luck) {
			//enemy goes first
			TurnBasedCombatStateMachine.firstTurn = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;

		}
		//if (GameInformation.Luck == newEnemy.Luck) {
			////if equal, player goes first for now
		//}
	}

	private void DeterminePlayerVitals(){
		GameInformation.PlayerName = "Test Name";
		GameInformation.PlayerClass = new BaseMageClass ();
		GameInformation.Intellect = GameInformation.PlayerClass.Intellect;

		GameInformation.Endurance = GameInformation.PlayerClass.Endurance;
		GameInformation.Stamina = GameInformation.PlayerClass.Stamina;
		playerStamina = statCalculationsScript.CalculateStat (GameInformation.Stamina, StatCalculations.StatType.STAMINA, GameInformation.PlayerLevel, false);
		playerEndurance = statCalculationsScript.CalculateStat (GameInformation.Endurance, StatCalculations.StatType.ENDURANCE, GameInformation.PlayerLevel, false);
		playerHealth = statCalculationsScript.CalculateHealth (playerStamina);
		playerEnergy = statCalculationsScript.CalculateEnergy (playerEndurance);
		GameInformation.PlayerHealth = playerHealth;
		Debug.Log ("Player Health= " + GameInformation.PlayerHealth);
		GameInformation.PlayerEnergy = playerEnergy;
		GameInformation.PlayerLevel = 1;
	}

	private void DetermineEnemyVitals(){
		GameInformation.EnemyHealth = enemyHealth;
		GameInformation.EnemyEnergy = enemyEnergy;
		GameInformation.EnemyStamina = newEnemy.Stamina;
		GameInformation.EnemyEndurance = newEnemy.Endurance;
		GameInformation.EnemyIntellect = newEnemy.Intellect;
		GameInformation.EnemyLevel = newEnemy.PlayerLevel;
	}


}
