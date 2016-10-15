using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearDead : MonoBehaviour {
    
    void Update()
    {
        if(this.GetComponent<EnemyHealthScript>().hp <= 0)
        {
            Time.timeScale = 1;
            Time.fixedDeltaTime = Time.timeScale * 0.02f;
        }
    }
}
