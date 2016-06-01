using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SuperPower : MonoBehaviour {
/*	bool _superSpeedEnable;             //блок проверки выбраных спелов
	bool _flyingEnable;
	bool _superJumpEnable;
	bool _cookieRangEnable;
	bool _bananaGunEnable;
	bool _superPunchEnable;
*/
	public Image[] spelsDamImage = new Image[3];
	public Image[] spelsDefImage = new Image[3];

	private int _actDam = -1;
	private int _actDef = -1;

/*    public Image superSpeedImage;           //блок картинок
    public Image flyingImage;
    public Image superJumpImage;
    public Image cookieRangImage;
    public Image bananaGunImage;
    public Image superPunchImage;
    public Image jumpImage;
*/
     
	public Camera mainCamera;

//    private float _flyingRate = 0.5f;           
//	private float _flyingCooldown = 0; 
	public int FlyingForse = 4;
	public float timeToFly = 2f;
	bool isFlying = false;

//	bool isSuperPunchActive = false; 
	public GameObject superPunchIm;   

	public GameObject jetpackFX;

	public static bool superJumpEnabled = false;
	public float jumpForce = 5f;
	public bool IsGrounded = false; 
	//private bool isGrounded;

	public Rigidbody2D myRigitbody;
	public GameObject effects;  
    private Animator animator;


//    private int hpSS;
	private ScrollingScript playerSpeed;
	bool isRunning = false;
	public static bool IsRunning = false;
	public float timeToRun = 2f;
	bool cloudTuch = false;


    public void Awake(){
        animator = GameObject.Find("Player1").GetComponent<Animator>();
//        effects.SetActive (false);
		playerSpeed = GameObject.Find("2-Foreground").GetComponent<ScrollingScript>();
    }

	void Start() {
/*		_superSpeedEnable = ChooseSPScript.chooseSuperSpeedEnable;
		_flyingEnable = ChooseSPScript.choooseFlyingEnable;
		_superJumpEnable = ChooseSPScript.chooseSuperJumpEnable;
		_cookieRangEnable = ChooseSPScript.chooseCookieRangEnable;
		_bananaGunEnable = ChooseSPScript.chooseBananaGunEnable;
		_superPunchEnable = ChooseSPScript.chooseSuperPunchEnable;
*/
		_actDam = ChooseSPScript.ActiveDamSpel;
		_actDef = ChooseSPScript.ActiveDefSpel;


		if(_actDam != -1) spelsDamImage[_actDam].enabled = true;
		if (_actDef != -1) spelsDefImage [_actDef].enabled = true;

/*		if (_superSpeedEnable == true) {
			spelsDefImage[2].enabled = true;
		} else {
			spelsDefImage[2].enabled = false;   
		}

		if (_flyingEnable == true) {
			spelsDefImage[1].enabled = true;
		} else {
			spelsDefImage[1].enabled = false;     
		}

		if (_superJumpEnable == true) {
			spelsDefImage[0].enabled = true;
		} else {
			spelsDefImage[0].enabled = false;   
		}

		if (_cookieRangEnable) {
			spelsDamImage[2].enabled = true;
		} else {
			spelsDamImage[2].enabled = false;
		}

		if (_bananaGunEnable) {
			spelsDamImage[0].enabled = true;
		} else {
			spelsDamImage[0].enabled = false;
		}
*/
		if (_actDam == 1) {
//			spelsDamImage[1].enabled = true;
			superPunchIm.GetComponent<SpriteRenderer>().enabled = true;

		} else {
//			spelsDamImage[1].enabled = false;
			superPunchIm.GetComponent<SpriteRenderer>().enabled = false;            
		}
	}

	public void FixedUpdate () {
		if (Player.isCloudfootTouch || Player.isCloudHeadTouch) {
			cloudTuch = true;
		} else {
			cloudTuch = false;
		}
		IsGrounded = Player.IsGrounded;
       
 /*       if (_flyingCooldown > 0)
        {
            _flyingCooldown -= Time.deltaTime;
        }
*/
        
		if (_actDef == 1) {
			if (isFlying && timeToFly >= 0) {
				mainCamera.GetComponent<CameraFollowScript> ().smoothTimeY = 0.005f;
				TremorAnimOn ();
				jetpackFX.SetActive (true);
				timeToFly -= Time.deltaTime;
				myRigitbody.gravityScale = 3f;
				myRigitbody.velocity += FlyingForse * Vector2.up;
			} else {
				myRigitbody.gravityScale = 6f;
				TremorAnimOff ();
				jetpackFX.SetActive (false);
				Invoke("SmoothYBack", 0.8f);
			}
		}


		if (_actDef == 2) {
			if (isRunning && timeToRun >= 0) {
//				gameObject.GetComponent<HealthScript> ().isEnemy = true;
				IsRunning = true;
				timeToRun -= Time.deltaTime;
				mainCamera.GetComponent<CameraFollowScript> ().smoothTimeX = 0.05f;
				playerSpeed.speed = new Vector2 (100f, 0f);
			} else {
				IsRunning = false;
				mainCamera.GetComponent<CameraFollowScript> ().smoothTimeX = 1;
				playerSpeed.speed = new Vector2 (0f, 0f);
//				gameObject.GetComponent<HealthScript> ().isEnemy = false;
			}
		}
	}


    public void SuperPunch()
	{
		if (PauseScript.isPause) {
			superPunchIm.GetComponent<Collider2D> ().enabled = true;
//			isSuperPunchActive = true;
			animator.SetBool ("superPunch", true);
			animator.SetBool ("Run", false);
			Invoke ("StopPunch", 0.25f);
		}
	}

    void StopPunch()
    {
        superPunchIm.GetComponent<Collider2D>().enabled = false;
//        isSuperPunchActive = false;
        animator.SetBool("superPunch", false);
        animator.SetBool("Run", true);
    }





    public void SuperSpeed (bool isTrueSpeed) {
		if (PauseScript.isPause) {
			if (isTrueSpeed) {
				isRunning = true;
			} else {
				isRunning = false;
			}
		}

        
//        HealthScript health = GameObject.FindWithTag("Player").GetComponent<HealthScript>();
//        hpSS = health.hp;
//        health.hp = 1000;
            
//        Invoke("StopSpeed",0.5f);


		}
/*    void StopSpeed()
    {
      
        player.movementSpeed = 0;
//        HealthScript health = GameObject.FindWithTag("Player").GetComponent<HealthScript>();
//        health.hp = hpSS;
        

    }
*/
/*	public void Flying (bool isTrueFly) {
		
       
		if (isTrueFly && _flyingCooldown <= 0) {
			_flyingEnable = true;
			Invoke ("Soda", 0.5f);

			_flyingCooldown = _flyingRate;
			//movement = new Vector3 (0, speed.y * 1, 0);
			//rigidbody2D.velocity = movement;
			//} else {
			//	movement = new Vector3 (0, speed.y * -1, 0);
			//		rigidbody2D.velocity = movement;
		} 
	}
*/
	public void Soda( bool isTrueFly)
    {
	if (PauseScript.isPause) {
			if (isTrueFly) {		
				isFlying = true;			
			} else {
				isFlying = false;
			}
		}

		//effects.SetActive (true);
	//	Invoke ("Deeffector",3.0f);


    }
/*	void Deeffector(){
		//effects.SetActive (false);
		myRigitbody.gravityScale = 5f;
	}
*/
public void SuperJump()
	{
		//		isGrounded = GameObject.Find("Player").GetComponent<Player> ().isGrounded;
		if (PauseScript.isPause) {
			if (IsGrounded || cloudTuch) {
				myRigitbody.gravityScale = 4f;
				myRigitbody.velocity += jumpForce * Vector2.up;
				superJumpEnabled = true;
				mainCamera.GetComponent<CameraFollowScript> ().smoothTimeY = 0.005f;
				Invoke ("StopSuperJump", 0.1f);
				Invoke ("SmoothYBack", 0.5f);
			}
		}
	}

    void StopSuperJump()
    {
	myRigitbody.gravityScale = 6f;
        superJumpEnabled = false;

    }

void SmoothYBack () {
	mainCamera.GetComponent<CameraFollowScript> ().smoothTimeY = 0.05f;
	}


void TremorAnimOn(){
	CameraFollowScript.camAnimator.SetBool ("Tremor",true);
		Debug.Log ("asf");
}
void TremorAnimOff(){
	CameraFollowScript.camAnimator.SetBool ("Tremor",false);
}

}
