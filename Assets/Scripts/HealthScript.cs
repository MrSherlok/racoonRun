using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{	
	public int hp = 2;
	GameObject player;
    public bool isEnemy = false;

    private Image theEndImage;
    private Text end;
    private Image chooseLvl;
	public Image hpBar;
	public Image hpBarHolder;
	public float maxhp = 12;
	public float curHp;
//	float lastHp;
	public float lerpTime;

    void Start()
	{
		player = GameObject.Find ("Player");
//		lastHp = maxhp;
		GameObject.Find ("hpTxt").GetComponent<Text> ().text = hp.ToString ();
		theEndImage = GameObject.Find ("TheEnd").GetComponent<Image> ();
		chooseLvl = GameObject.Find ("Back").GetComponent<Image> ();
		theEndImage.enabled = false;
		chooseLvl.enabled = false;
		curHp = hp / maxhp;
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        EnemyShotScript shot = collider.gameObject.GetComponent<EnemyShotScript>();
        if (shot != null)
        {
			if (SuperPunch.IsSuperPunchActive == false && SuperSpeed.IsRunning == false)
            {
                hp -= shot.damage;
				player.GetComponent<Player>().IGetDamage();
				GameObject.Find ("CameraPoint").GetComponent<AudioSource>().Play ();
			    curHp = hp/maxhp;
				hpBar.fillAmount -= 0.0001f;
				GameObject.Find("hpTxt").GetComponent<Text>().text = hp.ToString();

                if (hp <= 0)
                {
					hpBar.enabled = false;
					hpBarHolder.enabled = false;

					chooseLvl.enabled = true;

					Dead();					
                }
            }
        }
    }
	void FixedUpdate(){
		HpCorrector();
	}
	void HpCorrector(){
		if(curHp<hpBar.fillAmount)
			hpBar.fillAmount = Mathf.Lerp(hpBar.fillAmount,curHp,Time.deltaTime*lerpTime);
		}
	void Dead(){
		
		//2-Foreground
		//1-Middle
		//0-backgroun
		player.GetComponent<Player>().DieEnot();
		GameObject.Find("0-backgroun").GetComponent<ScrollingScript>().speed = new Vector2(0,0);
		GameObject.Find("2-Foreground").GetComponent<ScrollingScript>().speed = new Vector2(0,0);
		GameObject.Find("1-Middle").GetComponent<ScrollingScript>().speed = new Vector2(0,0);
		Invoke ("EndImage", 2);

			
		

	}
	void EndImage(){
		theEndImage.enabled = true;
	}

}
	

