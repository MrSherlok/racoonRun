using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeScript : MonoBehaviour {

	float[] SodaUpgrade = new float[4];
	float[] SuperSpeedUpgrade = new float[4];
	float[] SuperJumpUpgrade = new float[4];

	private int _sodaLvl = 0;
	private int _speedLvl = 0;
	private int _jumpLvl = 0;

	int[] sodaNeedGold = new int[3];
	int[] speedNeedGold = new int[3];
	int[] jumpNeedGold = new int[3];

	public Text soda;
	public Text speed;
	public Text jump;
	public Text gold;

	bool wasChange = false;

	void Start() {
		SodaUpgrade[0] = 0.7f;
		SodaUpgrade[1] = 0.9f;
		SodaUpgrade[2] = 1.2f;
		SodaUpgrade[3] = 1.5f;

		sodaNeedGold [0] = 5;
		sodaNeedGold [1] = 10;
		sodaNeedGold [2] = 25;


		SuperSpeedUpgrade [0] = 40f;
		SuperSpeedUpgrade [1] = 60f;
		SuperSpeedUpgrade [2] = 80f;
		SuperSpeedUpgrade [3] = 100f;

		speedNeedGold [0] = 5;
		speedNeedGold [1] = 10;
		speedNeedGold [2] = 25;


		SuperJumpUpgrade [0] = 30f;
		SuperJumpUpgrade [1] = 40f;
		SuperJumpUpgrade [2] = 50f;
		SuperJumpUpgrade [3] = 55f;

		jumpNeedGold [0] = 5;
		jumpNeedGold [1] = 10;
		jumpNeedGold [2] = 25;


		_sodaLvl = PlayerPrefs.GetInt("SodaLvl");
		_speedLvl = PlayerPrefs.GetInt ("SpeedLvl");
		_jumpLvl = PlayerPrefs.GetInt ("JumpLvl");

		wasChange = true;
	}

	public void SodaFUpgrade(){
		if (_sodaLvl <= 2) {
			if (GoldScript.Gold >= sodaNeedGold [_sodaLvl]) {
				GoldScript.Gold -= sodaNeedGold [_sodaLvl];
				_sodaLvl++;
				wasChange = true;
				PlayerPrefs.SetInt ("SodaLvl", _sodaLvl);
			}
		}
	}

	public void SpeedFUpgrade(){
		if (_speedLvl <= 2) {
			if (GoldScript.Gold >= speedNeedGold [_speedLvl]) {
				GoldScript.Gold -= speedNeedGold [_speedLvl];
				_speedLvl++;
				wasChange = true;
				PlayerPrefs.SetInt ("SpeedLvl", _speedLvl);
			}
		}
	}

	public void JumpFUpgrade(){
		if (_jumpLvl <= 2) {
			if (GoldScript.Gold >= jumpNeedGold [_jumpLvl]) {
				GoldScript.Gold -= jumpNeedGold [_jumpLvl];
				_jumpLvl++;
				wasChange = true;
				PlayerPrefs.SetInt ("JumpLvl", _jumpLvl);
			}
		}
	}


	void FixedUpdate() {
		if (wasChange) {
//			SuperPower.FlyingForse = SodaUpgrade [_sodaLvl];
//			SuperPower.SpeedSuper = SuperSpeedUpgrade [_speedLvl];
//			SuperPower.ForceSuperJump = SuperJumpUpgrade [_jumpLvl];
			PlayerPrefs.SetInt ("Gold", GoldScript.Gold);
			wasChange = false;
		}
//		soda.text = SuperPower.FlyingForse.ToString ();
//		speed.text = SuperPower.ForceSuperJump.ToString ();
//		jump.text = SuperPower.SpeedSuper.ToString ();
		gold.text = GoldScript.Gold.ToString ();
	}








/*	public static int FlyingForse = 1;
	public static float SpeedSuper = 100f;
	public static float ForceSuperJump = 45f;
*/
}
