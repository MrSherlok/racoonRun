using UnityEngine;
using System.Collections;

public class CookieRang : SpellParent {

	GameObject[] cookieRangs= new GameObject[6];
	int i = 0;
	void Start(){
		nonCooldown = true;
		damage = 1;
		cooldown = 1f;
		shotPrefab = Resources.Load("CookieRang");
		cookieRangs[0] = Instantiate (shotPrefab)as GameObject;
		cookieRangs[1] = Instantiate (shotPrefab)as GameObject;
		cookieRangs[2] = Instantiate (shotPrefab)as GameObject;
		cookieRangs[3] = Instantiate (shotPrefab)as GameObject;
		cookieRangs[4] = Instantiate (shotPrefab)as GameObject;
		cookieRangs[5] = Instantiate (shotPrefab)as GameObject;
		shoot = cookieRangs [0];


	}
	public override void OnClick ()
	{
		if (nonCooldown) {
			nonCooldown = false;
			//animator.SetTrigger ("Fire");
			shoot.transform.position = transform.position;
			shoot.GetComponentInChildren<ShotScript> ().enabled = true;
			Invoke ("Coldown", cooldown);
			//	StartCoroutine ("Coldown");
		}
	}


	void Coldown(){
		i++;
		if(i == 6) i = 0;
		shoot = cookieRangs[i];
		nonCooldown = true;
	}
}
