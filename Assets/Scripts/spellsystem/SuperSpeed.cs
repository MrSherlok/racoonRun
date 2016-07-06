﻿using UnityEngine;
using System.Collections;

public class SuperSpeed : DefSpellParent {

	private ScrollingScript playerSpeed;
	float SpeedSuper = 40f;
	private bool _isRunning = false;
	public static bool IsRunning = false;


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
		defRestoreTime[0] = 5f;
		defRestoreTime[1] = 3f;
		defRestoreTime[2] = 2f;

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


		IsRunning = false;
		playerSpeed = GameObject.Find("2-Foreground").GetComponent<ScrollingScript>();
	}

	void Update() {
		if (_isRunning && timeTo >= 0) {
			onCooldown = false;
			IsRunning = true;
			timeTo -= Time.deltaTime;
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
