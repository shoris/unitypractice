using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseExperience {

	private static int xpToGive;
	private static LevelUp levelUpScript = new LevelUp();

	public static void AddExperience(){
		//temp number that equals required XP so that I can see the player level up.
		xpToGive =(GameInformation.PlayerLevel * 1000) + 250;
		Debug.Log ("You gained " + xpToGive + " experience points.");
		GameInformation.CurrentXP += xpToGive;
		Debug.Log ("Your current XP: " + GameInformation.CurrentXP);
		CheckToSeeIfPlayerLeveled ();
		Debug.Log (xpToGive);
	
	}

	public static void AddExperienceFromBattleLoss(){
		xpToGive = GameInformation.PlayerLevel * 10;
		GameInformation.CurrentXP += xpToGive;
		CheckToSeeIfPlayerLeveled ();
		Debug.Log (xpToGive);

	
	}

	private static void CheckToSeeIfPlayerLeveled(){
		if (GameInformation.CurrentXP >= GameInformation.RequiredXP) {
			//then player has leveled up.
			levelUpScript.LevelUpCharacter();
			//create level up script

		}
	
	}


	
}


