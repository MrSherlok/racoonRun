using UnityEngine;
using System.Collections;

public class CookieRangUpgrade : DamUpgradeParrent {

	void Start () {

		//COUNT
		damCountNeedGold [0] = 10;
		damCountNeedGold [1] = 20;

		_damCountLvl = PlayerPrefs.GetInt ("CookieCountLvl");

		//RESTORE TIME
		damRestoreTimeNeedGold [0] = 15;
		damRestoreTimeNeedGold [1] = 25;

		_damRestoreTimeLvl = PlayerPrefs.GetInt ("CookieRestoreTimeLvl");

		//DAMAGE
		damDamageNeedGold [0] = 15;
		damDamageNeedGold [1] = 30;

		_damDamageLvl = PlayerPrefs.GetInt ("CookieDamageLvl");
	}

	public override void Count1 ()
	{
		if (GoldScript.Gold >= damCountNeedGold [0] && _damCountLvl == 0) {
			GoldScript.Gold -= damCountNeedGold [0];
			_damCountLvl = 1;
			PlayerPrefs.SetInt ("CookieCountLvl", _damCountLvl);
		}		
	}

	public override void Count2 ()
	{
		if (GoldScript.Gold >= damCountNeedGold [1] && _damCountLvl == 1) {
			GoldScript.Gold -= damCountNeedGold [1];
			_damCountLvl = 2;
			PlayerPrefs.SetInt ("CookieCountLvl", _damCountLvl);
		}
	}

	public override void RestoreTime1 ()
	{
		if (GoldScript.Gold >= damRestoreTimeNeedGold[0] && _damRestoreTimeLvl == 0) {
			GoldScript.Gold -= damRestoreTimeNeedGold[0];
			_damRestoreTimeLvl = 1;
			PlayerPrefs.SetInt ("CookieRestoreTimeLvl", _damRestoreTimeLvl);
		}		
	}

	public override void RestoreTime2 ()
	{
		if (GoldScript.Gold >= damRestoreTimeNeedGold[1] && _damRestoreTimeLvl == 1) {
			GoldScript.Gold -= damRestoreTimeNeedGold[1];
			_damRestoreTimeLvl = 2;
			PlayerPrefs.SetInt ("CookieRestoreTimeLvl", _damRestoreTimeLvl);
		}
	}

	public override void Damage1 ()
	{
		if (GoldScript.Gold >= damDamageNeedGold [0] && _damDamageLvl == 0) {
			GoldScript.Gold -= damDamageNeedGold [0];
			_damDamageLvl = 1;
			PlayerPrefs.SetInt ("CookieDamageLvl", _damDamageLvl);
		}		
	}

	public override void Damage2 ()
	{
		if (GoldScript.Gold >= damDamageNeedGold [1] && _damDamageLvl == 1) {
			GoldScript.Gold -= damDamageNeedGold [1];
			_damDamageLvl = 2;
			PlayerPrefs.SetInt ("CookieDamageLvl", _damDamageLvl);
		}	
	}
}
