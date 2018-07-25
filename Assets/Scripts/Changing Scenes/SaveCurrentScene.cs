using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveCurrentScene : MonoBehaviour {

	private static Scene scene;

	private static string lastScene;

	// Use this for initialization
	void Update () {
		scene = SceneManager.GetActiveScene ();
		lastScene = scene.name;
		Debug.Log ("current scene is: " + lastScene);
	}
	
	public static void StoreScene(){
		GameInformation.PreviousScene = lastScene;
	}
}
