using UnityEngine;
using System.Collections;

public class GameButtons : MonoBehaviour {


public void Reload () {
		Application.LoadLevel (Application.loadedLevel);
	}

public void BackToChoose () {
		Application.LoadLevel (2);
		Time.timeScale = 1;
		ChooseSPScript.chooseSuperSpeedEnable = false;
		ChooseSPScript.choooseFlyingEnable = false;
		ChooseSPScript.chooseSuperJumpEnable = false;
	}

	public void BackToMainMenu () {
		Application.LoadLevel (0);
	}


	public void BackToChooseLvl () {
		Application.LoadLevel (1);
	}
}
