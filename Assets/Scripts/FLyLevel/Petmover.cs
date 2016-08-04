using UnityEngine;
using System.Collections;

public class Petmover : MonoBehaviour {
	public GameObject cursor;
	private Vector3 curPos;
	public float smooth;
	void Update () {
		transform.position = Vector3.Lerp(transform.position,cursor.transform.position,smooth);

	}
}
