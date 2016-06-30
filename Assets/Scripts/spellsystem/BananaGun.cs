using UnityEngine;
using System.Collections;

public class BananaGun : SpellParent {
//	public GameObject bananaGunPrefab;
	GameObject[] bananas= new GameObject[6];
	int i = 0;
	void Start(){
		nonCooldown = true;
		damage = 1;
		cooldown = 1f;
		shotPrefab = Resources.Load("banana");
		bananas[0] = Instantiate (shotPrefab)as GameObject;
		bananas[1] = Instantiate (shotPrefab)as GameObject;
		bananas[2] = Instantiate (shotPrefab)as GameObject;
		bananas[3] = Instantiate (shotPrefab)as GameObject;
		bananas[4] = Instantiate (shotPrefab)as GameObject;
		bananas[5] = Instantiate (shotPrefab)as GameObject;
		shoot = bananas [0];


	}
	public override void OnClick ()
	{
		Debug.Log ("Ipressed");
		if (nonCooldown) {
			nonCooldown = false;
			Debug.Log ("ISHOOOOT");
			//animator.SetTrigger ("Fire");
			shoot.transform.position = transform.position;
			shoot.GetComponent<ShotScript> ().enabled = true;
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

