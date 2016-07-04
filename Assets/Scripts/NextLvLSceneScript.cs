using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class NextLvLSceneScript : MonoBehaviour {
	public GameObject winImage;

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player") {
			winImage.SetActive (true);
			//Time.timeScale = 0;
			Invoke("Return",2);
		}
	}
	void Return(){
		SceneManager.LoadScene ("chooseLVL");
	}
}
