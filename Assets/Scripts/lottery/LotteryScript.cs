using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LotteryScript : MonoBehaviour {
    GameObject circle;
    public Animator circleAnimator;
    float t;
    bool rooll = false;
    bool roollStop = false;
    int rez = 0;
    public Text txt;
    public Image Button;
	public GameObject finSceneGO;

    void Start () {
        circle = GameObject.Find("disk");
       // circleAnimator = circle.GetComponent<Animator>();
        t = 0;
    }
	
    public void Roll()
    {	
		circleAnimator.SetBool("ImPlay",true);
        Button.enabled = false;
        roollStop = false;
        rooll = true;
        Invoke("Stop", Random.Range(3, 5));
    }

    void Stop()
    {
        rooll = false;
        roollStop = true;        
    }

	void Update () {
        if (rooll == true && circle.GetComponent<RotateScript>().speed < 20)
        {
            t = 0.5f;
            circle.GetComponent<RotateScript>().speed += t;

        }
        if (roollStop == true && circle.GetComponent<RotateScript>().speed > 0)
        {
            t = 0.5f;
            circle.GetComponent<RotateScript>().speed -= t;
            if (circle.GetComponent<RotateScript>().speed <= 0)
            {
                circle.GetComponent<RotateScript>().speed = 0;
                Invoke("ReadScore",0f);
            }
        }
        t += Time.deltaTime;
    }
    void ReadScore()
    {
        Debug.Log(circle.transform.eulerAngles.z);
        if (circle.transform.eulerAngles.z > 0 && circle.transform.eulerAngles.z <= 45){
			rez = 1;
        }
		if(circle.transform.eulerAngles.z > 45 && circle.transform.eulerAngles.z <= 90){
            rez = 2;
        }
		if(circle.transform.eulerAngles.z > 90 && circle.transform.eulerAngles.z <= 135){
            rez = 1;
        }
		if(circle.transform.eulerAngles.z > 135 && circle.transform.eulerAngles.z <= 180){
            rez = 3;
        }
		if(circle.transform.eulerAngles.z > 180 && circle.transform.eulerAngles.z <= 225){
            rez = 1;
        }
		if(circle.transform.eulerAngles.z > 225 && circle.transform.eulerAngles.z <= 270){
            rez = 2;
        }
		if(circle.transform.eulerAngles.z > 270 && circle.transform.eulerAngles.z <= 315){
            rez = 1;
        }
		if(circle.transform.eulerAngles.z >  315 && circle.transform.eulerAngles.z <= 360){
            rez = 3;
        }
        Invoke("Result",0f);
	}
	void Result()
{
    //Debug.Log (GameObject.Find("Colorhosein").GetComponent<ChoseYourColor>().color);

        txt.text = CoinCollect.coins.ToString() + " * "+rez.ToString();
        CoinCollect.coins *= rez;
        GoldScript.Gold = PlayerPrefs.GetInt("Gold");
        GoldScript.Gold += CoinCollect.coins;
        PlayerPrefs.SetInt("Gold", GoldScript.Gold);
        CoinCollect.coins = 0;
        Invoke("BackToMap", 5.0f);
		finSceneGO.SetActive(true);
    }



    void BackToMap()
    {
        SceneManager.LoadScene("chooseLVL");
    }

}
