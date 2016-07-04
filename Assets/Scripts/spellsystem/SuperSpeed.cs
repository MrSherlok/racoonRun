using UnityEngine;
using System.Collections;

public class SuperSpeed : DefSpellParent {

	private ScrollingScript playerSpeed;
	public static float SpeedSuper = 40f;
	private bool _isRunning = false;
	public static bool IsRunning = false;


	void Start() {
		timeTo = 2f;

		onCooldown = true;
		activeTime = 3f;
		cooldownTimer = 0f;
		count = timeTo;
		restoreSpeed = 5;


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
