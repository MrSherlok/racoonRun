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
		gameObject.transform.localScale = new Vector3(2f, 2f, 1f);
		_mainAudioVolime = volumeScrollbar.GetComponent<Scrollbar> ().value = AudioListener.volume;
		_camTypeChose = camPesetDropBox.GetComponent<Dropdown>().value;
		PlayerPrefs.SetFloat ("MainAudioVolume",_mainAudioVolime);
		PlayerPrefs.SetInt ("CamTypeChose", _camTypeChose);

		Invoke ("Back", 0.1f);
	}

	void Back() {
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		Apply();
	}

	void Apply(){
		SceneManager.LoadScene("MainMenu");
	}

}
