using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	private bool hasSpawn;
	private WeaponScript[] weapons;

	bool isSuperPunchActive; //= GameObject.FindWithTag ("Player").GetComponent<SuperPower> ().superSpeedEnable;
	void Awake()
	{
		// Retrieve the weapon only once
		weapons = GetComponentsInChildren<WeaponScript>();

	}
	

	void Start()
	{
		hasSpawn = false;

		// -- Shooting
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = false;
		}
	}
	
	void FixedUpdate()
	{
		// 2 - Check if the enemy has spawned.
		if (hasSpawn == false)
		{
			if (GetComponent<Renderer>().IsVisibleFrom(Camera.main))
			{
				Spawn();
			}
		}
		else
		{
			// Auto-fire
			foreach (WeaponScript weapon in weapons)
			{
				if (weapon != null && weapon.enabled && weapon.CanAttack)
				{
					weapon.Attack(true);
				}
			}
			
			// 4 - Out of the camera ? Destroy the game object.
			if (GetComponent<Renderer>().IsVisibleFrom(Camera.main) == false)
			{
				Destroy(gameObject,5f);
			}  
		}
	}
	

	private void Spawn()
	{
		hasSpawn = true;

		// -- Shooting
		foreach (WeaponScript weapon in weapons)
		{
			weapon.enabled = true;
		}
	}
}