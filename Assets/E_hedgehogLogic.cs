using UnityEngine;
using System.Collections;

public class E_hedgehogLogic : MonoBehaviour {

	Animator ani;
	void Start () {
		ani = GetComponent<Animator>();
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			ani.SetTrigger("Attack");
		}
	}
}
