using UnityEngine;
using System.Collections;

public class BamBlade : DamSpellParent {

	public GameObject bamBladeIm;



	void Start() {
		//COUNT
		damCount [0] = 3;
		damCount [1] = 5;
		damCount [2] = 6;


		maxCount = damCount[PlayerPrefs.GetInt("BamBladeCountLvl")];


		count = maxCount;

		bamBladeIm.SetActive (true);
	}


	public override void OnClick ()
	{
		if (PauseScript.isPause && (count > 1)) {
			bamBladeIm.GetComponent<Collider2D> ().enabled = true;
			count--;
			//animator.SetBool ("bamBladeMili", true);
			animator.SetTrigger("Fire2");
			Invoke ("StopBamBlade", 0.5f);
		}

		if (PauseScript.isPause && (count == 1)) {
			bamBladeIm.GetComponent<Collider2D> ().enabled = true;
			bamBladeIm.transform.SetParent (null);
			bamBladeIm.GetComponent<ScrollingScript> ().enabled = true;
			count--;
			//animator.SetBool ("bamBladeRange", true);
			//animator.SetBool("Run", false);
			animator.SetTrigger("Fire2");
			Invoke ("StopRange",1.5f);
		}

	}


	void StopBamBlade()
	{
		bamBladeIm.GetComponent<Collider2D>().enabled = false;
		//animator.SetBool("bamBladeMili", false);
		//animator.SetBool("bamBladeRange", false);
		//animator.SetBool("Run", true);
	}


	void StopRange() {
		bamBladeIm.SetActive(false);
	}
}
