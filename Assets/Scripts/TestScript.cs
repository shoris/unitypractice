using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LoadInformation.LoadAllInformation ();
		Debug.Log ("Player Name: " + GameInformation.PlayerName);
		Debug.Log("Player Class: " + GameInformation.PlayerClass.CharacterClassName);
		Debug.Log("Player Level " + GameInformation.PlayerLevel); 
		Debug.Log("Player Stamina " + GameInformation.Stamina); 
		Debug.Log("Player Endurance " + GameInformation.Endurance); 
		Debug.Log("Player Intellect " + GameInformation.Intellect); 
		Debug.Log("Player Strength " + GameInformation.Strength); 

		Debug.Log("Player Gold: " + GameInformation.Gold);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
