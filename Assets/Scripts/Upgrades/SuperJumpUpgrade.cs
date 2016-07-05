using UnityEngine;
using System.Collections;

public class SuperJumpUpgrade : DefUpgradeParrent {

	void Start() {

		//COUNT

		defCountNeedGold [0] = 10;
		defCountNeedGold [1] = 20;

		_defCountLvl = PlayerPrefs.GetInt ("SuperJumpCountLvl");

		//RESTORE TIME

		defRestoreTimeNeedGold [0] = 20;
		defRestoreTimeNeedGold [1] = 40;

		_defRestoreTimeLvl = PlayerPrefs.GetInt ("SuperJumpRestoreTimeLvl");

		//RESTORE SPEED

/*		defRestoreSpeedNeedGold [0] = 20;
		defRestoreSpeedNeedGold [1] = 40;

		_defRestoreSpeedLvl = PlayerPrefs.GetInt ("SuperJumpRestoreSpeedLvl");
*/
		//DAMAGE

		defSpecialNeedGold [0] = 15;
		defSpecialNeedGold [1] = 30;

		_defSpecialLvl = PlayerPrefs.GetInt ("SuperJumpSpecialLvl");

	}
	public override void DefCount1 ()
	{
		if (GoldScript.Gold >= defCountNeedGold [0] && _defCountLvl == 0) {
			GoldScript.Gold -= defCountNeedGold [0];
			_defCountLvl = 1;
			PlayerPrefs.SetInt ("SuperJumpCountLvl", _defCountLvl);
		}
	}

	public override void DefCount2 ()
	{
		if (GoldScript.Gold >= defCountNeedGold [1] && _defCountLvl == 1) {
			GoldScript.Gold -= defCountNeedGold [1];
			_defCountLvl = 2;
			PlayerPrefs.SetInt ("SuperJumpCountLvl", _defCountLvl);
		}
	}

	public override void DefRestoreTime1 ()
	{
		if (GoldScript.Gold >= defRestoreTimeNeedGold [0] && _defRestoreTimeLvl == 0) {
			GoldScript.Gold -= defRestoreTimeNeedGold [0];
			_defRestoreTimeLvl = 1;
			PlayerPrefs.SetInt ("SuperJumpRestoreTimeLvl", _defRestoreTimeLvl);
		}
	}

	public override void DefRestoreTime2 ()
	{
		if (GoldScript.Gold >= defRestoreTimeNeedGold [1] && _defRestoreTimeLvl == 1) {
			GoldScript.Gold -= defRestoreTimeNeedGold [1];
			_defRestoreTimeLvl = 2;
			PlayerPrefs.SetInt ("SuperJumpRestoreTimeLvl", _defRestoreTimeLvl);
		}
	}

	public override void DefRestoreSpeed1 ()
	{
/*		if (GoldScript.Gold >= defRestoreSpeedNeedGold [0] && _defRestoreSpeedLvl == 0) {
			GoldScript.Gold -= defRestoreSpeedNeedGold [0];
			_defRestoreSpeedLvl = 1;
			PlayerPrefs.SetInt ("SuperJumpRestoreSpeedLvl", _defRestoreSpeedLvl);
		}
*/	}

	public override void DefRestoreSpeed2 ()
	{
/*		if (GoldScript.Gold >= defRestoreSpeedNeedGold [1] && _defRestoreSpeedLvl == 1) {
			GoldScript.Gold -= defRestoreSpeedNeedGold [1];
			_defRestoreSpeedLvl = 2;
			PlayerPrefs.SetInt ("SuperJumpRestoreSpeedLvl", _defRestoreSpeedLvl);
		}
*/	}

	public override void Special1 ()
	{
		if (GoldScript.Gold >= defSpecialNeedGold [0] && _defSpecialLvl == 0) {
			GoldScript.Gold -= defSpecialNeedGold [0];
			_defSpecialLvl = 1;
			PlayerPrefs.SetInt ("SuperJumpSpecialLvl", _defSpecialLvl);
		}
	}

	public override void Special2 ()
	{
		if (GoldScript.Gold >= defSpecialNeedGold [1] && _defSpecialLvl == 1) {
			GoldScript.Gold -= defSpecialNeedGold [1];
			_defSpecialLvl = 2;
			PlayerPrefs.SetInt ("SuperJumpSpecialLvl", _defSpecialLvl);
		}	
	}
}