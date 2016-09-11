using UnityEngine;
using System.Collections;

public class E_SlugLogic : MonoBehaviour {

	ParticleSystem dieFx;
	public GameObject scrrenBlocker;
	float speed;
	void Start () {
		dieFx = GetComponent<ParticleSystem>();
		speed = 8f;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Player") {
			dieFx.Play ();
			BlockScreenOn();
		}
	}
	void BlockScreenOn(){
		scrrenBlocker.SetActive(true);
		Invoke("BlockScreenOff",3f);
		speed = 0f;
	}
	void BlockScreenOff(){
		scrrenBlocker.SetActive(false);
		gameObject.SetActive (false);

	}
	void Update(){
		transform.Translate(Vector2.right * Time.deltaTime * speed);
	}
}
