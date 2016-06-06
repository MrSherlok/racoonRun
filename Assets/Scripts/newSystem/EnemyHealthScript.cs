using UnityEngine;
using System.Collections;

public class EnemyHealthScript : MonoBehaviour {

	public int hp = 2;

	public bool isEnemy = true;


	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.name == "GroundPoint") {
			Debug.Log ("head");
			gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			gameObject.GetComponentInChildren<Animator> ().SetBool ("die", true);
			Destroy (gameObject,1f);
		} else {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();
			if (shot != null) {
				/*if (shot.isEnemyShot != isEnemy) {*/
				Debug.Log ("player");
				hp -= shot.damage;
				if (hp <= 0) {
					gameObject.GetComponent<BoxCollider2D> ().enabled = false;
					gameObject.GetComponentInChildren<Animator> ().SetBool ("die", true);
					Destroy (gameObject,1f);
				}
			}
		}
	}
}
