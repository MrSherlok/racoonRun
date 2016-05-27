﻿using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {
	private Vector2 velocity;

	public float smoothTimeX;
	public float smoothTimeY;
	public float camLevelChangeSmooth;

	//Точка за которой смотрит камера
	[SerializeField]
	private float playerY;
	//Vector3 3х уровней 
	Vector3 vectorMid;
	Vector3 vectorHi;
	Vector3 vectorUnder;

	//Animator
	[SerializeField]
	private bool DoDamage;
	static public Animator camAnimator;
	float posX;
	float posY;
	float camPosY;

	public GameObject player;
	// Use this for initialization
	void Start () {
		vectorHi = new Vector3(transform.position.x,camPosY + 14.5f,transform.position.z);
		vectorMid = new Vector3(transform.position.x,camPosY + 3,transform.position.z);
		vectorUnder = new Vector3(transform.position.x,camPosY + -19,transform.position.z); 
		//player =  GameObject.Find("CameraFollowPoint");
		camAnimator = GameObject.Find("CameraPoint").GetComponent<Animator>();
		camPosY = gameObject.transform.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		posX = Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref velocity.x, smoothTimeX);
		posY = Mathf.SmoothDamp(transform.position.y,player.transform.position.y,ref velocity.y, smoothTimeY);

		transform.position = new Vector3(posX,posY,transform.position.z);
		//Проверяем точку(за которой следит камера) и двигаем камеру в зависимости от уровня точки
		if (player.transform.position.y > 11.1f && player.transform.position.y < 23.0f){
			gameObject.transform.position = Vector3.Lerp (gameObject.transform.position,vectorHi,camLevelChangeSmooth);
			//Debug.Log ("hi level");	
		}
		if (player.transform.position.y > -1.1f && player.transform.position.y < 11.0f){

			//Debug.Log ("Mid Level");	
			gameObject.transform.position = Vector3.Lerp (gameObject.transform.position,vectorMid,camLevelChangeSmooth);
		}
		if (player.transform.position.y > -11.0f && player.transform.position.y < -1.0f){
			gameObject.transform.position = new Vector3(transform.position.x,camPosY + -19,transform.position.z);
			
			//Debug.Log ("Under Level");	
			gameObject.transform.position = Vector3.Lerp (gameObject.transform.position,vectorUnder,camLevelChangeSmooth);
		}
	}
	public static void DamageAnim(){
		camAnimator.SetTrigger ("DoDamage");
	}
	public static void ClaimCoinAnim(){
		camAnimator.SetTrigger ("CoinCash");
	}
	public static void TremorAnimOn(){
		camAnimator.SetBool ("Tremor",true);
	}
	public static void TremorAnimOff(){
		camAnimator.SetBool ("Tremor",false);
	}
}
