using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    private Rigidbody2D myRigitbody;
    public float movementSpeed;
    public float jumpForce;

	public static Animator playerAnimator;
    private float isgroundtimer;

	//IsGrounded start
	public float groundCheckRadius;
	public Transform groundCheck;
	public LayerMask whatIsGrounded;
	public static bool IsGrounded;

	//IsGrounded  end
	//IsClouded start
	public float isCloudCheckRadius;//адиус соприкосновения глова-хмара
	public Transform isCloudCheck; // сама точка на голове (headpoint)
	public LayerMask whatIsCloud; // леер для определения соприкосновений с тучками
	public static bool isCloudHeadTouch; // возвращает true когда голова в контакте с тучей
	public static bool isCloudfootTouch;// возвращает true когда персонаж стоит на туче

    //IsClouded end

    bool isSuperJumpActive;       //переменная на проверку активен ли супер прыжок

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
		playerAnimator.SetBool("IsGrounded", IsGrounded);

    }

    public void JumpInput()
		{
			if (PauseScript.isPause) {
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
  

}
