using UnityEngine;
using System.Collections;

public class CloudSpawner : MonoBehaviour {
	public Transform[] spawnPoints = new Transform[3];
	int chosedPointNumber;
	void OnTriggerExit2D (Collider2D col) {
		if (col.tag == "BlackCloud") {

			chosedPointNumber = Random.Range (0, 3);
			if (chosedPointNumber == 0)
				col.transform.position = spawnPoints[0].position;
			if (chosedPointNumber == 1)
				col.transform.position = spawnPoints[1].position;
			if (chosedPointNumber == 2)
				col.transform.position = spawnPoints[2].position;
			col.gameObject.transform.position = new Vector2(col.transform.position.x,col.transform.position.y + Random.Range (1f, 6f));
			col.GetComponent<CloudMover> ().speed = Random.Range(14f,20f);

		}
	}}
