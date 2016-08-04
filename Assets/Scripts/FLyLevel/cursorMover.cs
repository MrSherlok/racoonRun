using UnityEngine;
using System.Collections;

public class cursorMover : MonoBehaviour {
	Vector3 pos; 
	public bool IsAttack;
	public bool cursorAtRightPart;
	void Start(){
		if(cursorAtRightPart == false){
			transform.position = new Vector3 (-45, 0, 0);
		}
	}

	void Update () { 
		pos = Camera.main.ScreenToWorldPoint (Input.mousePosition); 
		if (IsAttack == false) {
			if (pos.x < -20) {
				pos.z = 0;	
				pos.x = -45;

				transform.position = pos; 
			}
		}
		if (IsAttack == true) {
			if (pos.x > -20) {
				cursorAtRightPart = true;
				pos.z = 0;	
				//pos.x = -45;

				transform.position = pos; 
			} else {
				cursorAtRightPart = false;
			}
	}
	
	}}

