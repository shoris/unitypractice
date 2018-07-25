using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayCreatePlayerFunctions  {

	private StatAllocationModule statAllocationModule = new StatAllocationModule ();

	private int classSelection;
	private string[] classSelectionNames = new string[] {"Mage", "Warrior", "Archer", "Rogue", "Warlock", "Paladin"};
	private string playerFirstName = "Enter first name"; // name
	private string playerLastName = "Enter last name";
	private string playerBio= "Enter player bio"; // bio
	private bool isFemale = true;   //keep for now
	private int genderSelection;
	private string[] genderTypes = new string[2]{"Female", "Male"};


	public void DisplayClassSelections(){
		//List of toggle buttons and each button will be a different class
		//selection grid
		classSelection = GUI.SelectionGrid(new Rect(50, 50, 250,300), classSelection, classSelectionNames, 2);
		GUI.Label (new Rect (450, 50, 300, 300), FindClassDescription (classSelection));
		GUI.Label (new Rect (450, 100, 300, 300), FindClassStatValues (classSelection));
	}

	private string FindClassDescription(int classSelection){
		if(classSelection == 0) {
			BaseCharacterClass tempClass = new BaseMageClass();
			return tempClass.CharacterClassDescription;
		} else if (classSelection == 1) {
			BaseCharacterClass tempClass = new BaseWarriorClass();
			return tempClass.CharacterClassDescription;
		} 
			return "NO CLASS FOUND";
	}

	private string FindClassStatValues(int classSelection){
		if(classSelection == 0) {
			BaseCharacterClass tempClass = new BaseMageClass();
			string tempStats = "Stamina " + tempClass.Stamina + "\n" + "Endurance " + tempClass.Endurance;
			return tempStats;
		} else if (classSelection == 1) {
			BaseCharacterClass tempClass = new BaseWarriorClass();
			string tempStats = "Stamina " + tempClass.Stamina + "\n" + "Endurance " + tempClass.Endurance;
			return tempStats;
		} 
		return "NO STATS FOUND";
	}

	public void DisplayStatAllocation(){
		//list of stats with plus and minus buttons to add stats
		//logic to make sure player cannot add more than stats given
		statAllocationModule.DisplayStatAllocationModule();
	}

	public void DisplayFinalSetup(){
		//name
		playerFirstName = GUI.TextArea(new Rect(20,10,150,35), playerFirstName, 25);
		playerLastName = GUI.TextArea (new Rect (20, 55, 150, 35), playerLastName, 25);
		//gender
		genderSelection = GUI.SelectionGrid(new Rect(100,300,100,100), genderSelection, genderTypes, 1);

		//add description to character
		playerBio = GUI.TextArea (new Rect (20, 90, 250, 200), playerBio, 250);

	}

	private void ChooseClass(int classSelection){
		if (classSelection == 0) {
			GameInformation.PlayerClass = new BaseMageClass ();
		} else if (classSelection == 1) {
			GameInformation.PlayerClass = new BaseWarriorClass ();
		}
	}

	public void DisplayMainItems(){
		GUI.Label (new Rect (Screen.width / 2, 20, 250, 100), "CREATE NEW PLAYER");

		if (CreateAPlayerGUI.currentState != CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP) { //if we're not in final setup, then show the next button
			if (GUI.Button (new Rect (525, 170, 50, 50), "Next")) {
				if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION) {
					ChooseClass (classSelection);
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION;
				} else if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION) {
					GameInformation.Stamina = statAllocationModule.pointsToAllocate [0];
					GameInformation.Endurance = statAllocationModule.pointsToAllocate [1];
					GameInformation.Intellect = statAllocationModule.pointsToAllocate [2];
					GameInformation.Strength = statAllocationModule.pointsToAllocate [3];



					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP;
				}
			}
		} else if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP){
			if (GUI.Button (new Rect (525, 170, 50, 50), "Finish")) {
				//FINAL SAVE
				GameInformation.PlayerName = playerFirstName + " " + playerLastName;
				GameInformation.PlayerBio = playerBio;
				if (genderSelection == 0) {
					GameInformation.IsFemale = true;
				} else if (genderSelection == 1) {
					GameInformation.IsFemale = false;
				}
				SaveInformation.SaveAllInformation();
				Debug.Log("MAKE FINAL SAVE");
			}
		}
		if (CreateAPlayerGUI.currentState != CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION) {
			if (GUI.Button (new Rect (295, 170, 50, 50), "Back")) {
				if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION) {
					statAllocationModule.didRunOnce = false;
					Debug.Log (GameInformation.PlayerClass.CharacterClassName);
					GameInformation.PlayerClass = null;
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.CLASSSELECTION;
				} else if (CreateAPlayerGUI.currentState == CreateAPlayerGUI.CreateAPlayerStates.FINALSETUP) {
					CreateAPlayerGUI.currentState = CreateAPlayerGUI.CreateAPlayerStates.STATALLOCATION;
				}
			}
		}



}
}
