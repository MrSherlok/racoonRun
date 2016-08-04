using UnityEngine;
using System.Collections;

public class SuperSpeed : DefSpellParent {

	private ScrollingScript playerSpeed;
	float SpeedSuper = 40f;
	private bool _isRunning = false;
	public static bool IsRunning = false;


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


		timeTo = defCount[PlayerPrefs.GetInt("SuperSpeedCountLvl")];
		activeTime = defRestoreTime[PlayerPrefs.GetInt("SuperSpeedRestoreTimeLvl")];
		restoreSpeed = defRestoreSpeed[PlayerPrefs.GetInt("SuperSpeedSpeedLvl")];
		SpeedSuper = defSpecial[PlayerPrefs.GetInt("SuperSpeedSpecialLvl")];


		onCooldown = true;
		cooldownTimer = 0f;
		count = timeTo;

		CountCorection ();


		IsRunning = false;
		playerSpeed = GameObject.Find("Earth").GetComponent<ScrollingScript>();
		playerSpeed.direction.x = -1f;
	}

	void Update() {
		CountIndication ();
		if (_isRunning && count >= 0) {
			onCooldown = false;
			IsRunning = true;
			count -= Time.deltaTime;
			playerSpeed.speed = new Vector2 (SpeedSuper, 0f);
		} else {
			IsRunning = false;
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
