using UnityEngine;
using System.Collections;

public class GoldScript : MonoBehaviour {

	public static int Gold;

	void Start () {
		Gold = PlayerPrefs.GetInt ("Gold");
	}
}
