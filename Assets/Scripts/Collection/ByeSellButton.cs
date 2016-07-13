using UnityEngine;
using System.Collections;

public class ByeSellButton : MonoBehaviour {

	public ItemParrent[] Scripts = new ItemParrent[10];

	string[] Names = new string[10];

	int activeItem = 0;

	void Start() {
		Names [0] = "FirstItem";
		Names [1] = "SecondItem";
		Names [2] = "ThirdItem";
		Names [3] = "FourthItem";
		Names [4] = "FifthItem";
		Names [5] = "SixthItem";
		Names [6] = "SeventhItem";
		Names [7] = "EighthItem";
		Names [8] = "NinethItem";
		Names [9] = "TenthItem";
	}

	public void ByeSell() {
		activeItem = PlayerPrefs.GetInt ("ActiveItem");
		if (PlayerPrefs.GetInt (Names [activeItem].ToString ()) != 1) {
			if (GoldScript.Gold >= Scripts [activeItem].byePrise) {
				GoldScript.Gold -= Scripts [activeItem].byePrise;
				PlayerPrefs.SetInt (Names [activeItem].ToString (), 1);
				Scripts[activeItem].price.text = "Sell: " + Scripts[activeItem].sellPrise.ToString ();
			}
		} else {
			GoldScript.Gold += Scripts [activeItem].sellPrise;
			PlayerPrefs.SetInt (Names [activeItem].ToString (), 0);
			Scripts[activeItem].price.text = "Bye: " + Scripts[activeItem].byePrise.ToString ();
			}
	}
}
