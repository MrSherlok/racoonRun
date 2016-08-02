using UnityEngine;
using System.Collections;

public class MoonWalk : DefSpellParent {

	private ScrollingScript playerSpeed;
	float moonWalk = 40f;
	private bool _isRunning = false;
	public static bool IsMoonWalkActive = false;


	void Start() {

		//COUNT
		defCount [0] = 1.5f;
		defCount [1] = 3f;
		defCount [2] = 5f;

		//RESTORE TIME
		defRestoreTime[0] = 1.2f;
		defRestoreTime[1] = 1.0f;
		defRestoreTime[2] = 0.7f;

		//RESTORE SPEED
		defRestoreSpeed[0] = 5f;
		defRestoreSpeed[1] = 3f;
		defRestoreSpeed[2] = 2f;

		//SPESIAL
		defSpecial[0] = 40f;
		defSpecial[1] = 80f;
		defSpecial[2] = 100f;


		timeTo = defCount[PlayerPrefs.GetInt("MoonWalkCountLvl")];
		activeTime = defRestoreTime[PlayerPrefs.GetInt("MoonWalkRestoreTimeLvl")];
		restoreSpeed = defRestoreSpeed[PlayerPrefs.GetInt("MoonWalkSpeedLvl")];
		moonWalk = defSpecial[PlayerPrefs.GetInt("MoonWalkSpecialLvl")];


		onCooldown = true;
		cooldownTimer = 0f;
		count = timeTo;


		IsMoonWalkActive = false;
		playerSpeed = GameObject.Find("Earth").GetComponent<ScrollingScript>();
		playerSpeed.direction.x = 1f;
	}

	void Update() {
		CountIndication ();
		if (_isRunning && count >= 0) {
			onCooldown = false;
			IsMoonWalkActive = true;
			count -= Time.deltaTime;
			playerSpeed.speed = new Vector2 (moonWalk, 0f);
		} else {
			IsMoonWalkActive = false;
			playerSpeed.speed = new Vector2 (0f, 0f);
			onCooldown = true;
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
				_isRunning = true;
			} else {
				_isRunning = false;
			}
		}
	}
}
