using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatCalculations {

	private float enemyStaminaModifier = 0.25f; //25%
	private float enemyEnduranceModifier = 0.25f; //25%
	private float enemyIntellectModifier = 0.2f;	//20%
	private float enemyStrengthModifier = 0.2f;	//20%
	private float enemyOverpowerModifier = 0.1f;	//20%
	private float enemyMasteryModifier = 0.1f;	//20%
	private float enemyLuckModifier = 0.1f;	//20%
	private float enemyCharismaModifier = 0.1f;	//20%
	private float playerStaminaModifier = 0.30f; //30%
	private float playerEnduranceModifier = 0.30f; //30%
	private float statModifier;

	private float mainStatModifier = 0.5f;
	private float secondMainStatModifier = 0.2f;

	public enum StatType{
		STAMINA,
		ENDURANCE,
		INTELLECT,
		STRENGTH,
		OVERPOWER,
		MASTERY,
		LUCK,
		CHARISMA
	}

	public int CalculateStat(int statVal, StatType statType, int level, bool isEnemy){
		if (isEnemy) {
			SetEnemyModifier (statType);
			return (statVal + (int)((statVal * statModifier) * level));
		} else if (!isEnemy){
			SetEnemyModifier (statType);
			return (statVal + (int)((statVal * statModifier) * level));
		}
		return 0;
	

	}

	private void SetEnemyModifier(StatType statType){
		
		if (statType == StatType.STAMINA) {
			statModifier = enemyStaminaModifier;
			statModifier = playerStaminaModifier;
		}
		if (statType == StatType.ENDURANCE) {
			statModifier = enemyEnduranceModifier;
			statModifier = playerEnduranceModifier;
		}
		if (statType == StatType.INTELLECT) {
			statModifier = enemyIntellectModifier;
		}
		if (statType == StatType.STRENGTH) {
			statModifier = enemyStrengthModifier;
		}
		if (statType == StatType.OVERPOWER) {
			statModifier = enemyOverpowerModifier;
		}
		if (statType == StatType.MASTERY) {
			statModifier = enemyMasteryModifier;
		}
		if (statType == StatType.LUCK) {
			statModifier = enemyLuckModifier;
		}
		if (statType == StatType.CHARISMA) {
			statModifier = enemyCharismaModifier;
		}

		
	}

	public int CalculateHealth(int statVal){
		return statVal * 100;	// calculating health based on total stamina stat*100

	}

	public int CalculateEnergy(int statVal){
		return statVal * 50;		// calculating energy
		}

	public float FindPlayerMainStatAndCalculateMainStatModifier(){
		if (GameInformation.PlayerClass.MainStat == BaseCharacterClass.MainStatBonuses.INTELLECT 
			&& GameInformation.PlayerClass.SecondMainStat == BaseCharacterClass.SecondStatBonuses.ENDURANCE) {
			//8 int at lvl 1
			Debug.Log(GameInformation.Intellect);
			return (GameInformation.Intellect * mainStatModifier) + (GameInformation.Endurance * secondMainStatModifier);

		}
		return 1.0f;
	}
}
