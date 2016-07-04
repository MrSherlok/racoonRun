using UnityEngine;
using System.Collections;

abstract public class DamSpellParent : MonoBehaviour {
	public GameObject shotPrefab;
	public GameObject shoot;
	public float cooldown;
	public float activeTime;
	public float timer;
	public int damage;
	public int count;
	public int maxCount;
	public bool nonCooldown = true;

	abstract public void OnClick ();
}
