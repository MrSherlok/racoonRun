using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	int i = 0;
	public GameObject[] bullets = new GameObject[4];
	void Start () {
		Shoot();
	}
	
	// Update is called once per frame
	void Shoot () {
		bullets [i].SetActive (true);
		Invoke ("Reload",1f);
	}
	void Reload(){
		if (i == 3) {
			i = 0;
		} else {
			i++;
		}
		Invoke ("Shoot",1f);
	}
}
