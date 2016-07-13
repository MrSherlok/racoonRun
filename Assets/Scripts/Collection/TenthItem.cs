using UnityEngine;
using System.Collections;

public class TenthItem : ItemParrent {

	void Start() {

		isActiveItem = PlayerPrefs.GetInt("TenthItem");
		name = "Speed";
		description = "be faster then me";
		sellPrise = 20;
		byePrise = 25;
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
