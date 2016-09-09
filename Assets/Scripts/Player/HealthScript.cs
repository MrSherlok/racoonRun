using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {	
//	GameObject camPoint;

	[SerializeField]
	private AudioClip _getDamage;

	public float hp = 6;
	GameObject player;
    public bool isEnemy = false;

    private Image theEndImage;
    private Text end;
    private Image chooseLvl;
	public Image hpBar;
	public Image hpBarHolder;
	public float maxhp = 6;
	public float curHp;
//	float lastHp;
	public float lerpTime;
	//DEAD2
	public static bool playerDead;
	public static bool Invulnerability = false;

	void Awake(){
		playerDead = false;	
	}
    void Start()
	{	//DEAD1
		
//		camPoint = GameObject.Find ("CameraPoint");
		player = GameObject.Find ("Player");
//		lastHp = maxhp;
		GameObject.Find ("hpTxt").GetComponent<Text> ().text = hp.ToString ();
		theEndImage = GameObject.Find ("TheEnd").GetComponent<Image> ();
		chooseLvl = GameObject.Find ("Back").GetComponent<Image> ();
		theEndImage.enabled = false;
		chooseLvl.enabled = false;
		curHp = hp / maxhp;

		Invulnerability = false;
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        EnemyShotScript shot = collider.gameObject.GetComponent<EnemyShotScript>();
		if (shot != null) {
			if (MoonWalk.IsMoonWalkActive) {
				if (hp != maxhp) {
					if (shot.damage < 2)
						hp += shot.damage;
					else
						hp += 2f;

					//проверка на то, чтобы хп не было больше заданого
					if (hp > maxhp) {
						hp = maxhp;
					}

					//тут должно в хпбаре заполниться юшка
					curHp = hp / maxhp;
					hpBar.fillAmount += 0.0001f;
					GameObject.Find ("hpTxt").GetComponent<Text> ().text = hp.ToString ();

					//тут анимация + удаление врага
					Destroy(collider.gameObject);
				}

			} else {
				if (!Invulnerability) {
					hp -= shot.damage;
					player.GetComponent<Player> ().IGetDamage ();
					player.GetComponent<AudioSource> ().clip = _getDamage;
					player.GetComponent<AudioSource> ().Play ();

					curHp = hp / maxhp;
					hpBar.fillAmount -= 0.0001f;
					if (hp < 0)
						hp = 0;
					GameObject.Find ("hpTxt").GetComponent<Text> ().text = hp.ToString ();

					if (hp <= 0) {
						SuperPower.ActImage = true;
						SuperPower.ActImage = true;
						Dead (1);					
					}
				}
			}
		}
    }


	void FixedUpdate(){
		HpCorrector();
	}
	void HpCorrector(){
		if(curHp!=hpBar.fillAmount)
			hpBar.fillAmount = Mathf.Lerp(hpBar.fillAmount,curHp,Time.deltaTime*lerpTime);
		}
	public void Dead(int sposob){
		
		hpBar.enabled = false;
		hpBarHolder.enabled = false;
		chooseLvl.enabled = true;
		Invoke ("EndImage", 1.5f);
		//Time.timeScale = 0.4f;
		if (sposob == 1) {
			player.GetComponent<Player> ().DieEnot (1);
		}
		if (sposob == 2) {
			player.GetComponent<Player> ().DieEnot (2);
		}
		playerDead = true;
		GameObject.Find("0-backgroun").GetComponent<ScrollingScript>().speed = new Vector2(0,0);
		GameObject.Find("Earth").GetComponent<ScrollingScript>().speed = new Vector2(0,0);
		GameObject.Find("1-Middle").GetComponent<ScrollingScript>().speed = new Vector2(0,0);
		StartCoroutine("CameraInc");
	}
	void EndImage(){

		SuperPower.ActImage = true;

		theEndImage.enabled = true;
	}
	IEnumerator CameraInc(){
		while (Camera.main.orthographicSize > 3f && PauseScript.isPause) {
			Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize,2f,Time.deltaTime * 0.5f);
			Camera.main.transform.Translate (Vector2.left * Time.deltaTime * 15f);
			Debug.Log ("-");
			yield return null;
		}
	}

}
	

