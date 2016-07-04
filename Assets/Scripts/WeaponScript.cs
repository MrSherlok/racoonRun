using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public GameObject weaponBananaGun;
	GameObject shotPrefab;
	public float shootingRate = 0.25f;
	public float shootCooldown;
	public Animator animator;

	public GameObject cookieRangPrefab;
	public GameObject bananaGunPrefab;

	GameObject[] cookieRangs = new GameObject[6];
	GameObject[] bananas= new GameObject[6];

	bool wasShot = false;
	int i =0;
	
    void Start ()
    {
			if (ChooseSPScript.ActiveDamSpel == 0)
            {
				bananas[0] = Instantiate (bananaGunPrefab);
				bananas[1] = Instantiate (bananaGunPrefab);
				bananas[2] = Instantiate (bananaGunPrefab);
				bananas[3] = Instantiate (bananaGunPrefab);
				bananas[4] = Instantiate (bananaGunPrefab);
				bananas[5] = Instantiate (bananaGunPrefab);
                weaponBananaGun.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                weaponBananaGun.GetComponent<SpriteRenderer>().enabled = false;
            }
			if (ChooseSPScript.ActiveDamSpel == 2) {
				cookieRangs[0] = Instantiate (cookieRangPrefab);
				cookieRangs[1] = Instantiate (cookieRangPrefab);
				cookieRangs[2] = Instantiate (cookieRangPrefab);
				cookieRangs[3] = Instantiate (cookieRangPrefab);
				cookieRangs[4] = Instantiate (cookieRangPrefab);
				cookieRangs[5] = Instantiate (cookieRangPrefab);
			} 
        }

	void FixedUpdate()
	{
		if (shootCooldown > 0)
		{
			shootCooldown -= Time.deltaTime;
		}
		if (wasShot) {
			i++;
			if(i == 6) i = 0;
			wasShot = false;
		}
		if (ChooseSPScript.ActiveDamSpel == 0)
			{
				shotPrefab = bananas [i];
			}
			if (ChooseSPScript.ActiveDamSpel == 2) {
				shotPrefab = cookieRangs [i];
			} 
		}

	public void Attack(bool isEnemy)
	{
		if (PauseScript.isPause) {
			if (CanAttack) {	
				if (gameObject.tag == "Player") {
					animator.SetTrigger ("Fire");
					wasShot = true;
				}
				shootCooldown = shootingRate;
				// Create a new shot
				shotPrefab.transform.position = transform.position;
				if (gameObject.tag == "Player") {
					if (ChooseSPScript.ActiveDamSpel == 2)
						shotPrefab.SetActive(true);
					else
						shotPrefab.SetActive(true);
				} 
			}
		}
	}
	
	public bool CanAttack
	{
		get
		{
			return shootCooldown <= 0f;
		}
	}
}