using UnityEngine;
using System.Collections;

public class EnemyASLogic : MonoBehaviour {
	Animator ani;
	Transform hand;
	void Start(){
		ani = gameObject.transform.GetChild(0).GetComponent<Animator> ();
		hand = transform.FindChild("bear_body/body/R_hand/R_hand2/hand");
	}
	public void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			if (col.GetComponent<HealthScript> ().hp <= 0) {
				col.gameObject.transform.parent.gameObject.transform.SetParent(hand,false);
				Fatality ();
				col.gameObject.transform.parent.gameObject.transform.localPosition = new Vector3 (0f,0f,0f);
				col.gameObject.transform.parent.gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;

			}
	//		Debug.Log (col.name +" in " + gameObject.name);
			ani.SetTrigger("attack");
		}

		if (col.tag == "bananaGun") {
			GetDamageAnim ();
		}

	}
	public void GetDamageAnim(){
		ani.SetTrigger("getDmg");
	}
	private void Fatality(){
		ani.SetTrigger("fatality");
		GameObject.Find ("Player").GetComponent<Player> ().BearFatality ();
		Debug.Log ("Fatality");

	}
}
