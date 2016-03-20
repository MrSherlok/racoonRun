using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour {

public void Reload () {
        SceneManager.LoadScene(Application.loadedLevel);
        Time.timeScale = 1;
	}

public void BackToChoose () {
        SceneManager.LoadScene("chooseSP");
		Time.timeScale = 1;
		ChooseSPScript.chooseSuperSpeedEnable = false;
		ChooseSPScript.choooseFlyingEnable = false;
		ChooseSPScript.chooseSuperJumpEnable = false;
        ChooseSPScript.chooseCookieRangEnable = false;
        ChooseSPScript.chooseBananaGunEnable = false;
        ChooseSPScript.chooseSuperPunchEnable = false;
    }

	public void BackToMainMenu () {
        SceneManager.LoadScene("MainMenu");
	}


	public void BackToChooseLvl () {
        SceneManager.LoadScene("chooseLVL");
	}
}
