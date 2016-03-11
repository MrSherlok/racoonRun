using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SuperPower : MonoBehaviour {
	bool superSpeedEnable = false;
	bool flyingEnable;
	bool superJumpEnable;
	public bool cookieRangEnable;
	public bool rayEnable;
	public bool superPowerEnable;
	public ChooseSPScript choose;
	public GameObject fantasy;

    private float _flyingRate = 0.5f;
    private float _flyingCooldown = 0;

    public bool isSuperSpeedActive = false;
	public int FlyingForse = 4;
	public Rigidbody2D myRigitbody;
	private bool isGrounded;
	public float jumpForce = 10f;

	public Image superSpeedImage;
	public Image flyingImage;
	public Image superJumpImage;
//	public Image superSpeedImage;
//	public Image superSpeedImage;
//	public Image superSpeedImage;


	public void FixedUpdate () {
		superSpeedEnable = ChooseSPScript.chooseSuperSpeedEnable;
		flyingEnable = ChooseSPScript.choooseFlyingEnable;
		superJumpEnable = ChooseSPScript.chooseSuperJumpEnable;

        if (_flyingCooldown > 0)
        {
            _flyingCooldown -= Time.deltaTime;
        }

        //fantasy = GameObject.Find ("Fantasy");
        //	choose = GameObject.Find ("Fantasy").GetComponent<ChooseSPScript>();

        /*		cookieRangEnable = choose.cookieRangEnable;
                rayEnable = choose.rayEnable;
                superPowerEnable = choose.superPowerEnable;
        */


        if (superSpeedEnable == true) {
			superSpeedImage.enabled = true;
		} else {
			superSpeedImage.enabled = false;
		}

		if (flyingEnable == true) {
			flyingImage.enabled = true;
		} else {
			flyingImage.enabled = false;
		}

		if (superJumpEnable == true) {
			superJumpImage.enabled = true;
		} else {
			superJumpImage.enabled = false;
		}
		
	/*	if (superSpeedEnable) {
			superSpeedImage.enabled = true;
		} else {
			superSpeedImage.enabled = false;
		}

		if (superSpeedEnable) {
			superSpeedImage.enabled = true;
		} else {
			superSpeedImage.enabled = false;
		}
		
		if (superSpeedEnable) {
			superSpeedImage.enabled = true;
		} else {
			superSpeedImage.enabled = false;
		}*/

	}




	public void SuperSpeed (bool isTrueSpeed) {
		Player player = gameObject.GetComponent<Player> ();
        player.movementSpeed = 100;
        HealthScript health = GameObject.FindWithTag("Player").GetComponent<HealthScript>();
        health.enabled = false;
            isSuperSpeedActive = true;
        Invoke("StopSpeed",1f);


		}
    void StopSpeed()
    {
        Player player = gameObject.GetComponent<Player>();
        player.movementSpeed = 0;
        HealthScript health = GameObject.FindWithTag("Player").GetComponent<HealthScript>();
        health.enabled = true;
        isSuperSpeedActive = false;

    }

	public void Flying (bool isTrueFly) {
		
       
		if (isTrueFly && _flyingCooldown <= 0) {

            flyingEnable = true;
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

    }

	public void SuperJump () {
		isGrounded = GameObject.FindWithTag ("Player").GetComponent<Player> ().isGrounded;
		if (isGrounded) {
			myRigitbody.velocity += jumpForce * 1.7f * Vector2.up;
		}  
	}
}
