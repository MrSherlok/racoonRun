using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StringToBanan : MonoBehaviour {
//	public GameObject arrowToBananGun;
	void Start(){
		//arrowToBananGun.SetActive (false);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
//			arrowToBananGun.GetComponent<Image>().enabled = true;
			GameObject.Find ("bananaGun").GetComponent<Image>().enabled = true;
			GameObject.Find ("shootpoint").GetComponent<BananaGun> ().enabled = true;
		}
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			//arrowToBananGun.SetActive(false);
		}
	}

}
