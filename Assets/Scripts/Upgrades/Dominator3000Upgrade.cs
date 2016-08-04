using UnityEngine;
using System.Collections;

public class Dominator3000Upgrade : DefUpgradeParrent {

	void Start() {

		//COUNT

		defCountNeedGold [0] = 10;
		defCountNeedGold [1] = 20;

		_defCountLvl = PlayerPrefs.GetInt ("Dominator3000CountLvl");

		//RESTORE TIME

		defRestoreTimeNeedGold [0] = 20;
		defRestoreTimeNeedGold [1] = 40;

		_defRestoreTimeLvl = PlayerPrefs.GetInt ("Dominator3000RestoreTimeLvl");

		//RESTORE SPEED

		defRestoreSpeedNeedGold [0] = 20;
		defRestoreSpeedNeedGold [1] = 40;

		_defRestoreSpeedLvl = PlayerPrefs.GetInt ("Dominator3000RestoreSpeedLvl");

		//DAMAGE

//		defSpecialNeedGold [0] = 15;
//		defSpecialNeedGold [1] = 30;

//		_defSpecialLvl = PlayerPrefs.GetInt ("SuperSpeedSpecialLvl");
	}


	void Update () {
		if (_defCountLvl >= 1)
			defImage [0].color = Color.blue;
		if (_defCountLvl == 2)
			defImage [1].color = Color.blue;
		if (_defRestoreTimeLvl >= 1)
			defImage [2].color = Color.blue;
		if (_defRestoreTimeLvl == 2)
			defImage [3].color = Color.blue;
		if (_defRestoreSpeedLvl >= 1)
			defImage [4].color = Color.blue;
		if (_defRestoreSpeedLvl == 2)
			defImage [5].color = Color.blue;
	}


	public override void DefCount1 ()
	{
		if (GoldScript.Gold >= defCountNeedGold [0] && _defCountLvl == 0) {
			GoldScript.Gold -= defCountNeedGold [0];
			_defCountLvl = 1;
			PlayerPrefs.SetInt ("Dominator3000CountLvl", _defCountLvl);
		}
	}

	public override void DefCount2 ()
	{
		if (GoldScript.Gold >= defCountNeedGold [1] && _defCountLvl == 1) {
			GoldScript.Gold -= defCountNeedGold [1];
			_defCountLvl = 2;
			PlayerPrefs.SetInt ("Dominator3000CountLvl", _defCountLvl);
		}
	}

	public override void DefRestoreTime1 ()
	{
		if (GoldScript.Gold >= defRestoreTimeNeedGold [0] && _defRestoreTimeLvl == 0) {
			GoldScript.Gold -= defRestoreTimeNeedGold [0];
			_defRestoreTimeLvl = 1;
			PlayerPrefs.SetInt ("Dominator3000RestoreTimeLvl", _defRestoreTimeLvl);
		}
	}

	public override void DefRestoreTime2 ()
	{
		if (GoldScript.Gold >= defRestoreTimeNeedGold [1] && _defRestoreTimeLvl == 1) {
			GoldScript.Gold -= defRestoreTimeNeedGold [1];
			_defRestoreTimeLvl = 2;
			PlayerPrefs.SetInt ("Dominator3000RestoreTimeLvl", _defRestoreTimeLvl);
		}
	}

	public override void DefRestoreSpeed1 ()
	{
		if (GoldScript.Gold >= defRestoreSpeedNeedGold [0] && _defRestoreSpeedLvl == 0) {
			GoldScript.Gold -= defRestoreSpeedNeedGold [0];
			_defRestoreSpeedLvl = 1;
			PlayerPrefs.SetInt ("Dominator3000RestoreSpeedLvl", _defRestoreSpeedLvl);
		}
	}

	public override void DefRestoreSpeed2 ()
	{
		if (GoldScript.Gold >= defRestoreSpeedNeedGold [1] && _defRestoreSpeedLvl == 1) {
			GoldScript.Gold -= defRestoreSpeedNeedGold [1];
			_defRestoreSpeedLvl = 2;
			PlayerPrefs.SetInt ("Dominator3000RestoreSpeedLvl", _defRestoreSpeedLvl);
		}
	}

	public override void Special1 ()
	{

	}

	public override void Special2 ()
	{

	}
}
