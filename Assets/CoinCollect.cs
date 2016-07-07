using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CoinCollect : MonoBehaviour {
	static Text score;
	public static int coins;
	void Start(){
		score = GameObject.Find ("CoinsScore").GetComponent<Text> ();
	}
	public static void AddCoin () {
		coins++;
		score.text = (coins.ToString());

	}

}
