﻿//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//
//public class DialogueManager : MonoBehaviour {
//
//	public GameObject dialogueBox;
//	public Text dialogueText;
//
//	public bool dialogueActive;
//
//	private static bool dialogueManagerExists;
//
////	void Awake(){
////		DontDestroyOnLoad (transform.gameObject);
////	}
////
//	// Use this for initialization
//	void Start () {
////		if (!dialogueManagerExists) {
////
////			dialogueManagerExists = true;
////			DontDestroyOnLoad (transform.gameObject);
////
////		} else {
////			Destroy (gameObject);
////		}
//	}
//	
//	// Update is called once per frame
//	void Update () {
////		if (dialogueActive && Input.GetKeyDown(KeyCode.Z)) {
////			dialogueBox.SetActive (false);
////			dialogueActive = false;
////		}
//	}
//
//	public void ShowBox(string dialogue){
//		dialogueActive = true;
//		dialogueBox.SetActive (true);
//		dialogueText.text = dialogue;
//	}
//}
