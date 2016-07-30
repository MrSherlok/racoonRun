using UnityEngine;
using System.Collections;

public class SuperPunch : DamSpellParent {

	public static bool IsSuperPunchActive = false; 
	public GameObject superPunchIm;
	public GameObject superPunchIm1;
	//private Animator animator;

	void Start() {
		//COUNT
		damCount [0] = 3;
		damCount [1] = 5;
		damCount [2] = 6;

		//RESTORE TIME
		damRestoreTime[0] = 1.2f;
		damRestoreTime[1] = 1.0f;
		damRestoreTime[2] = 0.7f;



		maxCount = damCount[PlayerPrefs.GetInt("PunchCountLvl")];
		activeTime = damRestoreTime[PlayerPrefs.GetInt("PunchRestoreTimeLvl")];
		timer = 0f;

		count = maxCount;

		nonCooldown = true;
		IsSuperPunchActive = false;
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
			IsSuperPunchActive = true;
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
		IsSuperPunchActive = false;
		animator.SetBool("superPunch", false);
		animator.SetBool("Run", true);
	}


}
