using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
	public float lifeTime;
	private float removeTime = 0;
	public int damage = 1;
//	public bool isEnemyShot = false;
/*	Animation anim;

	void Start(){
		anim = GetComponentInParent<Animation> ();
	}
*/
	void OnEnable() {
		removeTime = 0f;
	}

	void FixedUpdate ()
	{
		if (gameObject.tag == "bananaGun") {
			removeTime += Time.deltaTime;
			if (removeTime >= lifeTime) {
				gameObject.SetActive (false);
			}
		}
	}
}
