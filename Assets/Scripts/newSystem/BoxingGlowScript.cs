using UnityEngine;
using System.Collections;

public class BoxingGlowScript : MonoBehaviour {
		
	void FixedUpdate () {
			gameObject.transform.position = GameObject.Find ("GlowPoint").GetComponent<Transform>().position;
		gameObject.transform.rotation = GameObject.Find ("GlowPoint").GetComponent<Transform>().rotation;
	}
}
