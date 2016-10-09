using UnityEngine;
using System.Collections;

public class TurtleLogic : MonoBehaviour {
	bool moving = false;
	GameObject player;
	int inputCount = 3;
	public GameObject parts;
	Animator ani;
	void Start(){
		ani = GetComponent<Animator>();
	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.name == "GroundPoint") {
			//Debug.Log ("TurtleOnWork");
			moving = true;
			player = col.gameObject;
			player.GetComponentInParent<Rigidbody2D>().velocity += 45* Vector2.up;
			ani.SetTrigger("Run");
			inputCount--;
			//ТУТ НЕУЯЗВИМОСТЬ НА 0.5 сек
		}
	}
	void Update () {
		if (moving == true && inputCount >0) {
			parts.SetActive(true);
			transform.position = new Vector3(player.transform.position.x,transform.position.y,0f);
		}
		if (inputCount <= 0) {
			ani.SetTrigger("Die");
		}
	}
}
