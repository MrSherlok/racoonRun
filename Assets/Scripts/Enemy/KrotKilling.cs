using UnityEngine;
using System.Collections;

public class KrotKilling : MonoBehaviour {
	Animator ani;
	void Start(){
		ani = gameObject.transform.GetChild(0).GetComponent<Animator>();
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			ani.SetTrigger ("Kill");
		}
	}

}
