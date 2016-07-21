using UnityEngine;
using System.Collections;

public class PetLogic : MonoBehaviour {
	GameObject player;
	public float petSpeed;

	void Start(){
		player = GameObject.Find("Player");
	}
	
	void Update () {
		gameObject.transform.position = Vector3.Lerp(transform.position,player.transform.position,petSpeed);
	}
}
