using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fpsScript : MonoBehaviour {

	float fpsCounter = 0f;
//	float minFPS = 60f;
	public TextMesh txtFPS;
//	public  minFPSt;

	void Update () {
		fpsCounter = (int)(1.0 / Time.deltaTime);
/*		if (fpsCounter <= minFPS) {
			minFPS = fpsCounter;
		}
*/		txtFPS.text = "fps: " + fpsCounter.ToString ();
	//	minFPSt.text = "min fps: " + minFPS.ToString ();
	}
}
