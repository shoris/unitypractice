using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager2 : MonoBehaviour {

	// make it persistent
	private static DialogueManager2 dialogueManager;
	void Awake(){
		if (dialogueManager == null) {
			DontDestroyOnLoad (transform.gameObject);
			dialogueManager = this;
		} else if (dialogueManager != this){
			Destroy (gameObject);
		}
	}

	public Text nameText;
	public Text dialogueText;

	//private bool playerCollide;
	private static bool talking = false;

	public Animator animator;

	private static bool dialogueEnded = false;

	private Queue<string> sentences;

	public static bool Talking{
		get{ return talking; }
		set{ talking = value; }
	}

	public static bool DialogueEnded {
		get{ return dialogueEnded; }
		set{ dialogueEnded = value; }
	}

	// Use this for initialization
	void Start () {
		sentences = new Queue<string> ();
	}

	void Update(){
		if (talking == true && Input.GetKeyUp (KeyCode.Z) && sentences.Count >= 0) {
			DisplayNextSentence ();
		}
	
//		if (sentences.Count == 0) {
//			EndDialogue ();
//		}
	}

	public void StartDialogue(Dialogue dialogue){
		//Debug.Log ("Starting conversation with " + dialogue.name);
		StopAllCoroutines();
		animator.SetBool ("IsOpen", true);
		talking = true;

		nameText.text = dialogue.name;

		sentences.Clear ();

		foreach (string sentence in dialogue.sentences) {
			sentences.Enqueue (sentence);
			Debug.Log ("Enqueueing sentences.");
			//Debug.Log (sentences);
		}

		DisplayNextSentence ();
	}

	public void DisplayNextSentence(){

		Debug.Log ("Displaying next sentence.....");
//	
		if (sentences.Count == 0 ) {
			StartCoroutine(EndDialogue ());
			return;
		}

		Debug.Log ("pressed Z to continue");
		string sentence = sentences.Dequeue ();
		dialogueText.text = sentence;
		Debug.Log (sentence);
			//StopAllCoroutines ();
//		StartCoroutine (TypeSentence(sentence));



	}

//	IEnumerator TypeSentence(string sentence){
//		dialogueText.text = "";
//		foreach (char letter in sentence.ToCharArray()) {
//			dialogueText.text += letter;
//			yield return null;
//		}
//	}

	IEnumerator EndDialogue()
	{
		Debug.Log("End Conversation");
		animator.SetBool ("IsOpen", false);
		yield return 0;
		talking = false;

	}


}