using UnityEngine;
using System.Collections;

abstract public class SpellParent : MonoBehaviour {
	public Object shotPrefab;
	public GameObject shoot;
	public float cooldown;
	public float activeTime;
	public int damage;
	public int clount;
	public bool nonCooldown = true;

	abstract public void OnClick ();
		
	


}
