using UnityEngine;
using System.Collections;

abstract public class DefSpellParent : MonoBehaviour {

	protected int[] defCount = new int[3];
	protected float[] defRestoreTime = new float[3];
	protected float[] defRestoreSpeed = new float[3];
	protected float[] defSpecial = new float[3];

	protected float cooldown;
	protected float activeTime;
	protected float timeTo;
	protected float cooldownTimer;
	protected float count;
	protected bool onCooldown = true;
	protected float restoreSpeed;


	abstract public void OnClickDef (bool isPressed);
}
