using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseItem {  //BaseWeapon <= BaseStatItem <= BaseItem

	public enum WeaponTypes{
		SWORD,
		STAFF,
		DAGGER,
		BOW,
		SHIELD,
		POLEARM
	}

	private WeaponTypes weaponType;
	private int spellEffectID;

	public WeaponTypes WeaponType {
		get{ return weaponType; }
		set{ weaponType = value; }
	}
	public int SpellEffectID{
		get{ return spellEffectID; }
		set{ spellEffectID = value; }
	}

}
