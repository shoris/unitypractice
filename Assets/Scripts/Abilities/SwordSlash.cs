[System.Serializable]
public class SwordSlash : BaseAbility {

	public SwordSlash(){
		AbilityName = "Sword Slash";
		AbilityDescription = "A strong slash from a sword.";
		AbilityID = 2;
		AbilityPower = 20;
		AbilityCost = 10;
		AbilityStatusEffects.Add (new BurnStatusEffect ());
		AbilityStatusEffect = new BurnStatusEffect ();
		AbilityCritChance = 85;
		AbilityCritModifier = 1.2f; //120%

	}
}
