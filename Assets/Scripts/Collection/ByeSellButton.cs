using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ByeSellButton : MonoBehaviour {

	public ItemParrent[] Scripts = new ItemParrent[10];

	public Image[] ItemsImage = new Image[10];

	string[] NamesFB = new string[10];

	int activeItem = 0;

	int i = 0;

	void Start() {
		NamesFB [0] = "1FBye";
		NamesFB [1] = "2FBye";
		NamesFB [2] = "3FBye";
		NamesFB [3] = "4FBye";
		NamesFB [4] = "5FBye";
		NamesFB [5] = "6FBye";
		NamesFB [6] = "7FBye";
		NamesFB [7] = "8FBye";
		NamesFB [8] = "9FBye";
		NamesFB [9] = "10FBye";

	}

	void Update () {
		activeItem = PlayerPrefs.GetInt ("ActiveItem");

		if (PlayerPrefs.GetInt(Scripts [i].name) != 1) {
			ItemsImage [i].color = new Color32 (0, 0, 0, 150);
		} else {
			ItemsImage [i].color = new Color32 (255, 255, 255, 255);
		}



		if (activeItem == i) {
			ItemsImage [i].GetComponent<RotateScript> ().enabled = true;
		} else {
			ItemsImage [i].GetComponent<RotateScript> ().enabled = false;
			ItemsImage [i].GetComponent<RectTransform> ().rotation = Quaternion.identity;
		}


		i++;
		if (i == 9)
			i = 0;


	}

	public void ByeSell() {
		
		if (PlayerPrefs.GetInt (Scripts [activeItem].name.ToString ()) != 1) {
			if (GoldScript.Gold >= Scripts [activeItem].byePrise) {
				GoldScript.Gold -= Scripts [activeItem].byePrise;
				PlayerPrefs.SetInt (Scripts [activeItem].name.ToString (), 1);
				Scripts [activeItem].DataUpdate ();
				Scripts[activeItem].price.text = "Sell: " + Scripts[activeItem].sellPrise.ToString ();
			}
		} else {
			PlayerPrefs.SetInt (NamesFB[activeItem].ToString(),1);
			GoldScript.Gold += Scripts [activeItem].sellPrise;
			PlayerPrefs.SetInt (Scripts [activeItem].name.ToString (), 0);
			Scripts [activeItem].DataUpdate ();
			Scripts[activeItem].price.text = "Bye: " + Scripts[activeItem].byePrise.ToString ();
			}
	}


}
