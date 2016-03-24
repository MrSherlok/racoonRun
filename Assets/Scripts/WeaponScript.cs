using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public GameObject weaponBananaGun;
    public Transform cookieRangPrefab;
    public Transform bananaGunPrefab;
	public Transform shotPrefab;
	public float shootingRate = 0.25f;
	public float shootCooldown;
	public Animator animator;
	
    void Start ()
    {
        if (gameObject.tag == "Player")
        {
            if (ChooseSPScript.chooseBananaGunEnable == true)
            {
                shotPrefab = bananaGunPrefab;
                weaponBananaGun.GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                weaponBananaGun.GetComponent<SpriteRenderer>().enabled = false;
            }
            if (ChooseSPScript.chooseCookieRangEnable == true) shotPrefab = cookieRangPrefab;
        }
    }

	void FixedUpdate()
	{
		if (shootCooldown > 0)
		{
			shootCooldown -= Time.deltaTime;
		}
	}

	public void Attack(bool isEnemy)
	{
		if (CanAttack)
		{	
			if(gameObject.tag == "Player")
			animator.SetTrigger ("Fire");
			shootCooldown = shootingRate;
			// Create a new shot
			var shotTransform = Instantiate(shotPrefab) as Transform;

			shotTransform.position = transform.position;
			
			// The is enemy property
	//		ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
	//		if (shot != null)
	//		{
	//			shot.isEnemyShot = isEnemy;
	//		}
			// Make the weapon shot always towards it
			MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
			if (move != null)
			{
				move.direction = this.transform.right; // towards in 2D space is the right of the sprite
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