using UnityEngine;
using System.Collections;

public class BananaGun : DamSpellParent {
//	public GameObject bananaGunPrefab;
	GameObject[] bananas= new GameObject[6];
	public GameObject gun;
	int i = 0;
	void Start(){
		damage = 1;
		cooldown = 0.3f;
		maxCount = 3;
		activeTime = 1.2f;
		timer = 0f;

		count = maxCount;

		gun.GetComponent<SpriteRenderer> ().enabled = true;
		nonCooldown = true;
		shotPrefab = Resources.Load("banana") as GameObject;
		bananas[0] = Instantiate (shotPrefab);
		bananas[1] = Instantiate (shotPrefab);
		bananas[2] = Instantiate (shotPrefab);
		bananas[3] = Instantiate (shotPrefab);
		bananas[4] = Instantiate (shotPrefab);
		bananas[5] = Instantiate (shotPrefab);
		shoot = bananas [0];
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
			shoot = bananas[i];
			nonCooldown = true;
		}
	}

