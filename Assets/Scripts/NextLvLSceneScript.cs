using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class NextLvLSceneScript : MonoBehaviour {
	public GameObject winImage;
	public GameObject uiBars;

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player") {
			//winImage.SetActive (true);
			//Time.timeScale = 0;
			GameObject.Find("Player").transform.position = GameObject.Find("WinTeleportPoint").transform.position;
			winImage.SetActive(true);
			GameObject.Find ("Player1").GetComponent<Animator>().SetBool("IWIN",true);
			uiBars.SetActive (false);

		}
	}

}
