using UnityEngine;
using System.Collections;

public class EnemyHealthScript : MonoBehaviour {

	public int hp = 2;

	public bool isEnemy = true;


	void OnTriggerEnter2D(Collider2D collider)
	{
		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();
		if (shot != null) {
			/*if (shot.isEnemyShot != isEnemy) {*/
				hp -= shot.damage;					
				if (hp <= 0) {
				Destroy (transform.parent.gameObject);
				/*}*/
			}
		}
	}
}
