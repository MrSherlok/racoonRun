using UnityEngine;

public class BananaGun : DamSpellParent {
//	public GameObject bananaGunPrefab;
	GameObject[] bananas= new GameObject[10];
	public GameObject gun;
	//private Animator animator;
	int i = 0;
	void Start(){
		
		//animator = GameObject.Find("Player1").GetComponent<Animator> ();
		//COUNT
		damCount [0] = 6;
		damCount [1] = 8;
		damCount [2] = 10;

		//RESTORE TIME
		damRestoreTime[0] = 1.2f;
		damRestoreTime[1] = 1.0f;
		damRestoreTime[2] = 0.7f;


		cooldown = 0.15f;
		maxCount = damCount[PlayerPrefs.GetInt("BananaCountLvl")];
		activeTime = damRestoreTime[PlayerPrefs.GetInt("BananaRestoreTimeLvl")];
		timer = 0f;

		count = maxCount;

		gun.SetActive(true);
		nonCooldown = true;
		shotPrefab = Resources.Load("banana") as GameObject;
		bananas[0] = Instantiate (shotPrefab);
		bananas[1] = Instantiate (shotPrefab);
		bananas[2] = Instantiate (shotPrefab);
		bananas[3] = Instantiate (shotPrefab);
		bananas[4] = Instantiate (shotPrefab);
		bananas[5] = Instantiate (shotPrefab);
        bananas[6] = Instantiate(shotPrefab);
        bananas[7] = Instantiate(shotPrefab);
        bananas[8] = Instantiate(shotPrefab);
        bananas[9] = Instantiate(shotPrefab);
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
			if(i == 9) i = 0;
			shoot = bananas[i];
			nonCooldown = true;
		}
	}

