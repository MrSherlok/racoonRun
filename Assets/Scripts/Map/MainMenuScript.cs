using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

public void LoadMap () {
		SceneManager.LoadScene("chooseLVL");
	}
}
