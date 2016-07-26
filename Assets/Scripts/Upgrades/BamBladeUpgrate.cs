using UnityEngine;
using System.Collections;

public class BamBladeUpgrate : DamUpgradeParrent {

	void Start () {

		//COUNT
		damCountNeedGold [0] = 15;
		damCountNeedGold [1] = 25;

		_damCountLvl = PlayerPrefs.GetInt ("BamBladeCountLvl");


		//DAMAGE
		damDamageNeedGold [0] = 15;
		damDamageNeedGold [1] = 30;

		_damDamageLvl = PlayerPrefs.GetInt ("BamBladeDamageLvl");
	}

	void Update () {
		if (_damCountLvl >= 1)
			damImage [0].color = Color.blue;
		if (_damCountLvl == 2)
			damImage [1].color = Color.blue;
		if (_damDamageLvl >= 1)
			damImage [4].color = Color.blue;
		if (_damDamageLvl == 2)
			damImage [5].color = Color.blue;
	}

	public override void Count1 ()
	{
		if (GoldScript.Gold >= damCountNeedGold [0] && _damCountLvl == 0) {
			GoldScript.Gold -= damCountNeedGold [0];
			_damCountLvl = 1;
			PlayerPrefs.SetInt ("BamBladeCountLvl", _damCountLvl);
		}		
	}

	public override void Count2 ()
	{
		if (GoldScript.Gold >= damCountNeedGold [1] && _damCountLvl == 1) {
			GoldScript.Gold -= damCountNeedGold [1];
			_damCountLvl = 2;
			PlayerPrefs.SetInt ("BamBladeCountLvl", _damCountLvl);
		}
	}

	public override void RestoreTime1 ()
	{

	}

	public override void RestoreTime2 ()
	{
		
	}

	public override void Damage1 ()
	{
		if (GoldScript.Gold >= damDamageNeedGold [0] && _damDamageLvl == 0) {
			GoldScript.Gold -= damDamageNeedGold [0];
			_damDamageLvl = 1;
			PlayerPrefs.SetInt ("BamBladeDamageLvl", _damDamageLvl);
		}		
	}

	public override void Damage2 ()
	{
		if (GoldScript.Gold >= damDamageNeedGold [1] && _damDamageLvl == 1) {
			GoldScript.Gold -= damDamageNeedGold [1];
			_damDamageLvl = 2;
			PlayerPrefs.SetInt ("BamBladeDamageLvl", _damDamageLvl);
		}	
	}
}
