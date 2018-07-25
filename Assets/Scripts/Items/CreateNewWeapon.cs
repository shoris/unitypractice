using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour {

//	private BaseWeapon newWeapon;
//
//	void Start(){
//		CreateWeapon ();
//		Debug.Log (newWeapon.ItemName);
//		Debug.Log (newWeapon.ItemDescription);
//		Debug.Log (newWeapon.ItemID.ToString());
//		Debug.Log (newWeapon.WeaponType.ToString());
//		Debug.Log (newWeapon.Stamina.ToString());
//		Debug.Log (newWeapon.Endurance.ToString());
//	}
//
//	public void CreateWeapon(){
//
//		newWeapon = new BaseWeapon ();
//
//		//assign name to weapon
//		newWeapon.ItemName = "W" + Random.Range(1,101);
//		//create weapon description
//		newWeapon.ItemDescription = "This is a new weapon."; //could create array of strings
//		//weapon ID
//		newWeapon.ItemID = Random.Range(1, 101);
//		//stats
//		newWeapon.Stamina = Random.Range(1,11);
//		newWeapon.Endurance = Random.Range (1, 11);
//		newWeapon.Intellect = Random.Range(1,11);
//		newWeapon.Strength = Random.Range (1, 11);
//		//choose type of weapon
//		ChooseWeaponType();
//		//spell effect ID
//		newWeapon.SpellEffectID = Random.Range(1,101);
//	
//	}
//
//	private void ChooseWeaponType(){
//		System.Array weapons = System.Enum.GetValues (typeof(BaseWeapon.WeaponTypes));
//		newWeapon.WeaponType = (BaseWeapon.WeaponTypes)weapons.GetValue (Random.Range (0, weapons.Length));
//	
//	}
}
