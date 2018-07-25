using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAPlayerGUI : MonoBehaviour {

	public enum CreateAPlayerStates{
		CLASSSELECTION,	//display all class types
		STATALLOCATION,	//allocate stats where player wants to
		FINALSETUP,		//add name and misc items, gender
	}

	private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions ();

	public static CreateAPlayerStates currentState;

	// Use this for initialization
	void Start () {
		currentState = CreateAPlayerStates.CLASSSELECTION;

	}

	// Update is called once per frame
	void Update () {
		switch (currentState) {
		case(CreateAPlayerStates.CLASSSELECTION):
			break;
		case(CreateAPlayerStates.STATALLOCATION):
			break;
		case(CreateAPlayerStates.FINALSETUP):
			break;
		}

	}
	void OnGUI(){
		displayFunctions.DisplayMainItems ();
		if (currentState == CreateAPlayerStates.CLASSSELECTION) {
			//Display class selection function	
			displayFunctions.DisplayClassSelections();
		}
		if (currentState == CreateAPlayerStates.STATALLOCATION) {
			//Display stat alloc function		
			displayFunctions.DisplayStatAllocation();
		}
		if (currentState == CreateAPlayerStates.FINALSETUP) {
			//Display final setup function	
			Debug.Log(GameInformation.Stamina);
			displayFunctions.DisplayFinalSetup();
		}
	}
}
