using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChooseSPScript : MonoBehaviour {

	public static bool chooseSuperSpeedEnable = false;
	public static bool choooseFlyingEnable = false;
	public static bool chooseSuperJumpEnable = false;
	public bool chooseCookieRangEnable = false;
	public  bool chooseRayEnable = false;
	public bool chooseSuperPowerEnable = false;

	public Image chooseSuperSpeedImage;
	public Image chooseFlyingImage;
	public Image chooseSuperJumpImage;

	public Sprite[] chooseSuperSpeedSprites = new Sprite[2];
	public Sprite[] chooseFlyingSprites = new Sprite[2];
	public Sprite[] chooseSuperJumpSprites = new Sprite[2];

	public void SuperSpeedEnable () {
		chooseSuperSpeedEnable = !chooseSuperSpeedEnable;
		if (chooseSuperSpeedEnable) {
			chooseSuperSpeedImage.sprite = chooseSuperSpeedSprites[1];
		} else {
			chooseSuperSpeedImage.sprite = chooseSuperSpeedSprites[0];
		}
	}

	public void FlyingEnable () {
		choooseFlyingEnable = !choooseFlyingEnable;
		if (choooseFlyingEnable) {
			chooseFlyingImage.sprite = chooseFlyingSprites[1];
		} else {
			chooseFlyingImage.sprite = chooseFlyingSprites[0];
		}
	}

	public void SuperJumpEnable () {
		chooseSuperJumpEnable = !chooseSuperJumpEnable;
		if (chooseSuperJumpEnable) {
			chooseSuperJumpImage.sprite = chooseSuperJumpSprites[1];
		} else {
			chooseSuperJumpImage.sprite = chooseSuperJumpSprites[0];
		}
	}

/*	public void CookieRangEnable () {
		cookieRangEnable = !cookieRangEnable;
	}
	
	public void RayEnable () {
		rayEnable = !rayEnable;
	}
	
	public void SuperPowerEnable () {
		superPowerEnable = !superPowerEnable;
	}*/

	public void NextLvL () {
		Application.LoadLevel (3);
	}
}
