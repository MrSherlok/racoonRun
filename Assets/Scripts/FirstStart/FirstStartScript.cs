using UnityEngine;
using System.Collections;

public class FirstStartScript : MonoBehaviour {
		
	void Start () {
		if (PlayerPrefs.GetInt ("wasFirstStart") != 0) {
			PlayerPrefs.DeleteAll ();
			PlayerPrefs.SetInt ("wasFirstStart", 1);
		}
	}
}
