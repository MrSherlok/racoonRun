using UnityEngine;
using System.Collections;

public class LvLPartSpawnScript : MonoBehaviour {

	public GameObject[] lvlParts = new GameObject[2];
	int i = 0;

	void OnTriggerEnter2D(Collider2D other) {
//		if (other.gameObject.tag == "wallSpawn") {
			Debug.Log ("sdfh");
	//		Instantiate(lvlParts[i], new Vector3(transform.position.x+50f, transform.position.y,0f), Quaternion.identity);
			i++;
//		}
	}
}
