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
	//FxVariables

	private ParticleSystem SodaFXParts;
	private ParticleSystem FireFXParts;


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
	public static float FlyingForse = 0.7f;
	public float timeToFly = 2f;
	private bool _isFlying = false;
	public static bool IsFlying = false;

	public static bool IsSuperPunchActive = false; 
	public GameObject superPunchIm;
	public GameObject superPunchIm1;



	public static bool superJumpEnabled = false;
	public static float ForceSuperJump = 30f;
	public bool IsGrounded = false; 
	bool cloudTuch = false;
	//private bool isGrounded;

	public Rigidbody2D myRigitbody;
    private Animator animator;



//    private int hpSS;
	private ScrollingScript playerSpeed;
	public static float SpeedSuper = 40f;
	private bool _isRunning = false;
	public static bool IsRunning = false;
	public float timeToRun = 2f;



    public void Awake(){
        animator = GameObject.Find("Player1").GetComponent<Animator>();
		playerSpeed = GameObject.Find("2-Foreground").GetComponent<ScrollingScript>();

    }
	void Start() {
		if (ChooseSPScript.ActiveDefSpel == 1) {
			ParticleSystem FireFXParts = GameObject.Find ("InpuctFireFx").GetComponent<ParticleSystem> ();
			ParticleSystem SodaFXParts = GameObject.Find ("SodaFX").GetComponent<ParticleSystem> ();
			SodaFXParts.enableEmission = false;
			FireFXParts.enableEmission = false;
		}

		
/*		_superSpeedEnable = ChooseSPScript.chooseSuperSpeedEnable;
		_flyingEnable = ChooseSPScript.choooseFlyingEnable;
		_superJumpEnable = ChooseSPScript.chooseSuperJumpEnable;
		_cookieRangEnable = ChooseSPScript.chooseCookieRangEnable;
		_bananaGunEnable = ChooseSPScript.chooseBananaGunEnable;
		_superPunchEnable = ChooseSPScript.chooseSuperPunchEnable;
*/
		IsRunning = false;
		IsSuperPunchActive = false;
		IsFlying = false;

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
        
		if (_actDef == 1) {
			if (_isFlying && timeToFly >= 0) {
				IsFlying = true;
				//mainCamera.GetComponent<CameraFollowScript> ().smoothTimeY = 0.005f;
				TremorAnimOn ();
				//jetpackFX.SetActive (true);
				timeToFly -= Time.deltaTime;
				myRigitbody.gravityScale = 2f;
				myRigitbody.velocity += FlyingForse * Vector2.up;
				//Particle Fire - active
				//Satricle Boubbles Start
				//ТУТ ПОЛЕТ
				ParticleSystem FireFXParts = GameObject.Find("InpuctFireFx").GetComponent<ParticleSystem>();
				ParticleSystem SodaFXParts = GameObject.Find("SodaFX").GetComponent<ParticleSystem>();
			
				SodaFXParts.enableEmission = true;
				FireFXParts.enableEmission = true;
			} else {
				//Particle Fire - !active
				//Satricle Boubbles Stop
				IsFlying = false;
				myRigitbody.gravityScale = 6f;
				TremorAnimOff ();
				ParticleSystem FireFXParts = GameObject.Find("InpuctFireFx").GetComponent<ParticleSystem>();
				ParticleSystem SodaFXParts = GameObject.Find("SodaFX").GetComponent<ParticleSystem>();
				SodaFXParts.enableEmission = false;
				FireFXParts.enableEmission = false;
				//jetpackFX.SetActive (false);
			}
		}


		if (_actDef == 2) {
			if (_isRunning && timeToRun >= 0) {
				IsRunning = true;
				timeToRun -= Time.deltaTime;
				playerSpeed.speed = new Vector2 (SpeedSuper, 0f);
			} else {
				IsRunning = false;
				playerSpeed.speed = new Vector2 (0f, 0f);
			}
		}
	}


    public void SuperPunch()
	{
		if (PauseScript.isPause) {
			superPunchIm1.GetComponent<Renderer> ().enabled = true;
			superPunchIm.GetComponent<Collider2D> ().enabled = true;
			IsSuperPunchActive = true;
			animator.SetBool ("superPunch", true);
			animator.SetBool ("Run", false);
			Invoke ("StopPunch", 0.25f);
		}
	}

    void StopPunch()
    {
		superPunchIm1.GetComponent<Renderer> ().enabled = false;
        superPunchIm.GetComponent<Collider2D>().enabled = false;
        IsSuperPunchActive = false;
        animator.SetBool("superPunch", false);
        animator.SetBool("Run", true);
    }





    public void SuperSpeed (bool isTrueSpeed) {
		if (PauseScript.isPause) {
			if (isTrueSpeed) {
				_isRunning = true;
			} else {
				_isRunning = false;
			}
		}
	}


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
				_isFlying = true;			
			} else {
				_isFlying = false;
			}
		}
    }

public void SuperJump()
	{
		if (PauseScript.isPause) {
			if (IsGrounded || cloudTuch) {
				myRigitbody.gravityScale = 4f;
				myRigitbody.velocity += ForceSuperJump * Vector2.up;
				superJumpEnabled = true;
				//mainCamera.GetComponent<CameraFollowScript> ().smoothTimeY = 0.005f;
				Invoke ("StopSuperJump", 0.1f);
			}
		}
	}

    void StopSuperJump()
    {
		myRigitbody.gravityScale = 6f;
        superJumpEnabled = false;

    }


void TremorAnimOn(){
//	CameraFollowScript2.camAnimator.SetBool ("Tremor",true);
		//Debug.Log ("asf");
}
void TremorAnimOff(){
//	CameraFollowScript2.camAnimator.SetBool ("Tremor",false);
}

}
