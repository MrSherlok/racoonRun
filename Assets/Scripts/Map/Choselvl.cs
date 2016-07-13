using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Choselvl : MonoBehaviour {
	AudioSource clickSound;
	void Start(){
		clickSound = GameObject.Find ("SoundBox").GetComponent<AudioSource> ();
	}

	public void GoToChoseSP () {
		PlayerPrefs.SetString("ChosingLevel",gameObject.name);
		Invoke("GoToChoseSpels",0.2f);
		clickSound.Play ();

	}
	void GoToChoseSpels(){
		SceneManager.LoadScene ("chooseSP");
	}
}
