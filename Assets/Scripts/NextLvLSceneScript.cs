using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NextLvLSceneScript : MonoBehaviour {
	public GameObject winImage;
	public GameObject uiBars;
	public Text coinsCollet;
	public int LevelIndex;

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Player") {
			//winImage.SetActive (true);
			//Time.timeScale = 0;
			GameObject.Find("Player").transform.position = GameObject.Find("WinTeleportPoint").transform.position;
			winImage.SetActive(true);
			coinsCollet.text = "Coins = " + CoinCollect.coins.ToString ();
			GameObject.Find ("Player1").GetComponent<Animator>().SetBool("IWIN",true);
			uiBars.SetActive (false);
			PlayerPrefs.SetInt ("UnlockingLvls",LevelIndex);

		}
	}

}
