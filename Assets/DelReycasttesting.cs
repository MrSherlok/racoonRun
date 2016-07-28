using UnityEngine;
using System.Collections;

public class DelReycasttesting : MonoBehaviour {
	public Transform target;
	public Transform hitPoint;

	void Start () {
	
	}

	void Update () {
		RaycastHit2D hit = Physics2D.Raycast (gameObject.transform.position,transform.up);
		hitPoint.transform.position = hit.point;
		Debug.DrawLine(gameObject.transform.position,hit.point);
	}
}
