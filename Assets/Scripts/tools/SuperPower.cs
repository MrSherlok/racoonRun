using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SuperPower : MonoBehaviour {
	bool _superSpeedEnable;             //блок проверки выбраных спелов
	bool _flyingEnable;
	bool _superJumpEnable;
	bool _cookieRangEnable;
	bool _bananaGunEnable;
	bool _superPunchEnable;

    public Image superSpeedImage;           //блок картинок
    public Image flyingImage;
    public Image superJumpImage;
    public Image cookieRangImage;
    public Image bananaGunImage;
    public Image superPunchImage;
    public Image jumpImage;

     
	public Camera mainCamera;

    private float _flyingRate = 0.5f;           
	private float _flyingCooldown = 0; 
	public int FlyingForse = 4;
	public float timeToFly = 2f;
	bool isFlying = false;

	bool isSuperPunchActive = false; 
	public GameObject superPunchIm;   


    public bool superJumpEnabled = false;
	public float jumpForce = 5f;
	public bool IsGrounded = false; 
	//private bool isGrounded;

	public Rigidbody2D myRigitbody;
	public GameObject effects;  
    private Animator animator;


//    private int hpSS;
	private ScrollingScript playerSpeed;
	bool isRunning = false;
	public float timeToRun = 2f;


    public void Awake(){
        animator = GameObject.Find("Player1").GetComponent<Animator>();
//        effects.SetActive (false);
		playerSpeed = gameObject.GetComponent<ScrollingScript>();
    }

	void Start() {
		_superSpeedEnable = ChooseSPScript.chooseSuperSpeedEnable;
		_flyingEnable = ChooseSPScript.choooseFlyingEnable;
		_superJumpEnable = ChooseSPScript.chooseSuperJumpEnable;
		_cookieRangEnable = ChooseSPScript.chooseCookieRangEnable;
		_bananaGunEnable = ChooseSPScript.chooseBananaGunEnable;
		_superPunchEnable = ChooseSPScript.chooseSuperPunchEnable;

		if (_superSpeedEnable == true) {
			superSpeedImage.enabled = true;
		} else {
			superSpeedImage.enabled = false;   
		}

		if (_flyingEnable == true) {
			flyingImage.enabled = true;
		} else {
			flyingImage.enabled = false;     
		}

		if (_superJumpEnable == true) {
			superJumpImage.enabled = true;
		} else {
			superJumpImage.enabled = false;   
		}

		if (_cookieRangEnable) {
			cookieRangImage.enabled = true;
		} else {
			cookieRangImage.enabled = false;
		}

		if (_bananaGunEnable) {
			bananaGunImage.enabled = true;
		} else {
			bananaGunImage.enabled = false;
		}

		if (_superPunchEnable) {
			superPunchImage.enabled = true;
			superPunchIm.GetComponent<SpriteRenderer>().enabled = true;

		} else {
			superPunchImage.enabled = false;
			superPunchIm.GetComponent<SpriteRenderer>().enabled = false;            
		}
	}

	public void FixedUpdate () {
		IsGrounded = GetComponent<Player>().IsGrounded;
       
        if (_flyingCooldown > 0)
        {
            _flyingCooldown -= Time.deltaTime;
        }

        

		if (isFlying && timeToFly >= 0) {
			timeToFly -= Time.deltaTime;
			myRigitbody.gravityScale = 3f;
			myRigitbody.velocity += FlyingForse * Vector2.up;
		} else {
			myRigitbody.gravityScale = 5f;
		}

		if (isRunning && timeToRun >=0) {
			gameObject.GetComponent<HealthScript> ().isEnemy = true;
			timeToRun -= Time.deltaTime;
			mainCamera.GetComponent<CameraFollowScript> ().smoothTimeX = 0.05f;
			playerSpeed.speed = new Vector2(100f,0f);
		} else {
			mainCamera.GetComponent<CameraFollowScript> ().smoothTimeX = 1;
			playerSpeed.speed = new Vector2(0f,0f);
			gameObject.GetComponent<HealthScript> ().isEnemy = false;
		}
	}


    public void SuperPunch()
    {
        superPunchIm.GetComponent<Collider2D>().enabled = true;
        isSuperPunchActive = true;
      //  animator.SetBool("superPunch", true);
      //  animator.SetBool("Run", false);
        Invoke("StopPunch", 0.25f);
    }

    void StopPunch()
    {
        superPunchIm.GetComponent<Collider2D>().enabled = false;
        isSuperPunchActive = false;
      //  animator.SetBool("superPunch", false);
       // animator.SetBool("Run", true);

    }





    public void SuperSpeed (bool isTrueSpeed) {

		if (isTrueSpeed) {
			isRunning = true;
		} else {
			isRunning = false;
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


		if (isTrueFly ) {
			isFlying = true;
			CameraFollowScript.TremorAnimOn ();
		} else {
			isFlying = false;
		CameraFollowScript.TremorAnimOff ();
		}


		//effects.SetActive (true);
	//	Invoke ("Deeffector",3.0f);


    }
	void Deeffector(){
		//effects.SetActive (false);
		myRigitbody.gravityScale = 5f;
	}

    public void SuperJump()
    {
        //		isGrounded = GameObject.Find("Player").GetComponent<Player> ().isGrounded;

        if (IsGrounded)
        {
			myRigitbody.gravityScale = 5f;
            myRigitbody.velocity += jumpForce * Vector2.up;
            superJumpEnabled = true;
            Invoke("StopSuperJump", 1.8f);
        }
    }

    void StopSuperJump()
    {
        superJumpEnabled = false;
		myRigitbody.gravityScale = 7f;
    }
}
