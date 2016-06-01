using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
	public float lifeTime;
	private float removeTime = 0;
	public int damage = 1;
	public bool isEnemyShot = false;
	// Use this for initialization
	//void Start () {
	//	Destroy (gameObject, 20);
	//}


	void OnEnable() {
		removeTime = 0f;
		if (gameObject.tag == "cookieRang") {
			gameObject.GetComponent<Renderer> ().enabled = true;
			gameObject.GetComponentInParent<Animator> ().enabled = true;
			gameObject.GetComponent<Collider2D> ().enabled = true;
		}
		if (gameObject.tag == "bananaGun") {
			gameObject.GetComponent<Renderer> ().enabled = true;
			gameObject.GetComponent<ScrollingScript> ().enabled = true;
			gameObject.GetComponent<Collider2D> ().enabled = true;
		}
	}

	void FixedUpdate()
    {
		if (gameObject.tag != "superPunch"/* || gameObject.tag != "enemys"*/) {
			removeTime += Time.deltaTime;
			if (removeTime >= lifeTime) {
				if (/*isEnemyShot == false &&*/ gameObject.tag == "cookieRang") {
					gameObject.GetComponent<Collider2D> ().enabled = false;
					gameObject.GetComponent<Renderer> ().enabled = false;
					gameObject.GetComponent<ShotScript> ().enabled = false;
					gameObject.GetComponentInParent<Animator> ().enabled = false;
				}

				if (/*isEnemyShot == false && */gameObject.tag == "bananaGun") {
					gameObject.GetComponent<Collider2D> ().enabled = false;
					gameObject.GetComponent<ScrollingScript> ().enabled = false;
					gameObject.GetComponent<Renderer> ().enabled = false;
					gameObject.GetComponent<ShotScript> ().enabled = false;
				}
			}
		}
    }
}
