using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEquipment : BaseItem {

	public enum EquipmentTypes{
		HEAD,
		CHEST,
		SHOULDERS,
		LEGS,
		FEET,
		NECK,
		EARRING,
		RING
	}

	private EquipmentTypes equipmentType;
	private int spellEffectID;

	public EquipmentTypes EquipmentType{
		get{ return equipmentType; }
		set{ equipmentType = value; }
	}

	public int SpellEffectID {
		get{ return spellEffectID; }
		set{ spellEffectID = value; }
	}

}
