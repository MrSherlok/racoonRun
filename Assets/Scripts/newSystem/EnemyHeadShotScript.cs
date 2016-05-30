using UnityEngine;
using System.Collections;

public class EnemyHeadShotScript : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			Destroy (transform.parent.gameObject);
		}
	}
}
