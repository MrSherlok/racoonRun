using UnityEngine;
using System.Collections;

public class SuperJump : DefSpellParent {

	public static bool superJumpEnabled = false;
	public static float ForceSuperJump = 30f;
	public bool IsGrounded = false; 
	bool cloudTuch = false;
	Rigidbody2D playerRigidbody;

	void Start() {
		//restoreSpeed here as max counts
		restoreSpeed = 3;
		activeTime = 3f;
		timeTo = 0f;

		count = restoreSpeed;


		playerRigidbody = GameObject.FindWithTag ("Player").GetComponent<Rigidbody2D> ();
		superJumpEnabled = false;
	}


	public void FixedUpdate () {
		if (Player.isCloudfootTouch || Player.isCloudHeadTouch) {
			cloudTuch = true;
		} else {
			cloudTuch = false;
		}
		IsGrounded = Player.IsGrounded;

		if (onCooldown)
			timeTo += Time.deltaTime;
		else
			timeTo = 0;
		if (timeTo >= activeTime && count < restoreSpeed) {
			timeTo = 0f;
			count++;
		}

	}

	public override void OnClickDef (bool isPressed)
	{
		if (PauseScript.isPause) {
			if (IsGrounded || cloudTuch && (count > 0)) {
				count--;
				onCooldown = false;
				playerRigidbody.gravityScale = 4f;
				playerRigidbody.velocity += ForceSuperJump * Vector2.up;
				superJumpEnabled = true;
				Invoke ("StopSuperJump", 0.1f);
			}
		}
	}

	void StopSuperJump()
	{
		playerRigidbody.gravityScale = 6f;
		superJumpEnabled = false;
		onCooldown = true;
	}
}
