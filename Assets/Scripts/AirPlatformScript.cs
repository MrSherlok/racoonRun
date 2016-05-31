using UnityEngine;
using System.Collections;

public class AirPlatformScript : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.name == "GroundPoint") {
			Invoke ("TriggerOff", 0f);

		}
		if (other.gameObject.name == "Headpoint") {
			Invoke ("TriggerOn", 0f);
		}
	}
		
	void TriggerOn () {
		gameObject.GetComponent<Collider2D> ().isTrigger = true;
	}

	void TriggerOff () {
		gameObject.GetComponent<Collider2D> ().isTrigger = false;
	}



}
