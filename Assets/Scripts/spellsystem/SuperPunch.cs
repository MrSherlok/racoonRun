using UnityEngine;

public class SuperPunch : DamSpellParent {

//	public static bool IsSuperPunchActive = false; 
[SerializeField]
	GameObject superPunchIm;
    [SerializeField]
    GameObject superPunchIm1;
	//private Animator animator;

	void Start() {
		//COUNT
		damCount [0] = 5;
		damCount [1] = 7;
		damCount [2] = 9;

		//RESTORE TIME
		damRestoreTime[0] = 1.2f;
		damRestoreTime[1] = 1.0f;
		damRestoreTime[2] = 0.7f;



		maxCount = damCount[PlayerPrefs.GetInt("PunchCountLvl")];
		activeTime = damRestoreTime[PlayerPrefs.GetInt("PunchRestoreTimeLvl")];
		timer = 0f;

		count = maxCount;

		nonCooldown = true;
		//animator = GameObject.Find("Player1").GetComponent<Animator> ();
		superPunchIm.SetActive (true);
	}


	void Update() {
		if (nonCooldown)
			timer += Time.deltaTime;
		else
			timer = 0;
		if (timer >= activeTime && count < maxCount) {
			timer = 0f;
			count++;
			CountIndication ();
		}

	}

	public override void OnClick ()
	{
		if (PauseScript.isPause && nonCooldown && (count>0)) {

			nonCooldown = false;
			count--;
			CountIndication();
			superPunchIm1.GetComponent<Renderer> ().enabled = true;
			superPunchIm.GetComponent<Collider2D> ().enabled = true;
			HealthScript.Invulnerability = true;
			animator.SetBool ("superPunch", true);
			animator.SetBool ("Run", false);
			Invoke ("StopPunch", 0.25f);
		}
	}

	void StopPunch()
	{
		nonCooldown = true;
		superPunchIm1.GetComponent<Renderer> ().enabled = false;
		superPunchIm.GetComponent<Collider2D>().enabled = false;
		HealthScript.Invulnerability = false;
		animator.SetBool("superPunch", false);
		animator.SetBool("Run", true);
	}


}
