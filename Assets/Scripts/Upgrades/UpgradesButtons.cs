using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradesButtons : MonoBehaviour {

	public GameObject bananaPanel;
	public GameObject cookiePanel;
	public GameObject punchPanel;
	public GameObject bamBladePanel;
	public GameObject jumpPanel;
	public GameObject sodaPanel;
	public GameObject speedPanel;
	public GameObject moonWalkPanel;


	public Text gold;


	public void BananaPanel() {
		bananaPanel.SetActive (true);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
	}

	public void CookiePanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (true);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
	}

	public void PunchPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (true);
		bamBladePanel.SetActive (false);
		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
	}

	public void BamBladePanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (true);
		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
	}

	public void JumpPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		jumpPanel.SetActive (true);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
	}

	public void SodaPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		jumpPanel.SetActive (false);
		sodaPanel.SetActive (true);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
	}

	public void SpeedPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (true);
		moonWalkPanel.SetActive (false);
	}

	public void MoonWalkPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (true);
	}


	void Update() {
		gold.text = GoldScript.Gold.ToString ();
	}
}
