using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour {

	public static SceneSwitcher sceneSwitcher;

	// Use this for initialization
	void Start () {
		if (sceneSwitcher == null) {
			sceneSwitcher = this;
		} else {
			Destroy (this);
		}
		DontDestroyOnLoad (this);
	}
	

}
