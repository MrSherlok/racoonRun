using UnityEngine;
using System.Collections;

public class animatorOff : MonoBehaviour {

	void OnAnimationEnd() {
		gameObject.GetComponent<Animator> ().enabled = false;
		gameObject.GetComponentInChildren<Renderer> ().enabled = false;
		gameObject.GetComponentInChildren<Collider2D> ().enabled = false;
		gameObject.GetComponentInChildren<ShotScript> ().enabled = false;
	}
}
