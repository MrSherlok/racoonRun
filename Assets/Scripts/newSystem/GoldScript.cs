using UnityEngine;
using System.Collections;

public class GoldScript : MonoBehaviour {

	public static int Gold = 1500;

	void Start () {
		Gold = PlayerPrefs.GetInt ("Gold");
	}
}
