using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimAndPause : MonoBehaviour {
	public Animator ani;

	void Update () {
		if (Input.GetKey ("up")) {
			Debug.Log ("Ok , im work");
			ani.SetTrigger("Taunt01");
			StartCoroutine ("WaitForAnimationEnd",ani);
		}
	}
	private IEnumerator WaitForAnimationEnd(Animator anim) 
	{   
		if (Time.timeScale >= 1f) {
			Time.timeScale = 0.1f;
		}
		
		do 
		{ 
			yield return null; 
			Debug.Log(anim.GetCurrentAnimatorStateInfo(0).normalizedTime);
		} while (anim.gameObject.activeInHierarchy&& anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 0.6f); 

		Time.timeScale = 1f;
		Debug.Log ("AnimWasEnd");
		} 
}
