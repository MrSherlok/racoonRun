using UnityEngine;
using System.Collections;

public class EnemyASLogic : MonoBehaviour {
	Animator ani;
	void Start(){
		ani = GameObject.Find("bear_body").GetComponent<Animator> ();
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
		ani.SetTrigger ("attack");

		}

	}
	public void GetDamageAnim(){
		ani.SetTrigger("getDmg");
	}
}
