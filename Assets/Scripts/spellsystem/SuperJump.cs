using UnityEngine;
using System.Collections;

public class SuperJump : DefSpellParent {

	public static bool superJumpEnabled = false;
	public static float ForceSuperJump = 30f;
	public bool IsGrounded = false; 
	bool cloudTuch = false;
	Rigidbody2D playerRigidbody;

	void Start() {
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
	}

	public override void OnClickDef (bool isPressed)
	{
		if (PauseScript.isPause) {
			if (IsGrounded || cloudTuch) {
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

	}
}
