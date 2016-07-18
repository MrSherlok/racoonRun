using UnityEngine;
using System.Collections;

public class AirBirdLogic : MonoBehaviour {
	
	public bool attacking = false;
	GameObject player;
	Vector3 firstPosition;
	void Start(){
		player = GameObject.Find ("Player");
		firstPosition = gameObject.transform.position;
	}

	public void Attack(){
		attacking = GameObject.Find("AirEnemy").GetComponent<AirAttackZone> ().fLyToPlayer;
		StartCoroutine ("Go");
	}
	IEnumerator Go () {
		while (attacking == true) {
			gameObject.transform.position = Vector3.Lerp(transform.position,player.transform.position,0.01f);	
			yield return null;
		}
		
	}
	public void Return(){
		attacking = GameObject.Find("AirEnemy").GetComponent<AirAttackZone> ().fLyToPlayer;
		StartCoroutine ("ReturnToPosition");
	}
	IEnumerator ReturnToPosition () {
		while (!attacking) {
			gameObject.transform.position = Vector3.Lerp(transform.position,firstPosition,0.01f);		
			yield return null;
		}

	}
}
