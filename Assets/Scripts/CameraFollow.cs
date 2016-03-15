using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

/*	[SerializeField]
	private float xMax;

	[SerializeField]
	private float yMax;

	[SerializeField]
	private float xMin;

	[SerializeField]
	private float yMin;
*/
	private Transform target;

	int distanse = -10;
	float lift = 1.5f;
	

	// Use this for initialization
	void Start () {
		target = GameObject.Find("CameraPoint").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		transform.position = new Vector3 (0, lift, distanse) + target.position;
		transform.LookAt (target);
	}
}
