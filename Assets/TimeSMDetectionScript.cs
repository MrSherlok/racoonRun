using UnityEngine;
using System.Collections;

public class TimeSMDetectionScript : MonoBehaviour {
	float i = 0;
	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
//	void Update () {
//		Debug.Log (Time.timeScale);
//	}
		void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "enemys") {
			Time.timeScale = 0.3f;
			Camera.main.orthographicSize = Mathf.Lerp (11f, 7f, 1f);

			Invoke ("SMExit", 0.5f);

		}
		}
	void SMExit(){
		Time.timeScale = 1f;
		Camera.main.orthographicSize = 11;
	}
}
