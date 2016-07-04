using UnityEngine;
using System.Collections;

abstract public class DefSpellParent : MonoBehaviour {

	public float cooldown;
	public float activeTime;
	public float timeTo;


	abstract public void OnClickDef (bool isPressed);
}
