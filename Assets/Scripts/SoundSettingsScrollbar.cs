using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundSettingsScrollbar : MonoBehaviour {
	public float volume;
	void Start(){
		AudioListener.volume = PlayerPrefs.GetFloat ("MainAudioVolume");
		gameObject.GetComponent<Scrollbar> ().value = AudioListener.volume;
	}
	void Update () {
		 volume = gameObject.GetComponent<Scrollbar>().value;
			AudioListener.volume = volume;
	}
}
