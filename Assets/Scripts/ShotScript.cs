using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
	[SerializeField]
	private float lifeTime;
	private float removeTime = 0;
	public int damage = 1;
	public bool isEnemyShot = false;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}
	
	// Update is called once per frame
	void Update () {
		removeTime += Time.deltaTime;
		if (removeTime >= lifeTime) {
            if (gameObject.tag != "Enemy")
            {
                Destroy(gameObject);
            }
		}
	}
}
