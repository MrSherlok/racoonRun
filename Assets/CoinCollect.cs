using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CoinCollect : MonoBehaviour {
	static Text score;
	public static int coins;
	void Start(){
		score = GameObject.Find ("CoinsScore").GetComponent<Text> ();
	}
	public static void AddCoin(int coint) {
		for(int i = 0;i<coint;i++){
		coins++;
		}
		score.text = (coins.ToString());

	}

}
