using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ApplyButton : MonoBehaviour {
	public GameObject volumeScrollbar;
	public GameObject camPesetDropBox;
	float _mainAudioVolime;
	int _camTypeChose;
	// Use this for initialization
	public void SaveSettings () {
		_mainAudioVolime = volumeScrollbar.GetComponent<Scrollbar> ().value = AudioListener.volume;
		_camTypeChose = camPesetDropBox.GetComponent<Dropdown>().value;
		PlayerPrefs.SetFloat ("MainAudioVolume",_mainAudioVolime);
		PlayerPrefs.SetInt ("CamTypeChose", _camTypeChose);
		SceneManager.LoadScene("MainMenu");
	}

}
