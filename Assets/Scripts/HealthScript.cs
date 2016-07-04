using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
	public int hp = 2;

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
//		lastHp = maxhp;
		GameObject.Find ("hpTxt").GetComponent<Text> ().text = hp.ToString ();
		theEndImage = GameObject.Find ("TheEnd").GetComponent<Image> ();
		chooseLvl = GameObject.Find ("Back").GetComponent<Image> ();
		theEndImage.enabled = false;
		chooseLvl.enabled = false;
		// end = GameObject.Find("Text").GetComponent<Text>();
		curHp = hp / maxhp;
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        EnemyShotScript shot = collider.gameObject.GetComponent<EnemyShotScript>();
        if (shot != null)
        {
			if (/*shot.isEnemyShot != isEnemy && SuperPower.IsSuperPunchActive == false && */SuperSpeed.IsRunning == false)
            {
                hp -= shot.damage;
				GameObject.Find ("CameraPoint").GetComponent<AudioSource>().Play ();
			    curHp = hp/maxhp;
				hpBar.fillAmount -= 0.0001f;
				GameObject.Find("hpTxt").GetComponent<Text>().text = hp.ToString();

                if (hp <= 0)
                {
					hpBar.enabled = false;
					hpBarHolder.enabled = false;
					theEndImage.enabled = true;
					chooseLvl.enabled = true;
					//end.text = "You are dead";
					Time.timeScale = 0;						
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
	}
	

