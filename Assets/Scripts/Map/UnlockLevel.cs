using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour {
	public Image[] levels;
	int i;
	[SerializeField]
	int savingLevel;
	void Start ()
	{
		//PlayerPrefs.DeleteAll();
		savingLevel = PlayerPrefs.GetInt ("UnlockingLvls");
		if (savingLevel != null && savingLevel < levels.Length) {
			levels [savingLevel].enabled = true;
			for (i=savingLevel; i != 0; i--) {
				levels [i].enabled = true;
			}

		}

	}
}
