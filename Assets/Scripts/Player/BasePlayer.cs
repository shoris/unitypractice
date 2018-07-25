using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour {

	private List<BaseStat> playerStats = new List<BaseStat> ();
	//private List<BaseItem> _inventory = new List<BaseItem>();

	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;

	//stats
	private int stamina;	//health modifier
	private int endurance;	//energy modifier
	private int intellect;	//magical damage modifier
	private int strength;	//physical damage modifier
	private int overpower;
	private int luck;
	private int mastery;
	private int charisma;
	private int gold;	//in game currency

	private int currentXP;
	private int requiredXP;
	private int statPointsToAllocate;

	public int CurrentXP{ get; set; }
	public int RequiredXP{ get; set; }
	public int StatPointsToAllocate{ get; set; }

	public string PlayerName {
		get{ return playerName; }
		set{ playerName = value; }
	}

	public int PlayerLevel {
		get{ return playerLevel; }
		set{ playerLevel = value; }
	}

	public BaseCharacterClass PlayerClass {
		get{ return playerClass; }
		set{ playerClass = value; }
	}

	public int Stamina {
		get{ return stamina; }
		set{ stamina = value; }
	}

	public int Endurance {
		get{ return endurance; }
		set{ endurance = value; }
	}

	public int Intellect {
		get{ return intellect; }
		set{ intellect= value; }
	}

	public int Strength {
		get{ return strength; }
		set{ strength = value; }
	}
	public int Overpower {
		get{ return overpower; }
		set{ overpower = value; }
	}
	public int Luck {
		get{ return luck; }
		set{ luck = value; }
	}
	public int Mastery {
		get{ return mastery; }
		set{ mastery = value; }
	}
	public int Charisma {
		get{ return charisma; }
		set{ charisma = value; }
	}



	public int Gold{
		get{ return gold; }
		set{ gold = value; }
	}






}
