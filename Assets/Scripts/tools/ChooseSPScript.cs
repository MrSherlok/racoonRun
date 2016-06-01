using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseSPScript : MonoBehaviour {

	public static int ActiveDamSpel = -1;
	public static int ActiveDefSpel = -1;

	public static bool chooseSuperSpeedEnable = false;
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
        if (chooseSuperSpeedEnable)
        {
            chooseSuperSpeedImage.color = Color.red;
        }
        else {
            chooseSuperSpeedImage.color = Color.white;
        }

        if (choooseFlyingEnable)
        {
            chooseFlyingImage.color = Color.red;
        }
        else {
            chooseFlyingImage.color = Color.white;
        }

        if (chooseSuperJumpEnable)
        {
            chooseSuperJumpImage.color = Color.red;
        }
        else {
            chooseSuperJumpImage.color = Color.white;
        }

        if (chooseCookieRangEnable)
        {
            chooseCookieRangImage.color = Color.red;
        }
        else {
            chooseCookieRangImage.color = Color.white;
        }

        if (chooseBananaGunEnable)
        {
            chooseBananaGunImage.color = Color.red;
        }
        else {
            chooseBananaGunImage.color = Color.white;
        }

        if (chooseSuperPunchEnable)
        {
            chooseSuperPunchImage.color = Color.red;
        }
        else {
            chooseSuperPunchImage.color = Color.white;
        }
    }

    public void SuperSpeedEnable () {
		chooseSuperSpeedEnable = !chooseSuperSpeedEnable;
        if (chooseSuperSpeedEnable) {
            choooseFlyingEnable = false;
            chooseSuperJumpEnable = false;
			ActiveDefSpel = 2;
		} else ActiveDefSpel = -1;
    }

	public void FlyingEnable () {
		choooseFlyingEnable = !choooseFlyingEnable;
        if (choooseFlyingEnable)
        {
            chooseSuperSpeedEnable = false;
            chooseSuperJumpEnable = false;
			ActiveDefSpel = 1;
		} else ActiveDefSpel = -1;
    }

	public void SuperJumpEnable () {
		chooseSuperJumpEnable = !chooseSuperJumpEnable;
        if (chooseSuperJumpEnable)
        {
            choooseFlyingEnable = false;
            chooseSuperSpeedEnable = false;
			ActiveDefSpel = 0;
		} else ActiveDefSpel = -1;
    }

	public void CookieRangEnable () {
        chooseCookieRangEnable = !chooseCookieRangEnable;
        if (chooseCookieRangEnable)
        {
            chooseBananaGunEnable = false;
            chooseSuperPunchEnable = false;
			ActiveDamSpel = 2;
		} else ActiveDamSpel = -1;
    }
	
	public void BananaGunEnable() {
        chooseBananaGunEnable = !chooseBananaGunEnable;
        if (chooseBananaGunEnable)
        {
            chooseCookieRangEnable = false;
            chooseSuperPunchEnable = false;
			ActiveDamSpel = 0;
		} else ActiveDamSpel = -1;
    }
	
	public void SuperPunchEnable () {
        chooseSuperPunchEnable = !chooseSuperPunchEnable;
        if (chooseSuperPunchEnable)
        {
            chooseBananaGunEnable = false;
            chooseCookieRangEnable = false;
			ActiveDamSpel = 1;
		} else ActiveDamSpel = -1;
    }

	public void NextLvL () {
		SceneManager.LoadScene("1Mike");
	}

  
}
