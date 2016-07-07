using UnityEngine;
using System.Collections;

public class SodaPack : DefSpellParent {


	private ParticleSystem.EmissionModule SodaFXParts;
	private ParticleSystem.EmissionModule FireFXParts;
	public GameObject sodaPack;

	float FlyingForse = 0.7f;
	private bool _isFlying = false;
	public static bool IsFlying = false;
	Rigidbody2D playerRigidbody;


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
		defSpecial[0] = 0.7f;
		defSpecial[1] = 0.9f;
		defSpecial[2] = 1.2f;




		timeTo = defCount[PlayerPrefs.GetInt("SodaCountLvl")];
		activeTime = defRestoreTime[PlayerPrefs.GetInt("SodaRestoreTimeLvl")];
		restoreSpeed = defRestoreSpeed[PlayerPrefs.GetInt("SodaRestoreSpeedLvl")];
		FlyingForse = defSpecial[PlayerPrefs.GetInt("SodaSpecialLvl")];

		onCooldown = true;
		cooldownTimer = 0f;
		count = timeTo;

		sodaPack.SetActive (true);

		IsFlying = false;
		playerRigidbody = GameObject.FindWithTag ("Player").GetComponent<Rigidbody2D> ();

		FireFXParts = GameObject.Find ("InpuctFireFx").GetComponent<ParticleSystem> ().emission;
		SodaFXParts = GameObject.Find ("SodaFX").GetComponent<ParticleSystem> ().emission;
		SodaFXParts.enabled = false;
		FireFXParts.enabled = false;
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
				SodaFXParts.enabled = true;
				FireFXParts.enabled = true;
				playerRigidbody.gravityScale = 2f;
			} else {
				_isFlying = false;
				SodaFXParts.enabled = false;
				FireFXParts.enabled = false;
				playerRigidbody.gravityScale = 6f;
			}
			

		}
	}
}
