using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

	private PlayerController thePlayer;
	private CameraController theCamera;

	//public Vector2 startDirection;

	public string pointName; //name of point where player is starting



	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		Debug.Log ("found player");

		if (thePlayer.startPoint == pointName) {
			Debug.Log ("going to " + pointName);
			thePlayer.transform.position = transform.position;//where is this coming from??? 
			Debug.Log (transform.position);
			Debug.Log (thePlayer.transform.position);
			//thePlayer.lastMove = startDirection;

			theCamera = FindObjectOfType<CameraController> ();
			theCamera.transform.position = new Vector3 (transform.position.x, transform.position.y, theCamera.transform.position.z);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
