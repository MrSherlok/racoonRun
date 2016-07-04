using UnityEngine;
using System.Collections;

public class CookieRang : DamSpellParent {

	GameObject[] cookieRangs= new GameObject[6];
	int i = 0;
	void Start(){
		damage = 1;
		cooldown = 0.6f;
		count = 3;
		activeTime = 1.5f;
		timer = 0f;


		nonCooldown = true;
		shotPrefab = Resources.Load("CookieRang") as GameObject;
		cookieRangs[0] = Instantiate (shotPrefab);
		cookieRangs[1] = Instantiate (shotPrefab);
		cookieRangs[2] = Instantiate (shotPrefab);
		cookieRangs[3] = Instantiate (shotPrefab);
		cookieRangs[4] = Instantiate (shotPrefab);
		cookieRangs[5] = Instantiate (shotPrefab);
		shoot = cookieRangs [0];
	}

	void Update() {
		if (nonCooldown)
			timer += Time.deltaTime;
		else
			timer = 0;
		if (timer >= activeTime) {
			timer = 0f;
			count++;
		}

	}


	public override void OnClick ()
	{
		if (nonCooldown && (count>0)) {
			nonCooldown = false;
			count--;
			//animator.SetTrigger ("Fire");
			shoot.SetActive(true);
			shoot.transform.position = transform.position;
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
