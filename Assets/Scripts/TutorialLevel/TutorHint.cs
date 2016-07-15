using UnityEngine;
using System.Collections;

public class TutorHint : MonoBehaviour {
	
	public float timeScaleSmoother = 1;
	public string hintText;

	void OnTriggerStay2D (Collider2D col) {
		if (col.gameObject.tag == "Player") {
			Time.timeScale = timeScaleSmoother;
			GameObject.Find("HintText").GetComponent<HintTextChanger>().ChangeMessage(hintText);
		}
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			Time.timeScale = 1f;
		}
	}

}
