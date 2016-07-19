using UnityEngine;
using System.Collections;

public class CosmosRade : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player") {
			//Умирает персонаж от того , что оппал в космос 
			GameObject.Find ("Player").GetComponent<Rigidbody2D> ().gravityScale = 0.0f;
			GameObject.Find ("Player").GetComponent<Rigidbody2D> ().velocity += 2*Vector2.up;
			GameObject.Find ("Player1").GetComponent<HealthScript> ().Dead (2);

		}
	}
}
