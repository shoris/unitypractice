[System.Serializable]
public class BaseEndurance : BaseStat {

	public BaseEndurance(){
		StatName = "Endurance";
		StatDescription = "Directly modifies player's endurance";
		StatType = StatTypes.ENDURANCE;
		StatBaseValue = 0;
		StatModifiedValue = 0;

	}
}
