using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreLocation : MonoBehaviour {

	private static GameObject player;
	//private static Scene scene = SceneManager.GetActiveScene ();

	private void Awake(){
		player = GameObject.Find("Player");
		//Scene scene = SceneManager.GetActiveScene ();
	}

	public static void StorePlayerLocation(){
		GameInformation.PlayerLocation = player.transform.position;
		SaveCurrentScene.StoreScene ();

		//GameInformation.PreviousScene = scene.ToString();
	}
//
//	public static Vector3 LoadPlayerLocation(){
//		return GameInformation.PlayerLocation;
//	}
}
