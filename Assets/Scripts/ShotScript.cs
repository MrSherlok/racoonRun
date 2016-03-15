using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
	public float lifeTime;
	private float removeTime = 0;
	public int damage = 1;
	public bool isEnemyShot = false;
	// Use this for initialization
	//void Start () {
	//	Destroy (gameObject, 20);
	//}
	
	// Update is called once per frame
	void FixedUpdate() {
		removeTime += Time.deltaTime;
		if (removeTime >= lifeTime) {

                if (isEnemyShot == false)
                {
                    Destroy(transform.parent.gameObject);

                }
                else
                    Destroy(gameObject);
            }
		}
}
