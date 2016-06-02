using UnityEngine;
using System.Collections;

public class BoxingGlowScript : MonoBehaviour {
		
	void FixedUpdate () {
		gameObject.transform.position = GameObject.Find ("GlowPoint").transform.position;
		gameObject.transform.rotation = GameObject.Find ("GlowPoint").transform.rotation;
	}
}
