using UnityEngine;
using System.Collections;

public class CollectSpel : MonoBehaviour {
	//bool isCatch = false;
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
	//		isCatch = true;
			StartCoroutine (RotObject ());
		}
	}
	public IEnumerator RotObject()
	{	
		while (gameObject.transform.position.y < gameObject.transform.position.y+10){
			gameObject.transform.Translate (Vector3.up * 0.2f);
			yield return null; 

		}
	}
	}

