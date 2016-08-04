using UnityEngine;
using System.Collections;

public class E_ballonHealth : MonoBehaviour {
	bool dead= false;
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "bullet") {
			Invoke("Dead",2f);
			dead = true;
		}
	}

	void Update () {
		if (dead == true)
			gameObject.transform.Translate(Vector2.up * 2);
	}
	void Dead(){
		gameObject.SetActive (false);
	}
}
