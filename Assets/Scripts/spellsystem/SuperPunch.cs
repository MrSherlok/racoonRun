using UnityEngine;
using System.Collections;

public class SuperPunch : DamSpellParent {

	public static bool IsSuperPunchActive = false; 
	public GameObject superPunchIm;
	public GameObject superPunchIm1;
	private Animator animator;

	void Start() {
		damage = 1;
		maxCount = 3;
		activeTime = 0.5f;
		timer = 0f;

		count = maxCount;

		nonCooldown = true;
		IsSuperPunchActive = false;
		animator = GameObject.Find("Player1").GetComponent<Animator> ();
		superPunchIm.GetComponent<SpriteRenderer>().enabled = true;
	}


	void Update() {
		if (nonCooldown)
			timer += Time.deltaTime;
		else
			timer = 0;
		if (timer >= activeTime && count < maxCount) {
			timer = 0f;
			count++;
		}

	}

	public override void OnClick ()
	{
		if (PauseScript.isPause && nonCooldown && (count>0)) {

			nonCooldown = false;
			count--;
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
