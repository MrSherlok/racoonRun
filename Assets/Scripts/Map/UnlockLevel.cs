using UnityEngine;
using System.Collections;

public class UnlockLevel : MonoBehaviour {
    [SerializeField]
    GameObject[] levels;
    [SerializeField]
    GameObject lvlTargetImage;
	int i;
	[SerializeField]
	int savingLevel;
	void Start ()
	{
		//PlayerPrefs.DeleteAll();
		savingLevel = PlayerPrefs.GetInt ("UnlockingLvls");
		if (savingLevel != null && savingLevel < levels.Length) {
			levels [savingLevel].SetActive(true);
			for (i=0; i <= savingLevel; i++) {
				levels [i].SetActive(true);
				lvlTargetImage.transform.position = levels [i].transform.position;
			}

		}

	}
}
