using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {
	private bool isPause = false;
	private Image chooseLvl;
	public void Start () {
		chooseLvl = GameObject.Find("Back").GetComponent<Image>();
	}

	public void Pause () {
		isPause = !isPause;
		if (isPause) {
			Time.timeScale = 0; 
			chooseLvl.enabled = true;
			} else {
			Time.timeScale = 1; 
			chooseLvl.enabled = false;

		}

	}
}
