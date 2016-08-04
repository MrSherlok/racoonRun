using UnityEngine;
using System.Collections;

public class Bulletshot : MonoBehaviour {
	public GameObject shootpoint;
	void OnEnable () {
		transform.position = shootpoint.transform.position;
		transform.rotation = (shootpoint.transform.rotation);

	}
	void Update () {
		transform.Translate(Vector3.right * Time.deltaTime*50);
		Invoke("LiveTime",1.5f);
	}
	void LiveTime(){
		gameObject.SetActive(false);
	}
}
