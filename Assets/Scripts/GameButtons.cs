using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour {

	public void Reload ( int nextScene) {		
		PlayerPrefs.SetInt ("Gold", GoldScript.Gold);
		CoinCollect.coins = 0;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1f;
	}

public void BackToChoose () {
        SceneManager.LoadScene("chooseSP");
		Time.timeScale = 1;
		ChooseSPScript.ActiveDamSpel = -1;
		ChooseSPScript.ActiveDefSpel = -1;
		PlayerPrefs.SetInt ("Gold", GoldScript.Gold);
    }

	public void BackToMainMenu () {
        SceneManager.LoadScene("MainMenu");
	}

	public void BackFromLVLToMap() {
		SceneManager.LoadScene("chooseLVL");
		Time.timeScale = 1;
	}


	public void BackToChooseLvl () {
		PlayerPrefs.SetInt ("Gold", GoldScript.Gold);
        SceneManager.LoadScene("chooseLVL");
	}


	public void LoadUpgrade() {
		SceneManager.LoadScene("Upgrade");
	}
	public void LoadSettings() {
		SceneManager.LoadScene("Settings");
	}

	public void LoadCollections() {
		SceneManager.LoadScene("Collection");
	}
}
