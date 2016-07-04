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
		IsFlying = false;
		playerRigidbody = GameObject.FindWithTag ("Player").GetComponent<Rigidbody2D> ();
		timeTo = 2f;
		ParticleSystem FireFXParts = GameObject.Find ("InpuctFireFx").GetComponent<ParticleSystem> ();
		ParticleSystem SodaFXParts = GameObject.Find ("SodaFX").GetComponent<ParticleSystem> ();
		SodaFXParts.enableEmission = false;
		FireFXParts.enableEmission = false;
		GameObject.Find ("Soda").SetActive (true);
	}

	void Update () {
		if (_isFlying && timeTo >= 0) {
			IsFlying = true;
			timeTo -= Time.deltaTime;
			playerRigidbody.velocity += FlyingForse * Vector2.up;
		} else {
			IsFlying = false;
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
