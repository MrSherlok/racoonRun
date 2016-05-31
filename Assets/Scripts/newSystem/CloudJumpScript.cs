using UnityEngine;
using System.Collections;

public class CloudJumpScript : MonoBehaviour {

	public static bool isCloudHeadTouch; // возвращает true когда голова в контакте с тучей
	public static bool isCloudFootTouch;// возвращает true когда персонаж стоит на туче


	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.name == "GroundPoint") {
			isCloudFootTouch = true;

		}
		if (other.gameObject.name == "Headpoint") {
			isCloudHeadTouch = true;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.name == "GroundPoint") {
			isCloudFootTouch = false;

		}
		if (other.gameObject.name == "Headpoint") {
			isCloudHeadTouch = false;
		}
	}
	

}
