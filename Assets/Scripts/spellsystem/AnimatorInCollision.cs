using UnityEngine;
using System.Collections;

public class AnimatorInCollision : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "enemys") {
			//Debug.Log (col.transform.GetChild (0).name);
			col.GetComponent<EnemyASLogic> ().GetDamageAnim ();
			//col.transform.GetChild (0).GetComponent<EnemyASLogic>().DamageAnim ();
		}
	}
}
