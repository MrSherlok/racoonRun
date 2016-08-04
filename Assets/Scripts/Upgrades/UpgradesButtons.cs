using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradesButtons : MonoBehaviour {

	public GameObject bananaPanel;
	public GameObject cookiePanel;
	public GameObject punchPanel;
	public GameObject bamBladePanel;
	public GameObject salmonPanel;


	public GameObject jumpPanel;
	public GameObject sodaPanel;
	public GameObject speedPanel;
	public GameObject moonWalkPanel;
	public GameObject dominator3000Panel;


	public Text gold;


	public void BananaPanel() {
		bananaPanel.SetActive (true);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		salmonPanel.SetActive (false);


		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
		dominator3000Panel.SetActive (false);
	}

	public void CookiePanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (true);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		salmonPanel.SetActive (false);


		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
		dominator3000Panel.SetActive (false);
	}

	public void PunchPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (true);
		bamBladePanel.SetActive (false);
		salmonPanel.SetActive (false);


		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
		dominator3000Panel.SetActive (false);
	}

	public void BamBladePanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (true);
		salmonPanel.SetActive (false);


		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
		dominator3000Panel.SetActive (false);
	}


	public void SalmonPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		salmonPanel.SetActive (true);


		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
		dominator3000Panel.SetActive (false);
	}




	public void JumpPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		salmonPanel.SetActive (false);


		jumpPanel.SetActive (true);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
		dominator3000Panel.SetActive (false);
	}

	public void SodaPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		salmonPanel.SetActive (false);


		jumpPanel.SetActive (false);
		sodaPanel.SetActive (true);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
		dominator3000Panel.SetActive (false);
	}

	public void SpeedPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		salmonPanel.SetActive (false);


		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (true);
		moonWalkPanel.SetActive (false);
		dominator3000Panel.SetActive (false);
	}

	public void MoonWalkPanel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		salmonPanel.SetActive (false);


		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (true);
		dominator3000Panel.SetActive (false);
	}

	public void Dominator3000Panel() {
		bananaPanel.SetActive (false);
		cookiePanel.SetActive (false);
		punchPanel.SetActive (false);
		bamBladePanel.SetActive (false);
		salmonPanel.SetActive (false);


		jumpPanel.SetActive (false);
		sodaPanel.SetActive (false);
		speedPanel.SetActive (false);
		moonWalkPanel.SetActive (false);
		dominator3000Panel.SetActive (true);
	}


	void Update() {
		gold.text = GoldScript.Gold.ToString ();
	}
}
