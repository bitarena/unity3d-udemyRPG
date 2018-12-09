using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStats : MonoBehaviour {
	public string charName;
	public int playerLevel = 1;
	public int currentExp;
	public int[] expToNextLevel;
	public int maxLevel = 100;
	public int baseExp = 1000;
	

	public int currentHP;
	public int maxHP = 100;
	public int currentMP;
	public int maxMP = 30;
	public int[] mpLevelBonus;
	public int strength;
	public int defense;
	public int weaponPower;
	public int arorPower;
	public string equippedWeapon;
	public string equippedArmor;
	public Sprite charImage;

	// Use this for initialization
	void Start () {
		expToNextLevel = new int[maxLevel];
		expToNextLevel[1] = baseExp;

		for (int i = 2; i < expToNextLevel.Length; i++) {
				expToNextLevel[i] = Mathf.FloorToInt(
					expToNextLevel[i - 1] * 1.05f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.K)) {
			AddExp(500);
		}
	}

	public void AddExp(int expToAdd) {
		currentExp += expToAdd;

		if (playerLevel < maxLevel 
			&& currentExp > expToNextLevel[playerLevel]) {
			currentExp -= expToNextLevel[playerLevel];
			playerLevel++;

			// determine whether to add to str or def based
			// on odd or even
			if (playerLevel % 2 == 0) {
				strength++;
			} else {
				defense++;
			}

			maxHP = Mathf.FloorToInt(maxHP * 1.05f);
			currentHP = maxHP;

			maxMP += mpLevelBonus[playerLevel];
			currentMP = maxMP;
		}

		if (playerLevel >= maxLevel) {
			currentExp = 0;
		}
	}
}
