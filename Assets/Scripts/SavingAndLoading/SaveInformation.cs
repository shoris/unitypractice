using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation {

	public static void SaveAllInformation(){
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt ("STAMINA", GameInformation.Stamina);
		PlayerPrefs.SetInt ("ENDURANCE", GameInformation.Endurance);
		PlayerPrefs.SetInt ("INTELLECT", GameInformation.Intellect);
		PlayerPrefs.SetInt ("STRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt ("OVERPOWER", GameInformation.Overpower);
		PlayerPrefs.SetInt ("LUCK", GameInformation.Luck);
		PlayerPrefs.SetInt ("MASTERY", GameInformation.Mastery);
		PlayerPrefs.SetInt ("CHARISMA", GameInformation.Charisma);

		PlayerPrefs.SetInt ("GOLD", GameInformation.Gold);


		if (GameInformation.EquipmentOne != null) {
			PPSerialization.Save ("EQUIPMENTITEM1", GameInformation.EquipmentOne);
		}


		Debug.Log ("SAVED ALL INFORMATION");


	}

}
