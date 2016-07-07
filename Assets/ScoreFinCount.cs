using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreFinCount : MonoBehaviour {

	void Start () {
		gameObject.GetComponent<Text> ().text = "Your score = " + CoinCollect.coins.ToString();
	}
}
