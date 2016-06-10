using UnityEngine;
using System.Collections;

public class EnemyHealthScript : MonoBehaviour {

	public int hp = 2;
	public GameObject Angel;
	public bool isEnemy = true;


	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.name == "GroundPoint") {
			gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			gameObject.GetComponentInChildren<Animator> ().SetBool ("die", true);
			Destroy (gameObject,1f);
			Angel.SetActive (true);

			StartCoroutine (AngelFLying ());


		} else {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();
			if (shot != null) {
				/*if (shot.isEnemyShot != isEnemy) {*/
				hp -= shot.damage;
				Debug.Log ("ai");
				if (hp <= 0) {
					gameObject.GetComponent<BoxCollider2D> ().enabled = false;
					gameObject.GetComponentInChildren<Animator> ().SetBool ("die", true);
					Destroy (gameObject,1f);
				}
			}
		}
	}
	public IEnumerator AngelFLying()
	{	
		while (Angel.transform.position.y < transform.position.y+10){
			Angel.transform.Translate (Vector3.up * 0.2f);
			yield return null; 

		}
	}
}
