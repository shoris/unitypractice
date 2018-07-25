using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private string playerName = "Enter Name: ";

	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		playerName = GUILayout.TextField (playerName,10);
		isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
		if(GUILayout.Button("Create")){
			if(isMageClass){
				newPlayer.PlayerClass = new BaseMageClass();
			} else if (isWarriorClass){
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			CreateNewPlayer ();


			StoreNewPlayerInfo ();
			SaveInformation.SaveAllInformation ();
			SceneManager.LoadScene ("main");


		}

		if (GUILayout.Button ("Load")) {
			SceneManager.LoadScene ("main");

		
		}
	}
	//store all the saved info
	private void StoreNewPlayerInfo(){
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.PlayerClass = newPlayer.PlayerClass;
		GameInformation.Stamina = newPlayer.Stamina;
		GameInformation.Endurance = newPlayer.Endurance;
		GameInformation.Intellect = newPlayer.Intellect;
		GameInformation.Strength = newPlayer.Strength;
		GameInformation.Overpower = newPlayer.Overpower;
		GameInformation.Luck = newPlayer.Luck;
		GameInformation.Mastery = newPlayer.Mastery;
		GameInformation.Charisma = newPlayer.Charisma;
		GameInformation.PlayerHealth = 1200; //test

		GameInformation.Gold = newPlayer.Gold;
	}

	private void CreateNewPlayer(){
		newPlayer.PlayerLevel = 1;
		newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
		newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
		newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Overpower = newPlayer.PlayerClass.Overpower;
		newPlayer.Luck = newPlayer.PlayerClass.Luck;
		newPlayer.Mastery = newPlayer.PlayerClass.Mastery;
		newPlayer.Charisma = newPlayer.PlayerClass.Charisma;

		newPlayer.Gold = 10;
		newPlayer.PlayerName = playerName;

		Debug.Log("Player Name: " + newPlayer.PlayerName);
		Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
		Debug.Log("Player Level: " + newPlayer.PlayerLevel);
		Debug.Log("Player Stamina: " + newPlayer.Stamina);
		Debug.Log("Player Endurance: " + newPlayer.Endurance);
		Debug.Log("Player Intellect: " + newPlayer.Intellect);
		Debug.Log("Player Strength: " + newPlayer.Strength);

		Debug.Log("Player Gold: " + newPlayer.Gold);
	}
}
