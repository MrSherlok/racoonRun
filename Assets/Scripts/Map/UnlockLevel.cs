﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour {
	public Image[] levels;
	public Image lvlTargetImage;
	int i;
	[SerializeField]
	int savingLevel;
	void Start ()
	{
		//PlayerPrefs.DeleteAll();
		savingLevel = PlayerPrefs.GetInt ("UnlockingLvls");
		if (savingLevel != null && savingLevel < levels.Length) {
			levels [savingLevel].enabled = true;
			for (i=0; i <= savingLevel; i++) {
				levels [i].enabled = true;
				lvlTargetImage.transform.position = levels [i].transform.position;
			}

		}

	}
}
