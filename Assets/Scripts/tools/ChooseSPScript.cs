using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseSPScript : MonoBehaviour {

	public static int ActiveDamSpel = -1;
	public static int ActiveDefSpel = -1;

	[SerializeField]
	Text NameTxt;
	[SerializeField]
	Text DiscTxt;

	[SerializeField]
	Image[] spellsDamImage = new Image[4];
	[SerializeField]
	Image[] spellsDefImage = new Image[4];

	[SerializeField]
	bool[] spellsDamActive = new bool[4];
	[SerializeField]
	bool[] spellsDefActive = new bool[4];


	string[] Names = new string[8];
	string[] Discr = new string[8];

	int i = 0;
	int j = 0;


	void Start() {
		Names[0] = "Super Jump";
		Names[1] = "Soda Pack";
		Names[2] = "Super Run";
		Names[3] = "Moonwalk";
		Names[4] = "Banana Gun";
		Names[5] = "Super Punch";
		Names[6] = "Cookie Rang";
		Names[7] = "Bamboo Blade";


		Discr [0] = "Jump hieght";
		Discr [1] = "Fly whith mentos";
		Discr [2] = "Run as gepard";
		Discr [3] = "Walking on the Moon";
		Discr [4] = "Give them bananas";
		Discr [5] = "Strong Punch";
		Discr [6] = "Cookie Rang";
		Discr [7] = "Fish and bamboo blade";
	}

    void Update()
    {

		if (ActiveDefSpel == -1 && ActiveDamSpel == -1) {
			NameTxt.text = "";
			DiscTxt.text = "";
		}
		if (ActiveDefSpel == -1 && ActiveDamSpel != -1) {
			NameTxt.text = Names [ActiveDamSpel + 3];
			DiscTxt.text = Discr [ActiveDamSpel + 3];
		}
		if (ActiveDefSpel != -1 && ActiveDamSpel == -1) {
			NameTxt.text = Names [ActiveDefSpel];
			DiscTxt.text = Discr [ActiveDefSpel];
		}




		if (ActiveDefSpel == j) {
			spellsDefImage [ActiveDefSpel].color = Color.red;
		} else {
			spellsDefImage[j].color = Color.white;
		}



		if (ActiveDamSpel ==  i)
		{
			spellsDamImage [ActiveDamSpel].color = Color.red;
		}
		else {
			spellsDamImage [i].color = Color.white;
		}

		i++;
		if (i == 4)
			i = 0;

		j++;
		if (j == 4)
			j = 0;
    }

	public void SuperJumpEnable () {
/*		chooseSuperJumpEnable = !chooseSuperJumpEnable;
		if (chooseSuperJumpEnable)
		{
			choooseFlyingEnable = false;
			chooseSuperSpeedEnable = false;
			ActiveDefSpel = 0;
		} else ActiveDefSpel = -1; */

		spellsDefActive [0] = !spellsDefActive [0];
		if (spellsDefActive [0]) {
			ActiveDefSpel = 0;
			spellsDefActive [1] = false;
			spellsDefActive [2] = false;
			spellsDefActive [3] = false;
			NameTxt.text = Names [0];
			DiscTxt.text = Discr [0];

		}
		else ActiveDefSpel = -1;
	}

	public void FlyingEnable () {
/*		choooseFlyingEnable = !choooseFlyingEnable;
		if (choooseFlyingEnable)
		{
			chooseSuperSpeedEnable = false;
			chooseSuperJumpEnable = false;
			ActiveDefSpel = 1;
		} else ActiveDefSpel = -1; */

		spellsDefActive [1] = !spellsDefActive [1];
		if (spellsDefActive [1]) {
			ActiveDefSpel = 1;
			spellsDefActive [0] = false;
			spellsDefActive [2] = false;
			spellsDefActive [3] = false;
			NameTxt.text = Names [1];
			DiscTxt.text = Discr [1];
		}
		else ActiveDefSpel = -1;
	}

    public void SuperSpeedEnable () {
/*		chooseSuperSpeedEnable = !chooseSuperSpeedEnable;
        if (chooseSuperSpeedEnable) {
            choooseFlyingEnable = false;
            chooseSuperJumpEnable = false;
			ActiveDefSpel = 2;
		} else ActiveDefSpel = -1; */

		spellsDefActive [2] = !spellsDefActive [2];
		if (spellsDefActive [2]) {
			ActiveDefSpel = 2;
			spellsDefActive [3] = false;
			spellsDefActive [1] = false;
			spellsDefActive [0] = false;
			NameTxt.text = Names [2];
			DiscTxt.text = Discr [2];
		}
		else ActiveDefSpel = -1;
    }


	public void MoonWalkEnable () {

		spellsDefActive [3] = !spellsDefActive [3];
		if (spellsDefActive [3]) {
			ActiveDefSpel = 3;
			spellsDefActive [2] = false;
			spellsDefActive [1] = false;
			spellsDefActive [0] = false;
			NameTxt.text = Names [3];
			DiscTxt.text = Discr [3];
		}
		else ActiveDefSpel = -1;
	}
		
	public void BananaGunEnable() {
/*        chooseBananaGunEnable = !chooseBananaGunEnable;
        if (chooseBananaGunEnable)
        {
            chooseCookieRangEnable = false;
            chooseSuperPunchEnable = false;
			ActiveDamSpel = 0;
		} else ActiveDamSpel = -1; */

		spellsDamActive [0] = !spellsDamActive [0];
		if (spellsDamActive [0]) {
			ActiveDamSpel = 0;
			spellsDamActive [1] = false;
			spellsDamActive [2] = false;
			spellsDamActive [3] = false;
			NameTxt.text = Names [4];
			DiscTxt.text = Discr [4];
		}
		else ActiveDamSpel = -1;
    }
	
	public void SuperPunchEnable () {
/*        chooseSuperPunchEnable = !chooseSuperPunchEnable;
        if (chooseSuperPunchEnable)
        {
            chooseBananaGunEnable = false;
            chooseCookieRangEnable = false;
			ActiveDamSpel = 1;
		} else ActiveDamSpel = -1; */

		spellsDamActive [1] = !spellsDamActive [1];
		if (spellsDamActive [1]) {
			ActiveDamSpel = 1;
			spellsDamActive [0] = false;
			spellsDamActive [2] = false;
			spellsDamActive [3] = false;
			NameTxt.text = Names [5];
			DiscTxt.text = Discr [5];
		}
		else ActiveDamSpel = -1;
    }

	public void CookieRangEnable () {
/*		chooseCookieRangEnable = !chooseCookieRangEnable;
		if (chooseCookieRangEnable)
		{
			chooseBananaGunEnable = false;
			chooseSuperPunchEnable = false;
			ActiveDamSpel = 2;
		} else ActiveDamSpel = -1; */

		spellsDamActive [2] = !spellsDamActive [2];
		if (spellsDamActive [2]) {
			ActiveDamSpel = 2;
			spellsDamActive [1] = false;
			spellsDamActive [0] = false;
			NameTxt.text = Names [6];
			DiscTxt.text = Discr [6];
		}
		else ActiveDamSpel = -1;
	}


	public void BamBladeEnable () {
		/*		chooseCookieRangEnable = !chooseCookieRangEnable;
		if (chooseCookieRangEnable)
		{
			chooseBananaGunEnable = false;
			chooseSuperPunchEnable = false;
			ActiveDamSpel = 2;
		} else ActiveDamSpel = -1; */

		spellsDamActive [3] = !spellsDamActive [3];
		if (spellsDamActive [3]) {
			ActiveDamSpel = 3;
			spellsDamActive [2] = false;
			spellsDamActive [1] = false;
			spellsDamActive [0] = false;
			NameTxt.text = Names [7];
			DiscTxt.text = Discr [7];
		}
		else ActiveDamSpel = -1;
	}

	public void NextLvL () {
		SceneManager.LoadScene("LoadScene");
	}

  
}
