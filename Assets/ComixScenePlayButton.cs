using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ComixScenePlayButton : MonoBehaviour {

	// Use this for initialization
	public void Skip () {
		SceneManager.LoadScene("LoadScene");
	}
	

}
