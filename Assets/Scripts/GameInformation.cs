using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameInformation : MonoBehaviour {

	public static GameInformation information;

	//private static bool gameInfoExists;

	void Awake(){
		if (information == null) {
			DontDestroyOnLoad (transform.gameObject);
			information = this;
		} else if (information != this){
			Destroy (gameObject);
		}
	}

	//TEMPORARY THING FOR BATTLE TESTING FOR ONE BATTLE
	public static bool BattleWon { get; set; }

	//save player location for things like switching scenes (maybe??) but definitely going into/out of battle.
	public static Vector3 PlayerLocation{ get; set; } 
	public static string PreviousScene{ get; set; }

	public static List<BaseAbility> playersAbilities;

	public static bool IsFemale{ get; set; }
	public static string PlayerBio{ get; set; }
	public static BaseEquipment EquipmentOne{ get; set; }

	public static string PlayerName{ get; set; }
	public static int PlayerLevel{ get; set; }
	public static BaseCharacterClass PlayerClass{ get; set; }
	public static int Stamina { get; set; }
	public static int Endurance { get; set; }
	public static int Intellect { get; set; }
	public static int Strength { get; set; }

	public static int Overpower { get; set; }
	public static int Luck { get; set; }
	public static int Mastery { get; set; }
	public static int Charisma { get; set; }


	public static int Gold { get; set; } 
	public static int CurrentXP{ get; set; }
	public static int RequiredXP{ get; set; }


	public static float PlayerHealth{ get; set; }
	public static int PlayerEnergy{ get; set; }

	public static BaseAbility playerMoveOne = new AttackAbility();
	public static BaseAbility playerMoveTwo = new SwordSlash();


	//enemy stuff
	public static string EnemyName{get;set;}
	public static int EnemyLevel{get;set;}
	public static int EnemyStamina{ get; set;}
	public static int EnemyEndurance { get; set; }
	public static int EnemyIntellect { get; set; }
	public static int EnemyStrength { get; set; }

	public static int EnemyOverpower { get; set; }
	public static int EnemyLuck { get; set; }
	public static int EnemyMastery { get; set; }
	public static int EnemyCharisma { get; set; }

	public static float EnemyHealth{ get; set; }
	public static int EnemyEnergy{ get; set; }
		

	public void Save(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfo.dat");
		PlayerData data = new PlayerData ();
		data.PlayerHealth = PlayerHealth;
		data.PlayerLevel = PlayerLevel;

		bf.Serialize (file, data);
		file.Close();
	}

	public void Load(){
		if (File.Exists (Application.persistentDataPath + "/playerInfo.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file); //creating an object-- we don't know what it is, hence the cast.
			file.Close();

			PlayerHealth = data.PlayerHealth;
			PlayerLevel = data.PlayerLevel;

		}
	}
		
}

[Serializable]	//need this to allow you to save to file.
class PlayerData
{
	public  List<BaseAbility> playersAbilities;

	public  bool IsFemale{ get; set; }
	public  string PlayerBio{ get; set; }
	public  BaseEquipment EquipmentOne{ get; set; }

	public  string PlayerName{ get; set; }
	public  int PlayerLevel{ get; set; }
	public  BaseCharacterClass PlayerClass{ get; set; }
	public  int Stamina { get; set; }
	public  int Endurance { get; set; }
	public  int Intellect { get; set; }
	public  int Strength { get; set; }

	public  int Overpower { get; set; }
	public  int Luck { get; set; }
	public  int Mastery { get; set; }
	public  int Charisma { get; set; }


	public  int Gold { get; set; } 
	public  int CurrentXP{ get; set; }
	public  int RequiredXP{ get; set; }


	public  float PlayerHealth{ get; set; }
	public  int PlayerEnergy{ get; set; }

	public  BaseAbility playerMoveOne = new AttackAbility();
	public  BaseAbility playerMoveTwo = new SwordSlash();


	//enemy stuff
	public  string  EnemyName{get;set;}
	public  int EnemyLevel{get;set;}
	public  int EnemyStamina{ get; set;}
	public  int EnemyEndurance { get; set; }
	public  int EnemyIntellect { get; set; }
	public  int EnemyStrength { get; set; }

	public  int EnemyOverpower { get; set; }
	public  int EnemyLuck { get; set; }
	public  int EnemyMastery { get; set; }
	public  int EnemyCharisma { get; set; }

	public  float EnemyHealth{ get; set; }
	public  int EnemyEnergy{ get; set; }
}
