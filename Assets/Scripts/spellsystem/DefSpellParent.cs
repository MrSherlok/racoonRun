using UnityEngine;
using System.Collections;

abstract public class DefSpellParent : MonoBehaviour {

	public float cooldown;
	public float activeTime;
	public float timeTo;
	public float cooldownTimer;
	public float count;
	public bool onCooldown = true;
	public int restoreSpeed;


	abstract public void OnClickDef (bool isPressed);
}
