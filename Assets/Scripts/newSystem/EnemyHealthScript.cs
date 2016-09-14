using UnityEngine;
using System.Collections;

public class EnemyHealthScript : MonoBehaviour {
    [SerializeField]
	int hp = 2;
	public GameObject Angel;
	GameObject player;
	void Start(){
		player = GameObject.Find ("Player");	
	}


	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.name == "GroundPoint") {
			
			gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			player.GetComponent<Player>().IKick ();
			gameObject.GetComponentInChildren<Animator> ().SetBool ("die", true);
			Destroy (gameObject,1f);
			Angel.SetActive (true);
			StartCoroutine (AngelFLying ());
		} else {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();
			if (shot != null) {
				
				if (collider.gameObject.tag == "salmon") {
					gameObject.GetComponent<BoxCollider2D> ().enabled = false;
					collider.GetComponent<ParticleSystem>().Play();
					//ТИХОН ТУТ АНИМАЦИЯ С РЫБКОЙ
					gameObject.GetComponentInChildren<Animator> ().SetTrigger("salmonDie");


					collider.gameObject.SetActive (false);
					Destroy (gameObject, 3f);
				} else {
					hp -= shot.damage;
					if (collider.gameObject.tag == "bananaGun") {
						collider.GetComponent<ParticleSystem>().Play();
						collider.gameObject.GetComponent<BoxCollider2D> ().enabled = false;
					}
					if (collider.gameObject.tag == "cookieRang") {
						collider.GetComponent<ParticleSystem>().Play();
					}

					if (hp <= 0) {
						gameObject.GetComponent<BoxCollider2D> ().enabled = false;
						gameObject.GetComponentInChildren<Animator> ().SetBool ("die", true);
						Destroy (gameObject, 1f);
					}
				}
			}
		}
	}
	public IEnumerator AngelFLying()
	{	
		while (Angel.transform.position.y < transform.position.y+10){
			Angel.transform.Translate (Vector3.up * 0.2f);
			yield return null; 

		}
	}
}
