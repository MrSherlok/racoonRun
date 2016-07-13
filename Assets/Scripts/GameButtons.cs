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
/*		ChooseSPScript.chooseSuperSpeedEnable = false;
		ChooseSPScript.choooseFlyingEnable = false;
		ChooseSPScript.chooseSuperJumpEnable = false;
        ChooseSPScript.chooseCookieRangEnable = false;
        ChooseSPScript.chooseBananaGunEnable = false;
        ChooseSPScript.chooseSuperPunchEnable = false; */
		PlayerPrefs.SetInt ("Gold", GoldScript.Gold);
    }

	public void BackToMainMenu () {
        SceneManager.LoadScene("MainMenu");
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
}
