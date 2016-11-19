﻿using UnityEngine;
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
	Image[] spellsDamImage = new Image[5];
	[SerializeField]
	Image[] spellsDefImage = new Image[5];

	[SerializeField]
	bool[] spellsDamActive = new bool[5];
	[SerializeField]
	bool[] spellsDefActive = new bool[5];


	[SerializeField]
	GameObject[] spellsDamItemsImage = new GameObject[5];
	[SerializeField]
	GameObject[] spellsDefItemsImage = new GameObject[5];
    [SerializeField]
    GameObject doubleJumpImage;


    string[] Names = new string[20];
	string[] Discr = new string[20];

	int i = 0;
	int j = 0;
	public Animator aniPlayer;

	void Start() {
		Names[0] = "Double Jump";
		Names[1] = "Soda Pack";
		Names[2] = "Super Run";
		Names[3] = "Moonwalk";
		Names[4] = "Dominator3000";


		Names[10] = "Banana Gun";
		Names[11] = "Super Punch";
		Names[12] = "Cookie Rang";
		Names[13] = "Bamboo Blade";
		Names[14] = "Salmon";


		Discr [0] = "Jump twice";
		Discr [1] = "Soda+mentos";
		Discr [2] = "Run as gepard";
		Discr [3] = "Walking on the Moon";
		Discr [4] = "Dominate and destroy aweryone";


		Discr [10] = "Give them bananas";
		Discr [11] = "Strong Punch";
		Discr [12] = "Cookie Rang";
		Discr [13] = "Fish and bamboo blade";
		Discr [14] = "Good vs bears";
	}

    void Update()
	{

		if (ActiveDefSpel == -1 && ActiveDamSpel == -1) {
			NameTxt.text = "";
			DiscTxt.text = "";
		}
		if (ActiveDefSpel == -1 && ActiveDamSpel != -1) {
			NameTxt.text = Names [ActiveDamSpel + 10];
			DiscTxt.text = Discr [ActiveDamSpel + 10];
		}
		if (ActiveDefSpel != -1 && ActiveDamSpel == -1) {
			NameTxt.text = Names [ActiveDefSpel];
			DiscTxt.text = Discr [ActiveDefSpel];
		}




		if (ActiveDefSpel == j) {
			spellsDefImage [ActiveDefSpel].color = Color.green;
			spellsDefItemsImage [ActiveDefSpel].SetActive (true);
            if (ActiveDefSpel == 0) doubleJumpImage.SetActive(true);
            else doubleJumpImage.SetActive(false);
		} else {
			spellsDefImage[j].color = Color.white;
			spellsDefItemsImage [j].SetActive (false);
		}



		if (ActiveDamSpel ==  i)
		{
			spellsDamImage [ActiveDamSpel].color = Color.green;
			spellsDamItemsImage [ActiveDamSpel].SetActive (true);
		}
		else {
			spellsDamImage [i].color = Color.white;
			spellsDamItemsImage [i].SetActive (false);
		}

		i++;
		if (i == 5)
			i = 0;

		j++;
		if (j == 5)
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
			spellsDefActive [4] = false;
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
			spellsDefActive [4] = false;
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
			spellsDefActive [4] = false;
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
			spellsDefActive [4] = false;
			spellsDefActive [2] = false;
			spellsDefActive [1] = false;
			spellsDefActive [0] = false;
			NameTxt.text = Names [3];
			DiscTxt.text = Discr [3];
		}
		else ActiveDefSpel = -1;
	}
		
	public void Dominator3000Enable () {

		spellsDefActive [4] = !spellsDefActive [4];
		if (spellsDefActive [4]) {
			ActiveDefSpel = 4;
			spellsDefActive [3] = false;
			spellsDefActive [2] = false;
			spellsDefActive [1] = false;
			spellsDefActive [0] = false;
			NameTxt.text = Names [4];
			DiscTxt.text = Discr [4];
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
			spellsDamActive [4] = false;
			NameTxt.text = Names [10];
			DiscTxt.text = Discr [10];
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
			spellsDamActive [4] = false;
			NameTxt.text = Names [11];
			DiscTxt.text = Discr [11];
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
			spellsDamActive [4] = false;
			spellsDamActive [3] = false;
			spellsDamActive [1] = false;
			spellsDamActive [0] = false;
			NameTxt.text = Names [12];
			DiscTxt.text = Discr [12];
		}
		else ActiveDamSpel = -1;
	}


	public void BamBladeEnable () {

		spellsDamActive [3] = !spellsDamActive [3];
		if (spellsDamActive [3]) {
			ActiveDamSpel = 3;
			spellsDamActive [4] = false;
			spellsDamActive [2] = false;
			spellsDamActive [1] = false;
			spellsDamActive [0] = false;
			NameTxt.text = Names [13];
			DiscTxt.text = Discr [13];
		}
		else ActiveDamSpel = -1;
	}

	public void SalmonEnable () {

		spellsDamActive [4] = !spellsDamActive [4];
		if (spellsDamActive [4]) {
			ActiveDamSpel = 4;
			spellsDamActive [3] = false;
			spellsDamActive [2] = false;
			spellsDamActive [1] = false;
			spellsDamActive [0] = false;
			NameTxt.text = Names [14];
			DiscTxt.text = Discr [14];
		}
		else ActiveDamSpel = -1;
	}

	public void NextLvL () {
		SceneManager.LoadScene("LoadScene");
	}

  
}
