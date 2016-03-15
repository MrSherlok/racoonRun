using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {
	public int hp = 2;

	public bool isEnemy = false;

	private Image theEndImage;
	private Text end;
	private Image chooseLvl;

	void Start () {
		if (gameObject.tag == "Player"){
			theEndImage = GameObject.Find("TheEnd").GetComponent<Image>();
			chooseLvl = GameObject.Find("Back").GetComponent<Image>();
			theEndImage.enabled = false;
			chooseLvl.enabled = false;
			end = GameObject.Find("Text").GetComponent<Text>(); 
		}

	}

	void OnTriggerEnter2D (Collider2D collider) {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();
		if (shot != null) {
			if (shot.isEnemyShot != isEnemy) {
				hp  -= shot.damage;
                if(shot.tag == "shoot")
                {
                    Destroy(shot.transform.parent.gameObject);
                }
                else
				Destroy(shot.gameObject);
                if (hp <= 0)
                {
                    if (gameObject.tag == "enemys")
                    {
                        Destroy(gameObject);
                    }
                    else {
                        theEndImage.enabled = true;
                        chooseLvl.enabled = true;
                        end.text = "You are dead";
                        Time.timeScale = 0;

                    }
				}
			}
		}
	}
}
