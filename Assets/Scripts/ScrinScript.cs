using UnityEngine;
using System.Collections;

public class ScrinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.autorotateToPortrait = true;
		
		Screen.autorotateToPortraitUpsideDown = true;
		
		Screen.orientation = ScreenOrientation.AutoRotation;
	}
	
	// Update is called once per frame
	void FixedUpdate() {
	
	}
}
