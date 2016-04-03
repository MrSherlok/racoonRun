using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SuperPower : MonoBehaviour {
	bool _superSpeedEnable;
	bool _flyingEnable;
	bool _superJumpEnable;
	bool _cookieRangEnable;
	bool _bananaGunEnable;
	bool _superPunchEnable;

	public bool IsGrounded = false;

    private float _flyingRate = 0.5f;
    private float _flyingCooldown = 0;

    public bool isSuperPunchActive = false;
	public int FlyingForse = 4;
	public Rigidbody2D myRigitbody;
	//private bool isGrounded;
	public float jumpForce = 5f;

	public GameObject effects;

	public Image superSpeedImage;
	public Image flyingImage;
	public Image superJumpImage;
    public Image cookieRangImage;
    public Image bananaGunImage;
    public Image superPunchImage;
    public Image jumpImage;


    public GameObject superPunchIm;
    private Animator animator;

    private int hpSS;
    private Player player;



    public void Awake(){
        animator = GameObject.Find("Player1").GetComponent<Animator>();
        effects.SetActive (false);
        player = gameObject.GetComponent<Player>();
    }

	public void FixedUpdate () {
		IsGrounded = GetComponent<Player>().IsGrounded;
        _superSpeedEnable = ChooseSPScript.chooseSuperSpeedEnable;
		_flyingEnable = ChooseSPScript.choooseFlyingEnable;
		_superJumpEnable = ChooseSPScript.chooseSuperJumpEnable;
        _cookieRangEnable = ChooseSPScript.chooseCookieRangEnable;
        _bananaGunEnable = ChooseSPScript.chooseBananaGunEnable;
        _superPunchEnable = ChooseSPScript.chooseSuperPunchEnable;

        if (_flyingCooldown > 0)
        {
            _flyingCooldown -= Time.deltaTime;
        }

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


    public void SuperPunch()
    {
        superPunchIm.GetComponent<Collider2D>().enabled = true;
        isSuperPunchActive = true;
        animator.SetBool("superPunch", true);
        animator.SetBool("Run", false);
        Invoke("StopPunch", 0.25f);
    }

    void StopPunch()
    {
        superPunchIm.GetComponent<Collider2D>().enabled = false;
        isSuperPunchActive = false;
        animator.SetBool("superPunch", false);
        animator.SetBool("Run", true);

    }





    public void SuperSpeed (bool isTrueSpeed) {
		
        player.movementSpeed = 100;
        HealthScript health = GameObject.FindWithTag("Player").GetComponent<HealthScript>();
        hpSS = health.hp;
        health.hp = 1000;
            
        Invoke("StopSpeed",1.5f);


		}
    void StopSpeed()
    {
      
        player.movementSpeed = 0;
        HealthScript health = GameObject.FindWithTag("Player").GetComponent<HealthScript>();
        health.hp = hpSS;
        

    }

	public void Flying (bool isTrueFly) {
		
       
		if (isTrueFly && _flyingCooldown <= 0) {

            _flyingEnable = true;
			Invoke("Soda",0.5f);

            _flyingCooldown = _flyingRate;
            //movement = new Vector3 (0, speed.y * 1, 0);
            //rigidbody2D.velocity = movement;
            //} else {
            //	movement = new Vector3 (0, speed.y * -1, 0);
            //		rigidbody2D.velocity = movement;
        }
	}

	void Soda()
    {
        myRigitbody.velocity = new Vector3(3f, FlyingForse * 1f, 0f);

		effects.SetActive (true);
		Invoke ("Deeffector",3.0f);


    }
	void Deeffector(){
		effects.SetActive (false);
	}

	public void SuperJump () {
//		isGrounded = GameObject.Find("Player").GetComponent<Player> ().isGrounded;

        if (IsGrounded) 	 
			myRigitbody.velocity += jumpForce * 1.7f * Vector2.up;
		  
	}
}
