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
		GameObject.Find("hpTxt").GetComponent<Text>().text = hp.ToString();

		
        if (gameObject.tag == "Player")
        {
            theEndImage = GameObject.Find("TheEnd").GetComponent<Image>();
            chooseLvl = GameObject.Find("Back").GetComponent<Image>();
            theEndImage.enabled = false;
            chooseLvl.enabled = false;
           // end = GameObject.Find("Text").GetComponent<Text>();
			curHp = hp/maxhp;
        }

    }



    void OnTriggerEnter2D(Collider2D collider)
    {
        EnemyShotScript shot = collider.gameObject.GetComponent<EnemyShotScript>();
        if (shot != null)
        {
			if (shot.isEnemyShot != isEnemy && SuperPower.IsRunning == false && SuperPower.IsSuperPunchActive == false)
            {
                hp -= shot.damage;
			    curHp = hp/maxhp;
			hpBar.fillAmount -= 0.0001f;
				
			/*if(gameObject.tag == "Player")*/ GameObject.Find("hpTxt").GetComponent<Text>().text = hp.ToString();

				//ChangeLastHp();
			//TYT
               /* if (shot.tag == "cookieRang")
                {
                    Destroy(shot.transform.parent.gameObject);
                }
                else {
                    if (shot.name != "boxin_glow") Destroy(shot.gameObject);
                } */
                if (hp <= 0)
                {
                 /*   if (gameObject.tag == "enemys")
                    {
                        Destroy(gameObject);
                    }
                    else {*/
				hpBar.enabled = false;
				hpBarHolder.enabled = false;
				//GameObject.Find("hpTxt").GetComponent<Text>().text = "O";
                        theEndImage.enabled = true;
                        chooseLvl.enabled = true;
                      //  end.text = "You are dead";
                        Time.timeScale = 0;
						
                    /*}*/
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
	

