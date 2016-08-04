using UnityEngine;
using System.Collections;

public class SuperJump : DefSpellParent {

	public static bool superJumpEnabled = false;
	float ForceSuperJump = 30f;
	bool cloudTuch = false;
	Rigidbody2D playerRigidbody;

	void Start() {

		//COUNT
		defCount [0] = 2f;
		defCount [1] = 3f;
		defCount [2] = 4f;

		//RESTORE TIME
		defRestoreTime[0] = 2f;
		defRestoreTime[1] = 1.5f;
		defRestoreTime[2] = 1f;

		//SPECIAL
		defSpecial[0] = 40f;
		defSpecial[1] = 40f;
		defSpecial[2] = 40f;


		//restoreSpeed here as max counts
		restoreSpeed = defCount[PlayerPrefs.GetInt("SuperJumpCountLvl")];
		activeTime = defRestoreTime[PlayerPrefs.GetInt("SuperJumpRestoreTimeLvl")];
		ForceSuperJump = defSpecial[PlayerPrefs.GetInt("SuperJumpSpecialLvl")];

		timeTo = 0f;
		count = restoreSpeed;

		CountCorection ();

		playerRigidbody = GameObject.Find("Player").GetComponent<Rigidbody2D> ();
		superJumpEnabled = false;
	}


	public void FixedUpdate () {

		if (onCooldown)
			timeTo += Time.deltaTime;
		else
			timeTo = 0;
		if (timeTo >= activeTime && count < restoreSpeed) {
			timeTo = 0f;
			count++;
			CountIndication ();
		}

	}

	public override void OnClickDef (bool isPressed)
	{
		if (PauseScript.isPause) {
			if ((count > 0)) {
				count--;
				CountIndication ();
				onCooldown = false;
	//			playerRigidbody.gravityScale = 6f;
				playerRigidbody.velocity += ForceSuperJump * Vector2.up;
				superJumpEnabled = true;
				Invoke ("StopSuperJump", 0.1f);
			}
		}
	}

	void StopSuperJump()
	{
//		playerRigidbody.gravityScale = 6f;
		superJumpEnabled = false;
		onCooldown = true;
	}

}
