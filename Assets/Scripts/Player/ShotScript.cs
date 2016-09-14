﻿using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
	public float lifeTime;
	private float removeTime = 0;
	public int damage = 1;
	int[] damDamage = new int[3];
	int[] cookieDamage = new int[3];


//	public bool isEnemyShot = false;

	void Start(){
		damDamage[0] = 1;
		damDamage[1] = 3;
		damDamage[2] = 5;

		cookieDamage[0] = 2;
		cookieDamage[1] = 6;
		cookieDamage[2] = 10;

		if(ChooseSPScript.ActiveDamSpel == 0) damage = damDamage[PlayerPrefs.GetInt("BananaDamageLvl")];
		if(ChooseSPScript.ActiveDamSpel == 1) damage = damDamage[PlayerPrefs.GetInt("PunchDamageLvl")];
		if(ChooseSPScript.ActiveDamSpel == 2) damage = cookieDamage[PlayerPrefs.GetInt("CookieDamageLvl")];
		if(ChooseSPScript.ActiveDamSpel == 3) damage = damDamage[PlayerPrefs.GetInt("BamBladeDamageLvl")];
	}

	void OnEnable() {
		removeTime = 0f;
	}

	void FixedUpdate ()
	{
        
        if (gameObject.tag == "bananaGun" || gameObject.tag == "slamon") {
			removeTime += Time.deltaTime;
			if (removeTime >= lifeTime) {
				gameObject.SetActive (false);
			}
		}
	}
}
