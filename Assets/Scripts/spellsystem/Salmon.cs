using UnityEngine;
using System.Collections;

public class Salmon : DamSpellParent {

	GameObject[] salmons= new GameObject[6];
	public GameObject gun;
	//private Animator animator;
	int i = 0;
	void Start(){

		//animator = GameObject.Find("Player1").GetComponent<Animator> ();
		//COUNT
		damCount [0] = 3;
		damCount [1] = 5;
		damCount [2] = 6;

		//RESTORE TIME
		damRestoreTime[0] = 1.2f;
		damRestoreTime[1] = 1.0f;
		damRestoreTime[2] = 0.7f;


		cooldown = 0.3f;
		maxCount = damCount[PlayerPrefs.GetInt("SalmonCountLvl")];
		activeTime = damRestoreTime[PlayerPrefs.GetInt("SalmonRestoreTimeLvl")];
		timer = 0f;

		count = maxCount;

		gun.SetActive(true);
		nonCooldown = true;
		shotPrefab = Resources.Load("salmon") as GameObject;
		salmons[0] = Instantiate (shotPrefab);
		salmons[1] = Instantiate (shotPrefab);
		salmons[2] = Instantiate (shotPrefab);
		salmons[3] = Instantiate (shotPrefab);
		salmons[4] = Instantiate (shotPrefab);
		salmons[5] = Instantiate (shotPrefab);
		shoot = salmons [0];

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
		if (nonCooldown && (count>0)) {
			nonCooldown = false;
			count--;
			CountIndication ();
			//animator.SetTrigger ("Fire");
			shoot.SetActive(true);
			shoot.transform.position = transform.position;
			animator.SetTrigger ("Fire");
			GameObject.Find ("AudioSystem").GetComponent<AudioManager> ().PlaySound ("bananagun");
			Invoke ("Coldown", cooldown);
			//	StartCoroutine ("Coldown");
		}
	}


	void Coldown(){
		i++;
		if(i == 6) i = 0;
		shoot = salmons[i];
		nonCooldown = true;
	}
}
