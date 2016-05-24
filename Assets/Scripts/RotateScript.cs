using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

	public float speed = 0.5f;
	public Vector3 vec;
	
	// Update is called once per frame
	void FixedUpdate () {
		gameObject.transform.Rotate (vec * speed);
	}
}
