//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//
//public class DialogueHolder : MonoBehaviour {
//
//	public string dialogue;
//	private DialogueManager dialogueManager;
//	private bool playerCollide;
//
//	// Use this for initialization
//	void Start () {
//		dialogueManager = FindObjectOfType<DialogueManager>();
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyUp (KeyCode.Z) && playerCollide) {
//			dialogueManager.ShowBox (dialogue);
//			playerCollide = false;
//		}
//		if (Input.GetKeyDown(KeyCode.Z) && (dialogueManager.dialogueActive == true)) {
//			dialogueManager.dialogueBox.SetActive (false);
//			dialogueManager.dialogueActive = false;
//
//		}
//
//	}
//
//	private void OnTriggerEnter2D(Collider2D collision){
//		if (collision.gameObject.name == "Player") {
////			if (Input.GetKeyUp (KeyCode.Z)) {
////				dialogueManager.ShowBox (dialogue);
////			}
//			playerCollide = true;
//		}
//
//	}
//	private void OnTriggerExit2D (Collider2D collision){
//		if (collision.gameObject.name == "Player") {
//			playerCollide = false;
//		}
//	}
//}
