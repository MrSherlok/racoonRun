using UnityEngine;
using System.Collections;

public class CameraFollowScript2 : MonoBehaviour {
	private Vector2 velocity;

	public float camLevelChangeSmooth;

	float my = 0f;

	private bool DoDamage;
	public static Animator camAnimator;
	GameObject player;

	void Start () {
		player =  GameObject.Find("CameraPoint");
		camAnimator = player.GetComponent<Animator>();
	}
	void FixedUpdate () {
		
		if (player.transform.position.y >= 26f) {
			my = player.transform.position.y;		
		}
		if (player.transform.position.y >= 13 && player.transform.position.y < 26f) {
			my = 18f;
		
		}
		if (player.transform.position.y >= 0f && player.transform.position.y < 13f) {
			my = 3f;
		
		}
		gameObject.transform.position = Vector3.Lerp(new Vector3(player.transform.position.x, transform.position.y, transform.position.z), new Vector3(player.transform.position.x, my, transform.position.z),camLevelChangeSmooth);

	}
	public static void DamageAnim(){
		camAnimator.SetTrigger ("DoDamage");

	}
	public static void ClaimCoinAnim(){
		camAnimator.SetTrigger ("CoinCash");
	}

}
