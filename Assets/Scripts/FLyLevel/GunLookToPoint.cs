using UnityEngine;
using System.Collections;

public class GunLookToPoint : MonoBehaviour {

	public GameObject attackCursor;
	Vector3 dir;
	bool cursorAtRightSide;
	void Start(){
		
	}
	void Update () {
		cursorAtRightSide = attackCursor.GetComponent<cursorMover> ().cursorAtRightPart;
		if(cursorAtRightSide == true){
		Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		}
	}
}
