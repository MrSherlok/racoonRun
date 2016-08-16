using UnityEngine;
using System.Collections;

public class CloudMover : MonoBehaviour {
	public float speed = 20;
	void Update () {
		transform.Translate(Vector2.left * Time.deltaTime*speed);
	}
}
