using UnityEngine;
using System.Collections;

abstract public class DefUpgradeParrent : MonoBehaviour {

	protected int[] defCountNeedGold = new int[2];
	protected int[] defRestoreTimeNeedGold = new int[2];
	protected int[] defRestoreSpeedNeedGold = new int[2];
	protected int[] defSpecialNeedGold = new int[2];

	protected int _defCountLvl = 0;
	protected int _defRestoreTimeLvl = 0;
	protected int _defRestoreSpeedLvl = 0;
	protected int _defSpecialLvl = 0;

	abstract public void DefCount1 ();
	abstract public void DefCount2 ();

	abstract public void DefRestoreTime1 ();
	abstract public void DefRestoreTime2 ();

	abstract public void DefRestoreSpeed1 ();
	abstract public void DefRestoreSpeed2 ();

	abstract public void Special1 ();
	abstract public void Special2 ();
}
