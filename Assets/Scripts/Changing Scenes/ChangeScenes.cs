using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour {

	public string sceneName;
	public float xPosition;
	public float yPosition;

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.name == "Player") {
			SceneManager.LoadScene(sceneName);
			StoreLocation.StorePlayerLocation ();
			Debug.Log ("Colliding");
			other.transform.position = new Vector3(xPosition, yPosition, 0);



		}

//		if(other.gameObject.name == "Main Camera") {
//			Debug.Log ("Colliding");
//			other.transform.position = new Vector3(xPosition, yPosition, 0);
//			SceneManager.LoadScene(sceneName);
//		}
	}
}