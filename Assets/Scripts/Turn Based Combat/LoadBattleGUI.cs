﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBattleGUI : MonoBehaviour {

//	public string levelToLoad;
//
//	public string exitPoint; //name of exit point

	//private PlayerController thePlayer;

	// Use this for initialization
	void Start () {
		//thePlayer = FindObjectOfType<PlayerController> ();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.name == "Player") 
		{
			StoreLocation.StorePlayerLocation ();
			Debug.Log (GameInformation.PreviousScene);
			Debug.Log (GameInformation.PlayerLocation);
			SceneManager.LoadScene ("battle");
			//thePlayer.startPoint = exitPoint;
			//Debug.Log (thePlayer.startPoint);
			//Debug.Log (exitPoint);
			//Debug.Log ("Changed Scenes!" + levelToLoad);


		}


	}
}
