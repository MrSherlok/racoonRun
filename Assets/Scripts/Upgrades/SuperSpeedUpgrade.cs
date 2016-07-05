﻿using UnityEngine;
using System.Collections;

public class SuperSpeedUpgrade : DefUpgradeParrent {

	void Start() {

		//COUNT

		defCountNeedGold [0] = 10;
		defCountNeedGold [1] = 20;

		_defCountLvl = PlayerPrefs.GetInt ("SuperSpeedCountLvl");

		//RESTORE TIME

		defRestoreTimeNeedGold [0] = 20;
		defRestoreTimeNeedGold [1] = 40;

		_defRestoreTimeLvl = PlayerPrefs.GetInt ("SuperSpeedRestoreTimeLvl");

		//RESTORE SPEED

		defRestoreSpeedNeedGold [0] = 20;
		defRestoreSpeedNeedGold [1] = 40;

		_defRestoreSpeedLvl = PlayerPrefs.GetInt ("SuperSpeedRestoreSpeedLvl");

		//DAMAGE

		defSpecialNeedGold [0] = 15;
		defSpecialNeedGold [1] = 30;

		_defSpecialLvl = PlayerPrefs.GetInt ("SuperSpeedSpecialLvl");

	}
	public override void DefCount1 ()
	{
		if (GoldScript.Gold >= defCountNeedGold [0] && _defCountLvl == 0) {
			GoldScript.Gold -= defCountNeedGold [0];
			_defCountLvl = 1;
			PlayerPrefs.SetInt ("SuperSpeedCountLvl", _defCountLvl);
		}
	}

	public override void DefCount2 ()
	{
		if (GoldScript.Gold >= defCountNeedGold [1] && _defCountLvl == 1) {
			GoldScript.Gold -= defCountNeedGold [1];
			_defCountLvl = 2;
			PlayerPrefs.SetInt ("SuperSpeedCountLvl", _defCountLvl);
		}
	}

	public override void DefRestoreTime1 ()
	{
		if (GoldScript.Gold >= defRestoreTimeNeedGold [0] && _defRestoreTimeLvl == 0) {
			GoldScript.Gold -= defRestoreTimeNeedGold [0];
			_defRestoreTimeLvl = 1;
			PlayerPrefs.SetInt ("SuperSpeedRestoreTimeLvl", _defRestoreTimeLvl);
		}
	}

	public override void DefRestoreTime2 ()
	{
		if (GoldScript.Gold >= defRestoreTimeNeedGold [1] && _defRestoreTimeLvl == 1) {
			GoldScript.Gold -= defRestoreTimeNeedGold [1];
			_defRestoreTimeLvl = 2;
			PlayerPrefs.SetInt ("SuperSpeedRestoreTimeLvl", _defRestoreTimeLvl);
		}
	}

	public override void DefRestoreSpeed1 ()
	{
		if (GoldScript.Gold >= defRestoreSpeedNeedGold [0] && _defRestoreSpeedLvl == 0) {
			GoldScript.Gold -= defRestoreSpeedNeedGold [0];
			_defRestoreSpeedLvl = 1;
			PlayerPrefs.SetInt ("SuperSpeedRestoreSpeedLvl", _defRestoreSpeedLvl);
		}
	}

	public override void DefRestoreSpeed2 ()
	{
		if (GoldScript.Gold >= defRestoreSpeedNeedGold [1] && _defRestoreSpeedLvl == 1) {
			GoldScript.Gold -= defRestoreSpeedNeedGold [1];
			_defRestoreSpeedLvl = 2;
			PlayerPrefs.SetInt ("SuperSpeedRestoreSpeedLvl", _defRestoreSpeedLvl);
		}
	}

	public override void Special1 ()
	{
		if (GoldScript.Gold >= defSpecialNeedGold [0] && _defSpecialLvl == 0) {
			GoldScript.Gold -= defSpecialNeedGold [0];
			_defSpecialLvl = 1;
			PlayerPrefs.SetInt ("SuperSpeedSpecialLvl", _defSpecialLvl);
		}
	}

	public override void Special2 ()
	{
		if (GoldScript.Gold >= defSpecialNeedGold [1] && _defSpecialLvl == 1) {
			GoldScript.Gold -= defSpecialNeedGold [1];
			_defSpecialLvl = 2;
			PlayerPrefs.SetInt ("SuperSpeedSpecialLvl", _defSpecialLvl);
		}	
	}
}
