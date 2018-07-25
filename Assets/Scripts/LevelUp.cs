using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp {

	public int maxPlayerLevel = 50;

	public void LevelUpCharacter(){
		//check to see if current XP is greater than required XP
		if (GameInformation.CurrentXP > GameInformation.RequiredXP) {
			GameInformation.CurrentXP -= GameInformation.RequiredXP;
		} else {
			GameInformation.CurrentXP = 0;
		}
		if (GameInformation.PlayerLevel < maxPlayerLevel) {
			GameInformation.PlayerLevel += 1;
			Debug.Log ("Player leveled up!");
			Debug.Log (GameInformation.PlayerLevel);
		
		} else {
			GameInformation.PlayerLevel = maxPlayerLevel;
		}



		//give player stat points
		//randomly decide to give items
		//give them a move/ability
		//give money
		//determine the next amount of required experience
		DetermineRequiredXP();
	
	}

	private void DetermineRequiredXP(){
		int temp = (GameInformation.PlayerLevel * 1000) + 250;
		GameInformation.RequiredXP = temp;
	
	}

	private void DetermineMoneyToGive(){
		if (GameInformation.PlayerLevel <= 10) {
			//give certain amount of money
		}
	}
}
