using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collect : MonoBehaviour {

	public Text txt;

	// Update is called once per frame
	void Update () {
		txt.text = PlayerPrefs.GetInt("FirstItem").ToString();
	}
}
