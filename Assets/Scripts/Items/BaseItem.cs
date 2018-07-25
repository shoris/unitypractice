using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem {

	private string _name;
	private string _description;
	private int _value;
	private List<BaseStat> _stats;
	private ItemTypes _type;

//	private string itemName;
//	private string itemDescription;
//	private int itemID;
//	private int stamina;
//	private int endurance;
//	private int strength;
//	private int intellect;
//	private int overpower;
//	private int luck;
//	private int mastery;
//	private int charisma;

	public BaseItem(){
		ItemName = "Item" + Random.Range (0, 101);
		ItemDescription = ItemName + " is an awesome item!";
		ItemValue = Random.Range (0, 500);
		ItemType = ItemTypes.EQUIPMENT;
		ItemStats = new List<BaseStat> ();
		ItemStats.Add (new BaseStamina ());
		ItemStats.Add (new BaseEndurance ());
	}

	public enum ItemTypes{
		EQUIPMENT, //this will have stats
		WEAPON, //this will have stats
	
	}
//	private ItemTypes itemType;

//	public BaseItem(Dictionary<string, string> itemsDictionary){
//
//
//
//	}
//
	public string ItemName {
		get{ return _name; }
		set{ _name = value; }
	}
	public string ItemDescription {
		get{ return _description; }
		set{ _description = value; }
	}
	public int ItemValue {
		get{ return _value; }
		set{ _value = value; }
	}
	public ItemTypes ItemType{
		get{ return _type ; }
		set{ _type = value; }
	}

	public List<BaseStat> ItemStats{
		get{ return _stats; }
		set{ _stats = value; } 
	}
//	public int Stamina {
//		get{ return stamina; }
//		set{ stamina = value; }
//	}
//
//	public int Endurance {
//		get{ return endurance; }
//		set{ endurance = value; }
//	}
//	public int Strength {
//		get{ return strength; }
//		set{ strength = value; }
//	}
//	public int Intellect {
//		get{ return intellect; }
//		set{ intellect = value; }
//	}
//	public int Overpower {
//		get{ return overpower; }
//		set{ overpower = value; }
//	}
//	public int Luck {
//		get{ return luck; }
//		set{ luck = value; }
//	}
//	public int Mastery {
//		get{ return mastery; }
//		set{ mastery = value; }
//	}
//	public int Charisma {
//		get{ return charisma; }
//		set{ charisma = value; }
//	}
//



}
