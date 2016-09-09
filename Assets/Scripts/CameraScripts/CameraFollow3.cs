using UnityEngine;
using System.Collections;

public class CameraFollow3 : MonoBehaviour {

	GameObject camTargetObject;

	void Awake(){
		if (PlayerPrefs.GetInt("CamTypeChose") == 0) {
			//gameObject.SetActive (true);
			GetComponent<CameraFollow3> ().enabled = true;
		}
		if (PlayerPrefs.GetInt("CamTypeChose") == 1) {
			GetComponent<CameraFollow3> ().enabled = false;
		}
	}
	void Start(){
		
		camTargetObject = GameObject.Find("CameraPoint");

			
	}
	void Update () {
		if (HealthScript.playerDead == false) {
			gameObject.transform.position = new Vector3 (camTargetObject.transform.position.x, camTargetObject.transform.position.y, -10f);
		}	

	}
}
