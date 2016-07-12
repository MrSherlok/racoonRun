using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoldUpdate : MonoBehaviour {

	public Text gold;

	void Update () {
		gold.text = GoldScript.Gold.ToString ();
	}
}
