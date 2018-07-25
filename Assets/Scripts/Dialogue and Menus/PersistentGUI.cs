using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentGUI : MonoBehaviour {

	private static PersistentGUI persistentGUI;

	void Awake(){
		if (persistentGUI == null) {
			DontDestroyOnLoad (transform.gameObject);
			persistentGUI = this;
		} else if (persistentGUI != this){
			Destroy (gameObject);
		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
