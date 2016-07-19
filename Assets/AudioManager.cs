using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {
	public AudioSource bananagun;

	void Start () {
	
	}
	
	// Update is called once per frame
	public void PlaySound (string soundName) {
		switch (soundName){ 
		case "bananagun":
			bananagun.Play ();
			break;
		}
	}
}
