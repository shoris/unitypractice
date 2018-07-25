using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour {

	public bool gamePaused = false;
	public GameObject pauseMenu;

	private Text playerName;
	private Text playerLevel;
	private Text playerHealth;
	private Text playerStamina;
	private Text playerIntellect;


	void Start(){
		playerLevel = transform.Find ("PauseMenu").Find ("Stats1").GetComponent<Text> ();
		playerHealth = transform.Find ("PauseMenu").Find ("Stats2").GetComponent<Text> ();
		playerStamina = transform.Find("PauseMenu").Find("Stats3").GetComponent<Text>();
		playerIntellect = transform.Find("PauseMenu").Find("Stats4").GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {
		//playerName.text = GameInformation.PlayerName;
		playerLevel.text = "Lvl: " + GameInformation.PlayerLevel.ToString();
		playerHealth.text = "Health: " + GameInformation.PlayerHealth.ToString ();
		playerStamina.text = "Stamina: " + GameInformation.Stamina.ToString ();
		playerIntellect.text = "Intellect: " + GameInformation.Intellect.ToString ();

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (gamePaused == false) {
				Time.timeScale = 0;
				gamePaused = true;
				pauseMenu.SetActive (true);
			} else {
				pauseMenu.SetActive (false);
				//Cursor.visible = false;
				gamePaused = false;
				Time.timeScale = 1;
			}
		}
	}
}
