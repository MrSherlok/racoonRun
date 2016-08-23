using UnityEngine;
using System.Collections;
using SmartLocalization;

public class TutorHint : MonoBehaviour {
	
//	public float timeScaleSmoother = 1;
	public string hintText;

	void OnTriggerStay2D (Collider2D col) {
		if (col.gameObject.tag == "Player") {
//			Time.timeScale = timeScaleSmoother;
			Time.timeScale = 0.3f;
			Time.fixedDeltaTime = Time.timeScale * 0.04f;

			GameObject.Find("HintText").GetComponent<HintTextChanger>().ChangeMessage(LanguageManager.Instance.GetTextValue(hintText));
		}
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			//			Time.timeScale = 0.5;
			Time.timeScale = 1;
			Time.fixedDeltaTime = Time.timeScale * 0.02f;
		}
	}

}
