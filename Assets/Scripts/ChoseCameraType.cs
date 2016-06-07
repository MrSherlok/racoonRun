using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChoseCameraType : MonoBehaviour {
	public int camPreset;
	// Use this for initialization
	void Start () {
		
		gameObject.GetComponent<Dropdown>().value = PlayerPrefs.GetInt ("CamTypeChose");
		camPreset = gameObject.GetComponent<Dropdown> ().value;
	}
	
	// Update is called once per frame
	void Update () {
		camPreset = gameObject.GetComponent<Dropdown>().value;
	}
}
