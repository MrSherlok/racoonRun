using UnityEngine;
using System.Collections;

public class CameraFollow3 : MonoBehaviour {

	GameObject camTargetObject;

	void Awake(){
		if (PlayerPrefs.GetInt("CamTypeChose") == 0) {
			Debug.Log ("Dynamic camera true");
			//gameObject.SetActive (true);
			GetComponent<CameraFollow3> ().enabled = true;
		}
		if (PlayerPrefs.GetInt("CamTypeChose") == 1) {
			Debug.Log ("Dynamic camera false");
			GetComponent<CameraFollow3> ().enabled = false;
		}
	}
	void Start(){
		
		camTargetObject = GameObject.Find("CameraPoint");

			
	}
	void Update () {
		gameObject.transform.position = new Vector3(camTargetObject.transform.position.x,camTargetObject.transform.position.y,-10f);
	

	}
}
