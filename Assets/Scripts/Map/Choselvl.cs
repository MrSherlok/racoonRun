using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Choselvl : MonoBehaviour {
	AudioSource clickSound;
	public bool itsTutorialLevel = false;
	//Если истина - включаем сценку с комиксом
	public bool isComixScene = false;
	void Start(){
		clickSound = GameObject.Find ("SoundBox").GetComponent<AudioSource> ();
	}

	public void GoToChoseSP () {
		PlayerPrefs.SetString("ChosingLevel",gameObject.name);
		if (!itsTutorialLevel) {
			Invoke ("GoToChoseSpels", 0.1f);
		} else {
			Invoke ("GoToComixScene", 0.1f);
		}
		clickSound.Play ();

	}
	void GoToChoseSpels(){
		if (itsTutorialLevel) {
			SceneManager.LoadScene ("LoadScene");
		} else {
			SceneManager.LoadScene ("chooseSP");
		}
	}
	void GoToComixScene(){
		SceneManager.LoadScene (PlayerPrefs.GetString("ChosingLevel")+"Comix");
	}
}
