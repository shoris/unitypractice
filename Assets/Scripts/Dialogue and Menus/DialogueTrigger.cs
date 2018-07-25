using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
	private bool didCollide;



	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.name == "Player"){
			didCollide = true;
			Debug.Log ("Player entered trigger area");
		}

	}
	private void OnTriggerExit2D(Collider2D collision){
		if (collision.gameObject.name == "Player") {
			didCollide = false;
			Debug.Log ("Player exited trigger area.");
		}
	}

	void Update(){
		if (Input.GetKeyUp (KeyCode.Z) && didCollide && DialogueManager2.Talking == false) {
			Debug.Log ("pressed Z.");
			TriggerDialogue ();
		} 
//		if (Input.GetKeyUp (KeyCode.Z) && didCollide && DialogueManager2.Talking == true) {
//			return;
//		}
	}



	public void TriggerDialogue(){
		Debug.Log ("Triggering dialogue......");

		FindObjectOfType<DialogueManager2> ().StartDialogue (dialogue);

	}
}
