using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseSPScript : MonoBehaviour {

	public static int ActiveDamSpel = -1;
	public static int ActiveDefSpel = -1;

	public Image[] spellsDamImage = new Image[3];
	public Image[] spellsDefImage = new Image[3];

	public bool[] spellsDamActive = new bool[3];
	public bool[] spellsDefActive = new bool[3];


/*	public static bool chooseSuperSpeedEnable = false;
	public static bool choooseFlyingEnable = false;
	public static bool chooseSuperJumpEnable = false;
	public static bool chooseCookieRangEnable = false;
	public static bool chooseBananaGunEnable = false;
	public static bool chooseSuperPunchEnable = false;

	public Image chooseSuperSpeedImage;
	public Image chooseFlyingImage;
	public Image chooseSuperJumpImage;
    public Image chooseCookieRangImage;
    public Image chooseBananaGunImage;
    public Image chooseSuperPunchImage;
*/
//    private int _lvl = 0; 

    //   public Sprite[] chooseSuperSpeedSprites = new Sprite[2];
    //public Sprite[] chooseFlyingSprites = new Sprite[2];
    //public Sprite[] chooseSuperJumpSprites = new Sprite[2];
    //   public Sprite[] chooseCookieRangSprites = new Sprite[2];
    //   public Sprite[] chooseBananaGunSprites = new Sprite[2];
    //   public Sprite[] chooseSuperPowerSprites = new Sprite[2];

/*        public void Start()
    {
        _lvl = ChengeCenturyScript.lvl;
    }
*/
    public void FixedUpdate()
    {
		//DefSpells

		if (ActiveDefSpel == 0)
		{
			spellsDefImage[0].color = Color.red;
		}
		else {
			spellsDefImage[0].color = Color.white;
		}

		if (ActiveDefSpel == 1)
		{
			spellsDefImage[1].color = Color.red;
		}
		else {
			spellsDefImage[1].color = Color.white;
		}

		if (ActiveDefSpel == 2)
        {
			spellsDefImage[2].color = Color.red;
        }
        else {
			spellsDefImage[2].color = Color.white;
        }

		//DamSpells

		if (ActiveDamSpel == 0)
		{
			spellsDamImage [0].color = Color.red;
		}
		else {
			spellsDamImage [0].color = Color.white;
		}

		if (ActiveDamSpel ==  1)
		{
			spellsDamImage [1].color = Color.red;
		}
		else {
			spellsDamImage [1].color = Color.white;
		}

		if (ActiveDamSpel == 2)
        {
			spellsDamImage [2].color = Color.red;
        }
        else {
			spellsDamImage [2].color = Color.white;
        }

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
			spellsDefActive [1] = false;
			spellsDefActive [0] = false;
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
		}
		else ActiveDamSpel = -1;
	}

	public void NextLvL () {
		SceneManager.LoadScene("1Mike");
	}

  
}
