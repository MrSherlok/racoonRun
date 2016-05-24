using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {
	public float moveSpeed;
	public float jumpForce;

	private Rigidbody2D itsRigidbody;

	void Start () {
		itsRigidbody = GetComponent<Rigidbody2D>();
	}
	void FixedUpdate(){
		itsRigidbody.velocity = new Vector2(moveSpeed,itsRigidbody.velocity.y);

		if(Input.GetMouseButtonDown(0)){
			itsRigidbody.velocity = new Vector2(itsRigidbody.velocity.x, jumpForce);
		}
	}}