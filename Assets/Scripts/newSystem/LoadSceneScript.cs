using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour {

	private int pers;
	AsyncOperation ao;
	bool doneLoadingScene = false;
	float time = 0f;
	bool itWas = false;

	void Start () {
		itWas = false;
	}


	void Update()
	{
		time += Time.deltaTime;
		if (time >= 1f && !itWas) {
			StartCoroutine (LoadLevel());
			itWas = true;
		}

		if (ao != null && !doneLoadingScene) {
			if (ao.isDone) {
				doneLoadingScene = true;
				ao.allowSceneActivation = true;
			}
		}
	}


	IEnumerator LoadLevel(){
		
		ao = SceneManager.LoadSceneAsync ("1MikeNewSkill", LoadSceneMode.Single);
		yield return ao;
	}

	/*
	 	void Start()
	{
		doneLoadingScene = false;

		StartCoroutine (LoadNextLevelAsync ());

	}



	void Update()
	{
		if (ao != null && !doneLoadingScene) {
			//progressSlider.value = ao.progress * 100f;
			if (ao.isDone) {
				progressSlider.value = 100f;
				doneLoadingScene = true;
			}
		}
	}
		

	IEnumerator LoadLevel(){
		ao = SceneManager.LoadSceneAsync (NextSceneIndex, LoadSceneMode.Single);
		yield return ao;
	}
	 * */
}
