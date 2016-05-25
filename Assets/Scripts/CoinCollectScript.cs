using UnityEngine;
using System.Collections;

public class CoinCollectScript : MonoBehaviour {
	public float cutoff;
	bool startCutOff = false;
	float n = 0.1f;
	public float speedUp = 5;


	void FixedUpdate() {

		if (startCutOff == true) {
			
			gameObject.transform.Translate (Vector3.up* Time.deltaTime * speedUp);
			gameObject.GetComponentInChildren<Renderer> ().material.SetFloat ("_Cutoff", cutoff); 
			cutoff += Time.deltaTime/2;
			if (cutoff >= 1) {
				Destroy (gameObject);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		
	
		if (col.gameObject.tag == "Player") {
			gameObject.GetComponent<AudioSource>().Play ();
			Debug.Log ("Yra");
//			CameraFollowScript.DamageAnim();
			cutoff = 0f;
			startCutOff = true;
		}
	}
}
