using UnityEngine;
using System.Collections;

public class DeleteThisShit : MonoBehaviour {
	GameObject player;
	void Start () {
		player = GameObject.Find ("Player");
	}
	void Update () {
		gameObject.transform.position = Vector3.Lerp(transform.position,player.transform.position,0.01f);
	}
}
