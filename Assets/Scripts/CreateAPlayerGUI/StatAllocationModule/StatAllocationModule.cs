using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatAllocationModule {

	private string[] statNames = new string[8] {"Stamina", "Endurance", "Intellect", "Strength", "Overpower", "Luck", "Mastery", "Charisma"};
	private string[] statDescriptions = new string[8] {"Health Modifier", "Energy Modifier", "Magical Damage Modifier", "Physical Damage Modifier", "Haste and Critical Strike Modifier", "All Damage Reduction", "???", "???"};
	private bool[] statSelections = new bool[8];

	public int[] pointsToAllocate = new int[6]; //starting stat vluaes for the chosen class, this one is used to modify
	private int[] baseStatPoints = new int[6];	//starting stat values for the chosen class

	private int availPoints = 5;
	public bool didRunOnce = false;


	//modular so that can be used elsewhere in program
	public void DisplayStatAllocationModule(){
		if (!didRunOnce) {
			RetrieveBaseStatPoints ();
			didRunOnce = true;
		}
		DisplayStatToggleSwitches ();
		DisplayStatIncreaseDecreaseButtons ();
	}

	private void DisplayStatToggleSwitches(){
		for (int i = 0; i < statNames.Length; i++) {
			statSelections[i] = GUI.Toggle (new Rect (10,60 * i + 10,100,50), statSelections [i], statNames [i]);
			GUI.Label (new Rect (100, 60 * i + 10, 50, 50), pointsToAllocate [i].ToString ());
			if (statSelections [i]) {
				GUI.Label (new Rect (20, 60 * i + 30, 150, 100), statDescriptions [i]);
			}
		}
	}

	private void DisplayStatIncreaseDecreaseButtons(){
		for (int i = 0; i < pointsToAllocate.Length; i++) {
			if (pointsToAllocate [i] >= baseStatPoints [i] && availPoints > 0) {
				if (GUI.Button (new Rect (200, 60 * i + 10, 50, 50), "+")) {
					pointsToAllocate [i] += 1;
					--availPoints;
				}
			}
			if(pointsToAllocate[i] > baseStatPoints[i]){
				if(GUI.Button(new Rect(260,60*i+10,50,50), "-")){
					pointsToAllocate[i] -= 1;
					++availPoints;
				}
			}
		}
	}

	private void RetrieveBaseStatPoints(){
		BaseCharacterClass cClass = GameInformation.PlayerClass;

		pointsToAllocate [0] = cClass.Stamina;
		baseStatPoints [0] = cClass.Stamina;

		pointsToAllocate [1] = cClass.Endurance;
		baseStatPoints [1] = cClass.Endurance;

		pointsToAllocate [2] = cClass.Intellect;
		baseStatPoints [2] = cClass.Intellect;

		pointsToAllocate [3] = cClass.Strength;
		baseStatPoints [3] = cClass.Strength;


	}
}