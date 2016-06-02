using UnityEngine;
using System.Collections;

public class CameraFollowScript2 : MonoBehaviour {
	private Vector2 velocity;

	public float smoothTimeX;
	public float smoothTimeY;
	public float camLevelChangeSmooth;

	//Точка за которой смотрит камера

	private float playerY;
	//Vector3 3х уровней 
		Vector3 vectorMid;
		Vector3 vectorHi;
		Vector3 vectorUnder;

	//Animator
	[SerializeField]
	private bool DoDamage;
	public static Animator camAnimator;
	//	float posX = 0f;
	float posY = 0f;
	float camPosY = 0f;
	GameObject player;

	void Start () {
		vectorHi = new Vector3(transform.position.x,18,transform.position.z);
		vectorMid = new Vector3(transform.position.x,3,transform.position.z);
		vectorUnder = new Vector3(transform.position.x,-9,transform.position.z); 
		player =  GameObject.Find("CameraPoint");
		camAnimator = player.GetComponent<Animator>();
		camPosY = gameObject.transform.position.y;
	}
	void FixedUpdate () {
		//		posX = Mathf.SmoothDamp(transform.position.x,player.transform.position.x,ref velocity.x, smoothTimeX);
		//posY = Mathf.SmoothDamp(transform.position.y,player.transform.position.y,ref velocity.y, smoothTimeY);

		//transform.position = new Vector3(player.transform.position.x,posY,player.transform.position.z-10f);
		//Проверяем точку(за которой следит камера) и двигаем камеру в зависимости от уровня точки
	
			if (player.transform.position.y > 13.1f && player.transform.position.y < 26.0f) {
				gameObject.transform.position = Vector3.Lerp (transform.position, vectorHi, camLevelChangeSmooth);
				//Debug.Log ("hi level");	
			}
			if (player.transform.position.y > 0 && player.transform.position.y < 13.0f) {

				//Debug.Log ("Mid Level");	
				gameObject.transform.position = Vector3.Lerp (transform.position, vectorMid, camLevelChangeSmooth);
			}
			if (player.transform.position.y > -13.0f && player.transform.position.y < 0f) {
				//	gameObject.transform.position = new Vector3(transform.position.x,camPosY + -19f,transform.position.z);

				//Debug.Log ("Under Level");	
				gameObject.transform.position = Vector3.Lerp (player.transform.position, vectorUnder, camLevelChangeSmooth);
			}

	}
	public static void DamageAnim(){
		camAnimator.SetTrigger ("DoDamage");
	}
	public static void ClaimCoinAnim(){
		camAnimator.SetTrigger ("CoinCash");
	}

}
