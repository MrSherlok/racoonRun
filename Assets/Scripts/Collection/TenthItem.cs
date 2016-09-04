using UnityEngine;
using System.Collections;

public class TenthItem : ItemParrent {

	void Start() {

		isActiveItem = PlayerPrefs.GetInt("TenthItem");
		name = "Speed";
		description = "be faster then me";
		DataUpdate ();
	}

	public override void DataUpdate() {
		sellPrise = 20;
		wasFirstBye = PlayerPrefs.GetInt ("10FBye");
		if (wasFirstBye == 0) {
			byePrise = 50;
		} else {
			byePrise = 25;
		}
	}

	public override void OnItemClick ()
	{
		ItemPanel.SetActive (true);
		nameTXT.text = "Name: " + name;
		descript.text = "Description: " + description;
		if (isActiveItem == 0) {
			price.text = "Bye: " + byePrise.ToString ();
		} else {
			price.text = "Sell: " + sellPrise.ToString ();
		}
		PlayerPrefs.SetInt("ActiveItem",9);
	}
}
