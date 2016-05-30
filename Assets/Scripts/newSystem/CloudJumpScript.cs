using UnityEngine;
using System.Collections;

public class CloudJumpScript : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "Player" && ChooseSPScript.chooseSuperJumpEnable) {
			gameObject.GetComponent<Collider2D> ().enabled = true;
			gameObject.layer = 8;
		} else {
			gameObject.GetComponent<Collider2D> ().enabled = false;
			gameObject.layer = 9;
		}
	}
	

}
