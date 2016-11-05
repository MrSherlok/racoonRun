using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour {


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseScript.isPause)
            {
                PauseScript.Pause();
            } else
            {
                if (SceneManager.GetActiveScene().name == "chooseSP" ||
                    SceneManager.GetActiveScene().name == "Upgrade" ||
                    SceneManager.GetActiveScene().name == "Collection" ||
                    SceneManager.GetActiveScene().name == "Settings" ||
                    SceneManager.GetActiveScene().name == "Tut001" ||
                    SceneManager.GetActiveScene().name == "Lvl001" ||
                    SceneManager.GetActiveScene().name == "Lvl002" ||
                    SceneManager.GetActiveScene().name == "Lvl003" ||
                    SceneManager.GetActiveScene().name == "Lvl004" ||
                    SceneManager.GetActiveScene().name == "Lvl005")
                    BackFromLVLToMap();
                else if (SceneManager.GetActiveScene().name == "chooseLVL")
                    BackToMainMenu();
                else if (SceneManager.GetActiveScene().name == "MainMenu")
                    Application.Quit();
            }
        }
    }


	public void Reload ( int nextScene) {		
		PlayerPrefs.SetInt ("Gold", GoldScript.Gold);
		CoinCollect.coins = 0;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1f;
	}

public void BackToChoose () {
        SceneManager.LoadScene("chooseLVL");
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
