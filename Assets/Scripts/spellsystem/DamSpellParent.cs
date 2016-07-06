using UnityEngine;
using System.Collections;

abstract public class DamSpellParent : MonoBehaviour {

	protected int[] damCount = new int[3];
	protected float[] damRestoreTime = new float[3];
	protected int[] damDamage = new int[3];


	protected GameObject shotPrefab;
	protected GameObject shoot;
	protected float cooldown;
	protected float activeTime;
	protected float timer;
	protected int count;
	protected int maxCount;
	protected bool nonCooldown = true;

	abstract public void OnClick ();
}
