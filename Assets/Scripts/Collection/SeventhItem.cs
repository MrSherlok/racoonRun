using UnityEngine;
using System.Collections;

public class SeventhItem : ItemParrent {

	void Start() {
		isActiveItem = PlayerPrefs.GetInt("SeventhItem");
		name = "Soda";
		description = "Drink me";
		DataUpdate ();
	}

	public override void DataUpdate() {
		sellPrise = 20;
		wasFirstBye = PlayerPrefs.GetInt ("7FBye");
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
		PlayerPrefs.SetInt("ActiveItem",6);
	}
}
