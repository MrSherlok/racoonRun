using UnityEngine;
using System.Collections;

public class CoinCollectScript : MonoBehaviour {
	float cutoff = 0f;
	bool startCutOff = false;
//	float n = 0.1f;
	float speedUp = 7;
	[SerializeField] private AudioClip _coinLoot;


	void Update() {

		if (startCutOff == true) {
			
			gameObject.transform.Translate (Vector3.up* Time.deltaTime * speedUp);
			gameObject.GetComponentInChildren<Renderer> ().material.SetFloat ("_Cutoff", cutoff); 
			cutoff += Time.deltaTime*1.3f;
			if (cutoff >= 1.2f) {
				
				Destroy (gameObject);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		
	
		if (col.gameObject.tag == "Player") {

			GameObject.Find("Player").GetComponent<AudioSource>().clip = _coinLoot;
			GameObject.Find("Player").GetComponent<AudioSource>().Play ();
//			Debug.Log ("Yra");
			//CameraFollowScript.ClaimCoinAnim();
			cutoff = 0f;
			startCutOff = true;
			//GoldScript.Gold += 10;
			CoinCollect.AddCoin(1);
		}
	}
}
