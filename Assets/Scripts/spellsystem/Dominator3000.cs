using UnityEngine;
using System.Collections;

public class Dominator3000 : DefSpellParent {

	public GameObject DominatorCircle;

	public static bool IsDominatorActive = false;

	private bool _isDominatorActive = false;

	void Start() {

		//COUNT
		defCount [0] = 3;
		defCount [1] = 5;
		defCount [2] = 6;

		//RESTORE TIME
		defRestoreTime[0] = 1.2f;
		defRestoreTime[1] = 1.0f;
		defRestoreTime[2] = 0.7f;

		//RESTORE SPEED
		defRestoreSpeed[0] = 5f;
		defRestoreSpeed[1] = 3f;
		defRestoreSpeed[2] = 2f;

		//SPESIAL
//		defSpecial[0] = 0.7f;
//		defSpecial[1] = 0.9f;
//		defSpecial[2] = 1.2f;


		timeTo = defCount[PlayerPrefs.GetInt("Dominator3000CountLvl")];
		activeTime = defRestoreTime[PlayerPrefs.GetInt("Dominator3000RestoreTimeLvl")];
		restoreSpeed = defRestoreSpeed[PlayerPrefs.GetInt("Dominator3000RestoreSpeedLvl")];
//		FlyingForse = defSpecial[PlayerPrefs.GetInt("SodaSpecialLvl")];

		onCooldown = true;
		cooldownTimer = 0f;
		count = timeTo;

		CountCorection ();

		DominatorCircle.SetActive (false);

		IsDominatorActive = false;
	}

	void Update () {
		CountIndication ();
		if (_isDominatorActive && count >= 0) {
			onCooldown = false;
			IsDominatorActive = true;
			count -= Time.deltaTime;
			DominatorCircle.SetActive (true);
		} else {
			IsDominatorActive = false;
			onCooldown = true;
			DominatorCircle.SetActive (false);
		}

		if (onCooldown)
			cooldownTimer += Time.deltaTime;
		else
			cooldownTimer = 0;
		if ((cooldownTimer >= activeTime) && (count <= timeTo)) {			
			count += Time.deltaTime/restoreSpeed;
		}
	}

	public override void OnClickDef (bool isPressed)
	{
		if (PauseScript.isPause) {
			if (isPressed) {
				_isDominatorActive = true;
			} else {
				_isDominatorActive = false;
			}
		}
	}
}
