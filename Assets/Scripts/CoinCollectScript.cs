using UnityEngine;
using System.Collections;

public class CoinCollectScript : MonoBehaviour {
	bool startCutOff = false;
//	float n = 0.1f;
	float speedUp = 7;
	ParticleSystem partsPlay;
	[SerializeField] private AudioClip _coinLoot;

	void Start(){
		partsPlay = GetComponent<ParticleSystem>();
	}

	void OnTriggerEnter2D(Collider2D col){
		
	
		if (col.gameObject.tag == "Player") {

			GameObject.Find("Player").GetComponent<AudioSource>().clip = _coinLoot;
			GameObject.Find("Player").GetComponent<AudioSource>().Play ();
//			Debug.Log ("Yra");
			//CameraFollowScript.ClaimCoinAnim();
			partsPlay.Play ();
			//GoldScript.Gold += 10;
			CoinCollect.AddCoin(1);
			Destroy (gameObject,3f);
		}
	}
}
