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




	//BANANA
	int[] bananaCount = new int[3];
	float[] bananaRestoreTime = new float[3];
	int[] bananaDamage = new int[3];

	int[] bananaCountNeedGold = new int[2];
	int[] bananaRestoreTimeNeedGold = new int[2];
	int[] bananaDamageNeedGold = new int[2];

	private int _bananaCountLvl = 0;
	private int _bananaRestoreTimeLvl = 0;
	private int _bananaDamageLvl = 0;


	//COOKIE
	int[] cookieCount = new int[3];
	float[] cookieRestoreTime = new float[3];
	int[] cookieDamage = new int[3];

	int[] cookieCountNeedGold = new int[2];
	int[] cookieRestoreTimeNeedGold = new int[2];
	int[] cookieDamageNeedGold = new int[2];

	private int _cookieCountLvl = 0;
	private int _cookieRestoreTimeLvl = 0;
	private int _cookieDamageLvl = 0;


	//PUNCH
	int[] punchCount = new int[3];
	float[] punchRestoreTime = new float[3];
	int[] punchDamage = new int[3];
	float[] punchRange = new float[4];

	int[] punchCountNeedGold = new int[2];
	int[] punchRestoreTimeNeedGold = new int[2];
	int[] punchDamageNeedGold = new int[2];
	int[] punchRangeNeedGold = new int[3];

	private int _punchCountLvl = 0;
	private int _punchRestoreTimeLvl = 0;
	private int _punchDamageLvl = 0;
	private int _punchRangeLvl = 0;




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


		//BANANA
			//COUNT
		bananaCount [0] = 3;
		bananaCount [1] = 5;
		bananaCount [2] = 6;

		bananaCountNeedGold [0] = 10;
		bananaCountNeedGold [1] = 20;

			//RESTORE TIME
		bananaRestoreTime[0] = 1.2f;
		bananaRestoreTime[1] = 1.0f;
		bananaRestoreTime[2] = 0.7f;

		bananaRestoreTimeNeedGold [0] = 20;
		bananaRestoreTimeNeedGold [1] = 40;

			//DAMAGE
		bananaDamage[0] = 1;
		bananaDamage[1] = 3;
		bananaDamage[2] = 5;

		bananaDamageNeedGold [0] = 15;
		bananaDamageNeedGold [1] = 30;


		//COOKIE
			//COUNT
		cookieCount[0] = 3;
		cookieCount[1] = 5;
		cookieCount[2] = 6;

		cookieCountNeedGold [0] = 10;
		cookieCountNeedGold [1] = 20;

			//RESTORE TIME
		cookieRestoreTime[0] = 1.5f;
		cookieRestoreTime[1] = 1.1f;
		cookieRestoreTime[2] = 0.7f;

		cookieRestoreTimeNeedGold [0] = 15;
		cookieRestoreTimeNeedGold [1] = 25;

			//DAMAGE
		cookieDamage[0] = 1;
		cookieDamage[1] = 3;
		cookieDamage[2] = 5;

		cookieDamageNeedGold [0] = 15;
		cookieDamageNeedGold [1] = 30;


		//PUNCH
			//COUNT
		punchCount[0] = 3;
		punchCount[1] = 5;
		punchCount[2] = 6;

		punchCountNeedGold [0] = 15;
		punchCountNeedGold [0] = 25;

			//RESTORE TIME
		punchRestoreTime[0] = 1f;
		punchRestoreTime[1] = 0.7f;
		punchRestoreTime[2] = 0.5f;

		punchRestoreTimeNeedGold [0] = 15;
		punchRestoreTimeNeedGold [1] = 30;

			//DAMAGE
		punchDamage[0] = 1;
		punchDamage[1] = 3;
		punchDamage[2] = 5;

		punchDamageNeedGold [0] = 15;
		punchDamageNeedGold [1] = 30;

			//RANGE
		punchRange[0] = 10f;
		punchRange[1] = 15f;
		punchRange[2] = 20f;
		punchRange[3] = 25f;

		punchRangeNeedGold [0] = 15;
		punchRangeNeedGold [1] = 30;
		punchRangeNeedGold [2] = 45;


		//GET ALL PLAYER PREFS
			//BANANA
		_bananaCountLvl = PlayerPrefs.GetInt("BananaCountLvl");
		_bananaRestoreTimeLvl = PlayerPrefs.GetInt("BananaRestoreTimeLvl");
		_bananaDamageLvl = PlayerPrefs.GetInt("BananaDamageLvl");

			//COOKIE
		_cookieCountLvl = PlayerPrefs.GetInt("CookieCountLvl");
		_cookieRestoreTimeLvl = PlayerPrefs.GetInt("CookieRestoreTimeLvl");
		_cookieDamageLvl = PlayerPrefs.GetInt("CookieDamageLvl");

			//PUNCH
		_punchCountLvl = PlayerPrefs.GetInt("PunchCountLvl");
		_punchRestoreTimeLvl = PlayerPrefs.GetInt("PunchRestoreTimeLvl");
		_punchDamageLvl = PlayerPrefs.GetInt("PunchDamageLvl");
		_punchRangeLvl = PlayerPrefs.GetInt("PunchRangeLvl");




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
