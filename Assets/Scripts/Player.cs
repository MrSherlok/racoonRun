using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{	
	public bool iDead= false;
    private Rigidbody2D myRigitbody;
    
	float jumpForce = 40f;

	public static Animator playerAnimator;
    private float isgroundtimer;

	//IsGrounded start
	public float groundCheckRadius = 0.5f;
	public Transform groundCheck;
	public LayerMask whatIsGrounded;
	public static bool IsGrounded;

	//IsGrounded  end
	//IsClouded start
	public float isCloudCheckRadius = 0.5f;//адиус соприкосновения глова-хмара
	public Transform isCloudCheck; // сама точка на голове (headpoint)
	public LayerMask whatIsCloud; // леер для определения соприкосновений с тучками
	public static bool isCloudHeadTouch; // возвращает true когда голова в контакте с тучей
	public static bool isCloudfootTouch;// возвращает true когда персонаж стоит на туче

    //IsClouded end


    void Start()
    {	
		playerAnimator = GameObject.Find("Player1").GetComponent<Animator>();
        myRigitbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        IsGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGrounded);
		isCloudHeadTouch = Physics2D.OverlapCircle(isCloudCheck.position, isCloudCheckRadius, whatIsCloud);
		isCloudfootTouch = Physics2D.OverlapCircle(groundCheck.position, isCloudCheckRadius, whatIsCloud);
		playerAnimator.SetBool ("IsGrounded", IsGrounded);
		

    }

    public void JumpInput()
		{
		if (PauseScript.isPause && iDead == false) {
			
			if (IsGrounded == true) {
            
				//		прыжок велосити
				myRigitbody.velocity += jumpForce * Vector2.up;
			}
		}
	}
	public void IKick(){
		playerAnimator.SetTrigger ("HeadKick");
	}
	public void IGetDamage(){
		
			playerAnimator.SetTrigger ("GetDamage");	
	}
	public void DieEnot(int sposobSmerti){
		if (sposobSmerti == 1)
			playerAnimator.SetTrigger("IsDead");
		if (sposobSmerti == 2)
			playerAnimator.SetTrigger("IsDead2");
			iDead = true;		
	}
}
