using UnityEngine;
using System.Collections;
using UnityEngine.UI;

abstract public class DamUpgradeParrent : MonoBehaviour {

	public Image[] damImage = new Image[6];

	protected int[] damCountNeedGold = new int[2];
	protected int[] damRestoreTimeNeedGold = new int[2];
	protected int[] damDamageNeedGold = new int[2];

	protected int _damCountLvl = 0;
	protected int _damRestoreTimeLvl = 0;
	protected int _damDamageLvl = 0;

	abstract public void Count1 ();
	abstract public void Count2 ();

	abstract public void RestoreTime1 ();
	abstract public void RestoreTime2 ();

	abstract public void Damage1 ();
	abstract public void Damage2 ();
}
