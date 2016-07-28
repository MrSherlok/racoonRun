using UnityEngine;
using System.Collections;

abstract public class DefSpellParent : MonoBehaviour {

	protected float[] defCount = new float[3];
	protected float[] defRestoreTime = new float[3];
	protected float[] defRestoreSpeed = new float[3];
	protected float[] defSpecial = new float[3];

	public float cooldown;
	public float activeTime;
	public float timeTo;
	public float cooldownTimer;
	public float count;
	public bool onCooldown = true;
	public float restoreSpeed;


	abstract public void OnClickDef (bool isPressed);
}
