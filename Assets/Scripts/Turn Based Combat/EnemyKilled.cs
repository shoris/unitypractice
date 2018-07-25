using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKilled : MonoBehaviour {

	private GameObject enemy;

	// Use this for initialization
	private void Awake(){
		enemy = GameObject.Find("slime");
	}
	
	// Update is called once per frame
	void Update () {
		if (GameInformation.BattleWon == true) {
			enemy.SetActive (false);
			Debug.Log ("Enemy is dead.");
		} 
	}
}
