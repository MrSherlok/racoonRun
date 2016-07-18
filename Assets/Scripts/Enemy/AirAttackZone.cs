using UnityEngine;
using System.Collections;

public class AirAttackZone : MonoBehaviour {
	public bool fLyToPlayer = false;// Лететь атаковать игрока
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Player") {
			Debug.Log("Incoming");
			fLyToPlayer = true;
			GameObject.Find ("Bird").GetComponent<AirBirdLogic> ().Attack ();

		}
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.tag == "Player") {
			Debug.Log("Out");
			fLyToPlayer = false;
			GameObject.Find ("Bird").GetComponent<AirBirdLogic> ().Return ();
		}
	}
}
