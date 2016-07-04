using UnityEngine;
using System.Collections;

public class SodaPack : DefSpellParent {


	private ParticleSystem SodaFXParts;
	private ParticleSystem FireFXParts;

	public static float FlyingForse = 0.7f;
	//public float timeToFly = 2f;
	private bool _isFlying = false;
	public static bool IsFlying = false;
	Rigidbody2D playerRigidbody;


	void Start() {
		timeTo = 2f;

		onCooldown = true;
		activeTime = 3f;
		cooldownTimer = 0f;
		count = timeTo;
		restoreSpeed = 5;


		IsFlying = false;
		playerRigidbody = GameObject.FindWithTag ("Player").GetComponent<Rigidbody2D> ();

		ParticleSystem FireFXParts = GameObject.Find ("InpuctFireFx").GetComponent<ParticleSystem> ();
		ParticleSystem SodaFXParts = GameObject.Find ("SodaFX").GetComponent<ParticleSystem> ();
		SodaFXParts.enableEmission = false;
		FireFXParts.enableEmission = false;
		GameObject.Find ("Soda").SetActive (true);
	}

	void Update () {
		if (_isFlying && count >= 0) {
			onCooldown = false;
			IsFlying = true;
			count -= Time.deltaTime;
			playerRigidbody.velocity += FlyingForse * Vector2.up;
		} else {
			IsFlying = false;
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
				_isFlying = true;
//				SodaFXParts.enableEmission = true;
//				FireFXParts.enableEmission = true;
				playerRigidbody.gravityScale = 2f;
			} else {
				_isFlying = false;
//				SodaFXParts.enableEmission = false;
//				FireFXParts.enableEmission = false;
				playerRigidbody.gravityScale = 6f;
			}
			

		}
	}
}
