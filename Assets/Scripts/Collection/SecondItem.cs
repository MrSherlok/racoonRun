using UnityEngine;
using System.Collections;

public class SecondItem : ItemParrent {

	void Start() {
		isActiveItem = PlayerPrefs.GetInt("SecondItem");
		name = "SuperPunch";
		description = "Be strong";
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
		PlayerPrefs.SetInt("ActiveItem",1);
	}
}
