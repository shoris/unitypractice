using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

	private BaseCharacterRace class1;
	private BaseCharacterClass class2;

	// Use this for initialization
	void Start () {
		class2 = new BaseArcherClass ();
		Debug.Log (class2.CharacterClassName);
		Debug.Log (class2.CharacterClassDescription);
		Debug.Log (class2.MainStat);
		Debug.Log (class2.SecondMainStat);
		Debug.Log (class2.BonusStat);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
