using UnityEngine;
using System.Collections;

public class BananaGunUpgrade : DamUpgradeParrent {


	void Start () {
	
		//COUNT

		damCountNeedGold [0] = 10;
		damCountNeedGold [1] = 20;

		_damCountLvl = PlayerPrefs.GetInt ("BananaCountLvl");

		//RESTORE TIME

		damRestoreTimeNeedGold [0] = 20;
		damRestoreTimeNeedGold [1] = 40;

		_damRestoreTimeLvl = PlayerPrefs.GetInt ("BananaRestoreTimeLvl");

		//DAMAGE

		damDamageNeedGold [0] = 15;
		damDamageNeedGold [1] = 30;

		_damDamageLvl = PlayerPrefs.GetInt ("BananaDamageLvl");
	}



	void Update () {
		if (_damCountLvl >= 1)
			damImage [0].color = Color.blue;
		if (_damCountLvl == 2)
			damImage [1].color = Color.blue;
		if (_damRestoreTimeLvl >= 1)
			damImage [2].color = Color.blue;
		if (_damRestoreTimeLvl == 2)
			damImage [3].color = Color.blue;
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
			PlayerPrefs.SetInt ("BananaCountLvl", _damCountLvl);
		}		
	}

	public override void Count2 ()
	{
		if (GoldScript.Gold >= damCountNeedGold [1] && _damCountLvl == 1) {
			GoldScript.Gold -= damCountNeedGold [1];
			_damCountLvl = 2;
			PlayerPrefs.SetInt ("BananaCountLvl", _damCountLvl);
		}
	}

	public override void RestoreTime1 ()
	{
		if (GoldScript.Gold >= damRestoreTimeNeedGold[0] && _damRestoreTimeLvl == 0) {
			GoldScript.Gold -= damRestoreTimeNeedGold[0];
			_damRestoreTimeLvl = 1;
			PlayerPrefs.SetInt ("BananaRestoreTimeLvl", _damRestoreTimeLvl);
		}		
	}

	public override void RestoreTime2 ()
	{
		if (GoldScript.Gold >= damRestoreTimeNeedGold[1] && _damRestoreTimeLvl == 1) {
			GoldScript.Gold -= damRestoreTimeNeedGold[1];
			_damRestoreTimeLvl = 2;
			PlayerPrefs.SetInt ("BananaRestoreTimeLvl", _damRestoreTimeLvl);
		}
	}

	public override void Damage1 ()
	{
		if (GoldScript.Gold >= damDamageNeedGold [0] && _damDamageLvl == 0) {
			GoldScript.Gold -= damDamageNeedGold [0];
			_damDamageLvl = 1;
			PlayerPrefs.SetInt ("BananaDamageLvl", _damDamageLvl);
		}		
	}

	public override void Damage2 ()
	{
		if (GoldScript.Gold >= damDamageNeedGold [1] && _damDamageLvl == 1) {
			GoldScript.Gold -= damDamageNeedGold [1];
			_damDamageLvl = 2;
			PlayerPrefs.SetInt ("BananaDamageLvl", _damDamageLvl);
		}	
	}
}
