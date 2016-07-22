using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotateCylinder : MonoBehaviour {
	public int color;
	Animator grabAnim;
	bool rotNow = false;
	bool isEnding = false;
	GameObject cyl;
	public ParticleSystem.EmissionModule Iskru;
	public Text rez;

	void Start(){
		cyl = GameObject.Find ("Cylinder");
		grabAnim = GameObject.Find ("Grablya").GetComponent<Animator> ();
		grabAnim.SetBool ("Close",false);
		Iskru = GameObject.Find ("IskryPS").GetComponent<ParticleSystem> ().emission;
		Iskru.enabled = false;
	}

	public void Roll () {
		gameObject.GetComponent<Button> ().enabled = false;
		//cyl.GetComponent<Rigidbody>().AddTorque(transform.forward * 1800f * 50f);
		rotNow = true;
		grabAnim.SetBool("Close",true);
		Invoke ("IskruEnbling",1f);
	}

	void IskruEnbling(){
		Iskru.enabled = true;
		Invoke ("Stop",Random.Range(1,4));
	}
	void Stop(){
		rotNow = false;
		isEnding = true;
		Iskru.enabled = false;
		ReadScore();
	}

	void Update ()
	{
		if (isEnding ) {
			
			cyl.transform.Rotate (Vector3.down * 1 * Time.deltaTime);
		}
		if (rotNow) {
			cyl.transform.Rotate (Vector3.down * 1000 * Time.deltaTime);

		}
	}
	public void ReadScore(){
		if(cyl.transform.eulerAngles.y >0 && cyl.transform.eulerAngles.y <45){
			Debug.Log ("DarkBlue");
			color = 6;
		}
		if(cyl.transform.eulerAngles.y >45 && cyl.transform.eulerAngles.y <90){
			Debug.Log ("LightBLue");
			color = 5;
		}
		if(cyl.transform.eulerAngles.y >90 && cyl.transform.eulerAngles.y <135){
			Debug.Log ("Green");
			color = 4;
		}
		if(cyl.transform.eulerAngles.y >135 && cyl.transform.eulerAngles.y <180){
			Debug.Log ("Yellow");
			color = 3;
		}
		if(cyl.transform.eulerAngles.y >180 && cyl.transform.eulerAngles.y <225){
			Debug.Log ("Orange");
			color = 2;
		}
		if(cyl.transform.eulerAngles.y >225 && cyl.transform.eulerAngles.y <270){
			Debug.Log ("Red");
			color = 1;
		}
		if(cyl.transform.eulerAngles.y >270 && cyl.transform.eulerAngles.y <315){
			Debug.Log ("Gray");
			color = 8;
		}
		if(cyl.transform.eulerAngles.y >315 && cyl.transform.eulerAngles.y <360){
			Debug.Log ("Violet");
			color = 7;
		}
		Invoke ("Result",1);
	}
	void Result(){
		//Debug.Log (GameObject.Find("Colorhosein").GetComponent<ChoseYourColor>().color);
		if (color == GameObject.Find ("Colorhosein").GetComponent<ChoseYourColor> ().color) {
			rez.text = CoinCollect.coins.ToString() + "x30";
			CoinCollect.coins *= 30;
			GoldScript.Gold += CoinCollect.coins;
			PlayerPrefs.SetInt ("Gold", GoldScript.Gold);
			CoinCollect.coins = 0;
		} else if (color == GameObject.Find ("Colorhosein").GetComponent<ChoseYourColor> ().color - 1 ||
		         color == GameObject.Find ("Colorhosein").GetComponent<ChoseYourColor> ().color + 1) {
			rez.text = CoinCollect.coins.ToString() + "x20";
			CoinCollect.coins *= 20;
			GoldScript.Gold += CoinCollect.coins;
			PlayerPrefs.SetInt ("Gold", GoldScript.Gold);
			CoinCollect.coins = 0;
		} else {
			rez.text = CoinCollect.coins.ToString() + "x10";
			CoinCollect.coins *= 10;
			GoldScript.Gold += CoinCollect.coins;
			PlayerPrefs.SetInt ("Gold", GoldScript.Gold);
			CoinCollect.coins = 0;
		}

		Invoke("BackToMap",2.0f);

	}


	void BackToMap() {
		SceneManager.LoadScene("chooseLVL");
	}
}
