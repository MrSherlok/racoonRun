using UnityEngine;
using System.Collections;

public class AirPlatformScript : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.name == "GroundPoint") {
			gameObject.GetComponent<Collider2D> ().isTrigger = false;

		}
		if (other.gameObject.name == "Headpoint") {
			gameObject.GetComponent<Collider2D> ().isTrigger = true;
		}
	}
}
