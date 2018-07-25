using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public static PauseMenu pauseMenu;


	public Transform canvas;

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {

			if (canvas.gameObject.activeInHierarchy == false) {        
				canvas.gameObject.SetActive (true);
				Time.timeScale = 0;
			} else 
			{
				canvas.gameObject.SetActive (false);
				Time.timeScale = 1;
			}
		} 
	}
}
//
//	void Awake(){
//		if (information == null) {
//			DontDestroyOnLoad (transform.gameObject);
//			information = this;
//		} else if (information != this){
//			Destroy (gameObject);
//		}
//	}
//
//
//	private bool paused = false;
//
//
//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown(KeyCode.Return)) {
//			paused = TogglePause ();
//		}
//	}
//
//	void OnGUI(){
//		if (paused) {
//			GUILayout.Label ("Game is paused!");
//			if (Input.GetKeyDown (KeyCode.Return)) {
//				paused = TogglePause ();
//			}
//
//		}
//	}
//
//	private bool TogglePause(){
//		if (Time.timeScale == 0f) {
//			Time.timeScale = 1f;
//			return(false);
//		} else {
//			Time.timeScale = 0f;
//			return(true);
//		}
//	}

