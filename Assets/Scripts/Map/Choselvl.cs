using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Choselvl : MonoBehaviour {
	AudioSource clickSound;
	public bool itsTutorialLevel = false;
	void Start(){
		clickSound = GameObject.Find ("SoundBox").GetComponent<AudioSource> ();
	}

	public void GoToChoseSP () {
		PlayerPrefs.SetString("ChosingLevel",gameObject.name);
		Invoke("GoToChoseSpels",0.2f);
		clickSound.Play ();

	}
	void GoToChoseSpels(){
		if (itsTutorialLevel) {
			SceneManager.LoadScene (gameObject.name);
		} else {
			SceneManager.LoadScene ("chooseSP");
		}
	}
}
